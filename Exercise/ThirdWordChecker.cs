
using Exercise.UI;

class ThirdWordChecker
{
    //private static ConsoleUI _ui = new ConsoleUI();
    private static ConsoleUI _ui = new();

    public static void ThirdWordTextChecker()
    {
        _ui.Print("Ange en mening med minst 3 ord:");
        string sentence = _ui.GetInput()!;

        // Initialize an empty list to store words.
        // Create a list to store individual words extracted from a sentence.
        List<string> wordsList = new List<string>();

        //AddRange aad elements to the ends of the List<T>
        wordsList.AddRange(sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        if (!int.TryParse(wordsList[0], out int number))
        {
            if (wordsList.Count >= 3)
            {
                _ui.Print($"Det tredje ordet är: {wordsList[2]}");
            }
            else 
            {
                _ui.Print("För få ord i meningen. Försök igen med minst 3 ord.");
            }
          
    
        }

    }
}