DataFinder
This is a C# console application that can search for a key in a CSV file. It was created as part of a backend test for a job application.

Requirements
.NET 7
A CSV file formatted as follows:
1,Rossi,Fabio,01/06/1990;
2,Gialli,Alessandro,02/07/1989;
3,Verdi,Alberto,03/08/1987;

Usage
To run the application, use the following command:

dotnet run <file.csv> <column> <key>

where <file.csv> is the path to the CSV file, <column> is the index of the column to search in (starting from 0), and <key> is the value to search for.

The application will print the matching line if found, or a message if not found. For example:

dotnet run ./file.csv 2 Alberto

Output:

3,Verdi,Alberto,03/08/1987;
