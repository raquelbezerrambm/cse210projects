using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! Welcome to the Journal Program!");

        List<Entry> entries = new List<Entry>();
        int choiceInt = 0;

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

                entries.Add(entry);

            }

            if (choiceInt == 2)
            {
                foreach (Entry entry in entries)
                    entry.Display();
            }

            if (choiceInt == 3)
            {

            }

            if (choiceInt == 4)
            {

            }
        } while (choiceInt != 5);
    }

}