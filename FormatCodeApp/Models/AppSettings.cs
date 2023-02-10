namespace FormatCodeApp.Models;

public class AppSettings
{
    public static readonly string Id = "AppSettings";
    public string FilePath { get; set; } = string.Empty;
    public string FileExtension { get; set; } = ".cs";
    public bool FormatProperty { get; set; }
    public bool FormatMethod { get; set; }
}
