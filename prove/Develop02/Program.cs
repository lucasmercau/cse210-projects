using System;
// My assignment "Exceeds Requirements" because I have included a new option "5. Find an entry" that searches for an entry of a specific date. If there is no entry, it will show a message that will make the user know that.  
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int option = 0;
        Journal journal = new Journal();
        while (option != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Find an entry"); // This is the option that exceeds requirements.
            Console.WriteLine("6. Quit");
            Console.Write("What do you like to do? ");
            option = int.Parse(Console.ReadLine());
            if (option < 1 || option > 6)
            {
                Console.WriteLine("Please choose a number between 1-6.");
            }
            else if (option == 1)
            {
                Entry entry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();
                DateTime currentDate = DateTime.Now;

                entry._date = currentDate.ToString("MM/dd/yyyy");
                entry._prompt = promptGenerator.Display();
                Console.WriteLine(entry._date);
                Console.WriteLine(entry._prompt);
                entry._answer = Console.ReadLine();
                journal._entries.Add(entry);
                

            }
            else if (option == 2)
            {
                journal.Display();
            }
            else if (option == 3)
            {
                Console.WriteLine("What is the filename?");
                journal._fileName = Console.ReadLine();
                journal.LoadFile();
                
            }
            else if (option == 4)
            {   
                Console.WriteLine("What is the filename?");
                journal._fileName = Console.ReadLine();
                journal.SaveFile();
            }
            else if (option == 5) // This is the part that exceeds requirements.
            {   
                Console.WriteLine("What is the date?(mm/dd/yyyy)");
                string date = Console.ReadLine();
                bool foundEntries = false;
                journal._entries.ForEach((it) => {
                    if (date == it._date) {
                        Console.WriteLine($"Date: {it._date} - Prompt: {it._prompt}\n{it._answer}\n");
                        foundEntries = true;
                    }
                });
                if (!foundEntries)
                {
                    Console.WriteLine("No entries found for the specified date.");
                }
            
            }
        }
    }
}