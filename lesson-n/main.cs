using System;

class Program
{
    static void Main()
    {
        string input, output = "";
        int choice;

        Console.Write(
            "Hello, Pick your poison!\n" +
            "1.  Tits!\n" +
            "2.  Ass!\n" +
            "3.  I can't choose!\n" +
            "Enter choice: "
        );
        
        input = Console.ReadLine();
        choice = int.Parse(input);
        
        switch (choice) {
            case 1:
                output = TitsOrAss("tits");
                break;
            case 2:
                output = TitsOrAss("ass");
                break;
            case 3:
                output = TitsOrAss();
                break;
        }
        Console.WriteLine(output);
    }

    static string TitsOrAss(string type = "both")
    {
        string result;
        
        if (type == "tits") {
            result = "Boobies are great!";
        } else if (type == "ass") {
            result = "Butts, amirite!?";
        } else {
            result = "Tits and ass for everyone!";
        }

        return result;
    }
}
