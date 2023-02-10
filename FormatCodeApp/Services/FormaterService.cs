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
                StringBuilder newText = new StringBuilder();
                StringBuilder replacableText = new();
                string previousLine = string.Empty;
                int lineNumber = 0;
                int startBracketCount = 0;
                int endBracketCount = 0;

                foreach (var line in streamReader)
                {
                    Console.WriteLine("Reading line text: " + line);

                    if (line.Contains("private") || string.IsNullOrWhiteSpace(line))
                    {
                        previousLine = "";
                        continue;
                    }

                    if (line.Contains("using") && line.EndsWith(";")
                        || line.Contains("namespace") && line.EndsWith(";")
                        || line.Contains("{") && line.Contains("}") && line.Contains("get;") && line.Contains("set;"))
                    {
                        previousLine = line;
                        newText.AppendLine(line.TrimEnd());

                        if(line.Contains("get;") && line.Contains("set;") && line.EndsWith("}"))
                            newText.AppendLine();

                        continue;
                    }

                    if (((previousLine.Contains("namespace") || previousLine.Contains("class") || previousLine.Contains("interface"))
                        || (line.Contains("namespace") || line.Contains("class") || line.Contains("interface")))
                        && line.Contains("{"))
                    {
                        replacableText.Clear();
                        startBracketCount = 0;
                        endBracketCount = 0;
                        previousLine = line;

                        newText.AppendLine(line.TrimEnd());
                        continue;
                    }

                    if (line.Contains("{"))
                    {
                        if (line.Trim().Length == 1 && startBracketCount == 0)
                            replacableText.AppendLine(previousLine.TrimEnd());

                        startBracketCount++;
                    }

                    if (line.Contains("}"))
                    {
                        endBracketCount++;
                    }

                    if (startBracketCount > 0)
                        replacableText.AppendLine(line.TrimEnd());

                    if (startBracketCount == 0)
                        newText.AppendLine(line.TrimEnd());

                    //replace with the new text
                    if (startBracketCount > 0 && startBracketCount == endBracketCount)
                    {
                        string replacableTextStr = replacableText.ToString();
                        newText = new(FormattedProperty(newText.ToString(), replacableTextStr));
                        newText.AppendLine();

                        replacableText.Clear();
                        startBracketCount = 0;
                        endBracketCount = 0;
                    }

                    lineNumber++;
                    previousLine = line;
                }

                await File.WriteAllTextAsync(path, newText.ToString(), Encoding.UTF8);
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
