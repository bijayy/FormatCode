// See https://aka.ms/new-console-template for more information
using FormatCodeApp.Models;
using FormatCodeApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Text.Json;

Console.WriteLine("Executing...");

//var builder = new ConfigurationBuilder()
//               .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true });
//var configuration = builder.Build();

var json = await File.ReadAllTextAsync("appsettings.json");

FormaterService.AppSettings = JsonSerializer.Deserialize<AppSettings>(json);

FormaterService.FormatProperty();
Console.ReadLine();