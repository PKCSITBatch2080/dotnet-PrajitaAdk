
using System.IO;
class FDHandling
{
    //File to
    public static void CreateFile()
    {
        var folderPath = @"E:\Dotnet-Prajita\firstconsoleapp\G.FileIO"; //[@] takes the url as it is 
        var filePath = $"{folderPath}\\student.txt";

        File.WriteAllText(filePath, "This is first line of text");

        Directory.CreateDirectory($"{folderPath}\\Dummy");

        //Create 10 files with names file1.cs, file2.cs ..
        //Each file should contain a byte variable "age" with value as 1, 2, 3 ....

        for(int counter = 1; counter <= 10; counter++)
        {
            var file = $"File{counter}";
            var fileP = $"{folderPath}\\Dummy\\{file}.cs";
            File.WriteAllText(fileP, "class" + file + " { } ");
        }

        //reading
        var content = File.ReadAllText(@"E:\Dotnet-Prajita\firstconsoleapp\G.FileIO\student.txt");
        var words =content.Split(' ' ,',' ,'-','.',':');
        Console.WriteLine(words.Length);
        
    }
}