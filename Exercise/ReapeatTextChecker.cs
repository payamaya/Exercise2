using Exercise.UI;

class RepeatTextChecker
{

    // private static ConsoleUI _ui = new ConsoleUI();
    private static ConsoleUI _ui = new();


    public static void RepeatChecker()
    {
       _ui.Print("Ange en text:");
        // Read a line of text from the console input.
        string text = Console.ReadLine()!;


        // Iterate through the loop ten times to print the text with an index number.
        // Each iteration appends the index number and text followed by a comma and space,
        for (int i = 0; i < 10; i++)

        {
            /*  if (i > 0)
              {

           _ui.Print($"{i + 1}. {text}");
              }
              else
               {
                  _ui.Print($"{i}. {text}");
               }*/
            Console.Write($"{i + 1}.{text}, ");

        }
       _ui.Print(string.Empty);
    }
}
