using FormatCodeApp.Models;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace FormatCodeApp.Services;

public class FormaterService
{
    public static AppSettings? AppSettings = new();

    public static void FormatProperty()
    {
        Execute(async () =>
        {
            var files = Directory.GetFiles(AppSettings!.FilePath, '*' + AppSettings.FileExtension);

            foreach (var file in files)
            {
                var tempFile = new FileInfo(file);
                string path = Path.Combine(AppSettings!.FilePath, tempFile.Name);

                string fileText = await File.ReadAllTextAsync(path);
                string[] streamReader = fileText.Split(Environment.NewLine, StringSplitOptions.None);
                StringBuilder formattedString = new StringBuilder();
                StringBuilder peropertyText = new();
                string previousLine = string.Empty;
                int lineNumber = 0;
                int startBracketCount = 0;
                int endBracketCount = 0;

                foreach (var line in streamReader)
                {
                    Console.WriteLine("Reading line text: " + line);

                    if (line.Contains("private") || string.IsNullOrWhiteSpace(line)) //Removes private field from models
                    {
                        previousLine = "";
                        continue;
                    }

                    if (line.Contains("using") && line.EndsWith(";") //Just add as it is if using, namesapce and get; set; already applied.
                        || line.Contains("namespace") && line.EndsWith(";")
                        || line.Contains("{") && line.Contains("}") && line.Contains("get;") && line.Contains("set;"))
                    {
                        previousLine = line;
                        formattedString.AppendLine(line.TrimEnd());

                        if(line.Contains("get;") && line.Contains("set;") && line.EndsWith("}"))
                            formattedString.AppendLine();

                        continue;
                    }

                    if (((previousLine.Contains("namespace") || previousLine.Contains("class") || previousLine.Contains("interface"))
                        || (line.Contains("namespace") || line.Contains("class") || line.Contains("interface")))
                        && line.Contains("{")) // If namesapce, class, interface then add as it is.
                    {
                        peropertyText.Clear();
                        startBracketCount = 0;
                        endBracketCount = 0;
                        previousLine = line;

                        formattedString.AppendLine(line.TrimEnd());
                        continue;
                    }

                    if (line.Contains("{")) // If property then increase the counter and add text to the property text.
                    {
                        if (line.Trim().Length == 1 && startBracketCount == 0)
                            peropertyText.AppendLine(previousLine.TrimEnd());

                        startBracketCount++;
                    }

                    if (line.Contains("}"))
                    {
                        endBracketCount++;
                    }

                    if (startBracketCount > 0) // If property then add text to the property text.
                        peropertyText.AppendLine(line.TrimEnd());

                    if (startBracketCount == 0) // If not property then add text to the formattedString.
                        formattedString.AppendLine(line.TrimEnd());

                    //replace with the new text
                    if (startBracketCount > 0 && startBracketCount == endBracketCount) // If property full collected then replace with formatted property.
                    {
                        string replacableTextStr = peropertyText.ToString();
                        formattedString = new(FormattedProperty(formattedString.ToString(), replacableTextStr));
                        formattedString.AppendLine();

                        peropertyText.Clear();
                        startBracketCount = 0;
                        endBracketCount = 0;
                    }

                    lineNumber++;
                    previousLine = line;
                }

                await File.WriteAllTextAsync(path, formattedString.ToString(), Encoding.UTF8);
            }
        });
    }

    public static void FormatMethod()
    {
        Execute(() =>
        {

        });
    }

    private static string FormattedProperty(string newText, string property)
    {
        string[] strings = property.Split(Environment.NewLine);

        if (!IsProprty(property))
        {
            return newText.TrimEnd().Replace(strings[0].TrimEnd(), "") + property;
        }

        if (newText.Trim().EndsWith(strings[0].Trim()))
        {
            return newText.TrimEnd() + " { get; set; }" + Environment.NewLine;
        }

        return newText + FormattedProperty(property);
    }

    private static string FormattedProperty(string property)
    {
        int index = property.IndexOf("{");

        if (string.IsNullOrWhiteSpace(property) || !IsProprty(property))
            return property;

        property = property.Remove(index).Replace(Environment.NewLine, string.Empty).TrimEnd() + " { get; set; }" + Environment.NewLine;
        return property;
    }

    private static bool IsProprty(string text)
    {
        string[] strSplit = text.Split(' ');

        foreach (string str in strSplit)
        {
            if (str.Contains("get") || str.Contains("set"))
                return true;
        }

        return false;
    }

    private static void Execute(Action action,
        [CallerMemberName] string? methodName = null,
        [CallerLineNumber] int lineNumber = 0,
        [CallerFilePath] string? callerPath = null)
    {
        try
        {
            Console.WriteLine($"Start of {methodName} method.");

            action();

            Console.WriteLine($"End of {methodName} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"End of {methodName} with an exception {JsonSerializer.Serialize(ex)}");
        }
    }
}
