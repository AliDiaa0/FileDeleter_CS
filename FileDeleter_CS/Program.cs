using System;
using System.IO;
using System.Windows.Forms;

namespace FileDeleter_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set console title
            Console.Title = "File Deleter V1.0 (by Ali Diaa)";

            //Cyan
            Console.ForegroundColor = ConsoleColor.Cyan;

            //This asks you if you want to delete a file or folder
            Console.WriteLine("Enter 'File' if you want to delete a file.\n\r" + "Enter 'Folder' if you want to delete a folder: \n\r");

            //White
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();

            //If you entered 'File' in the console
            if (input == "File")
            {
                //Yellow
                Console.ForegroundColor = ConsoleColor.Yellow;

                //This asks you about the path of file you want to delete
                Console.WriteLine("\n\rEnter the path of file you want to delete (YOU MUST ENTER FILE'S EXTENSION): \n\r");

                //White
                Console.ForegroundColor = ConsoleColor.White;

                //Path of file you want to delete
                string pathFile = Console.ReadLine();

                //This will check if it's possible to delete file. If it was, file will be deleted
                try
                {
                    File.Delete(pathFile);

                    //Green
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\rFile deleted successfully!");
                }

                //If it failed to delete file, it will tell you why what the problem is
                catch (Exception exFile)
                {
                    Console.WriteLine(exFile.Message);
                }

                //This will wait you until you enter something before the console closes
                Console.ReadKey();
            }

            //If you want to delete a folder instead
            else if (input == "Folder")
            {
                //Yellow
                Console.ForegroundColor = ConsoleColor.Yellow;

                //This asks you about the path of folder you want to delete
                Console.WriteLine("\n\rEnter the path of folder you want to delete: \n\r");

                //White
                Console.ForegroundColor = ConsoleColor.White;

                //Path of folder you want to delete
                string pathFolder = Console.ReadLine();

                //This will check if it's possible to delete folder. If it was, folder will be deleted
                try
                {
                    Directory.Delete(pathFolder, true);

                    //Green
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\rFolder deleted successfully!");
                }

                //If it failed to delete folder, it will tell you what the problem is
                catch (Exception exFolder)
                {
                    Console.WriteLine(exFolder.Message);
                }

                //This will wait you until you enter something before the console closes
                Console.ReadKey();
            }

            //If you entered an invalid value at the beginning of this program
            else
            {
                MessageBox.Show("Invalid value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}