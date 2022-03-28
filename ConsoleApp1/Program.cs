using Microsoft.Extensions.Configuration;
using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

String currentFolder = "D:\\TEMP\\FTP";
var fileName = "test.file.txt";
var newExtention = "tmp";
FileInfo f = new FileInfo(currentFolder + "\\" + fileName);
if(f.Exists)
{
    var newFileName = fileName.Substring(0, fileName.Length - f.Extension.Length) + "." + newExtention;
    f.MoveTo(currentFolder + "\\" + newFileName);
}

var s = Console.ReadLine();
Console.WriteLine($"User input = [{s}]. Hit enter to continue");
Console.ReadKey();
// Test pull request
