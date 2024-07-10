using System.IO;

public class Journal
{
    //Entry newEntry = new Entry();
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    //public void AddEntry(Entry newEntrytext)
    {
        Entry newEntry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();
        //Console.WriteLine(promptGenerator.GetRandomPrompt());
        newEntry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        newEntry._date = DateTime.Now;
        //newEntry._date = Console.ReadLine();
        newEntry.entryText = Console.ReadLine();
        _entries.Add(newEntry);
        
        

       

    }

    public void DisplayAll()
    { 
        
        
        foreach (var newEntry2 in _entries)
         {
                 newEntry2.Display();
         }

    }

    //public void SaveTextFile(string file)
    public void SaveTextFile()
    {
        string filename = Console.ReadLine();

         try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine($"Date: {e._date} -- Prompt {e._promptText}");
                    outputFile.WriteLine(e.entryText);
                    outputFile.WriteLine("");
                    
                    
                }

                // You can use the $ and include variables just like with Console.WriteLine
            //     string color = "Blue";
            //     outputFile.WriteLine($"My favorite color is {color}");
            //     Console.WriteLine("Wow");
            }
            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    

    }

    //public void LoadTextFile(string file)
    public void LoadTextFile() 
    {
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            
            Console.WriteLine(line);
            
        }

    }
}