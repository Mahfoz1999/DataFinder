namespace DataFinder;

class Program
{
    static void Main(string[] args)
    {
        // Check if the arguments are valid
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: dotnet run <file.csv> <column> <key>");
            return;
        }

        // Get the arguments
        string file = args[0];
        int column = int.Parse(args[1]);
        string key = args[2];

        // Check if the file exists
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found: " + file);
            return;
        }

        // Open the file and read the lines
        using (StreamReader reader = new(file))
        {
            // Loop through the lines
            while (!reader.EndOfStream)
            {
                // Read a line and split it by comma
                string line = reader.ReadLine();
                string[] fields = line.Split(',');

                // Check if the column index is valid
                if (column < 0 || column >= fields.Length)
                {
                    Console.WriteLine("Invalid column index: " + column);
                    return;
                }

                // Check if the key matches the field in the column
                if (fields[column] == key)
                {
                    // Print the matching line and exit
                    Console.WriteLine(line);
                    return;
                }
            }
        }

        // If no match is found, print a message
        Console.WriteLine("No match found for key: " + key);
    }
}
