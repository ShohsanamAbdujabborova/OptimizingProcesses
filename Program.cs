using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Please , enter directory path: ");
        string userDirectory = Console.ReadLine();

        try
        {
            if (Directory.Exists(userDirectory))
            {
                DisplayDirectoryContents(userDirectory);

                Console.Write("Do you want to delete directory ?(yes/no) ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Directory.Delete(userDirectory, true);
                    Console.WriteLine($"\"{userDirectory}\" directory deleted.");
                }
                else
                {
                    Console.WriteLine("Not removed.");
                }
            }
            else
            {
                Console.WriteLine($"\"{userDirectory}\" is not existing .");//nomli mavjud emas
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Xatolik yuz berdi: {ex.Message}");
        }

        
    }

    static void DisplayDirectoryContents(string directoryPath)
    {
        string[] files = Directory.GetFiles(directoryPath);
        string[] directories = Directory.GetDirectories(directoryPath);

        Console.WriteLine($"\"{directoryPath}\" All files in directory :"); //directory ichidagi fayllar

        foreach (string file in files)
        {
            Console.WriteLine($"- {file}");
        }

        Console.WriteLine($"\"{directoryPath}\" All subdirectories in Directory:");
        //Directory ichidagi subdirectorylar

        foreach (string dir in directories)
        {
            Console.WriteLine($"- {dir}");
        }
    }
}