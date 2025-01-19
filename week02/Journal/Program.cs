using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Text.Json; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! Welcome to the Journal Program!");

        int choiceInt = 0;
        string nameOfFile = "";
        
        Journal journal = new Journal();

        do
        { 
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do now? ");
            string choice = Console.ReadLine();
            choiceInt = int.Parse(choice);

            if (choiceInt == 1)
            {
                Entry entry = new Entry();
                
                PromptGenerator randomPrompt = new PromptGenerator();
                entry._promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                string entryText = Console.ReadLine();

                
                entry._entryText = entryText;
                
                DateTime now = DateTime.Now;
                string date = now.ToString("d-MMM-yy");
                entry._date = date;

                journal.AddEntry(entry);

            }

            if (choiceInt == 2)
            {
                foreach (Entry entry in journal._entries)
                {
                    entry.Display();
                }
            }

            if (choiceInt == 3)
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                nameOfFile = filename;
                journal.LoadFromFile(nameOfFile);
            }

            if (choiceInt == 4)
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                nameOfFile = filename;
                journal.SaveToFile(nameOfFile);
            }
        } while (choiceInt != 5);
    }

}