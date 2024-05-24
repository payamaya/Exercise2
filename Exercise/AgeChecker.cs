using Exercise.UI;
class AgeChecker
{
    private static ConsoleUI _ui = new();
    public static void CheckAge()
    {
        _ui.Print("Ange ålder:");
        string input = Console.ReadLine();
        //Check if the input is a valid integer , no whitespaces(IsNullOrWhiteSpace)
        /* if(int.TryParse(input, out int age))*/
        if (uint.TryParse(input, out uint age))
        {
            if (age < 5 || age > 100)
            {
                // Barn under fem och pensionärer över 100 går gratis
                _ui.Print($"Person {age}: Gratis");
            }
            else if (age < 20)
            {
                _ui.Print("Ungdomspris: 80kr");
            }
            else if (age > 64)
            {
                _ui.Print("Pensionärspris: 90kr");
            }
            else
            {
                _ui.Print("Standardpris: 120kr");
            }
        }
        else
        {
            _ui.Print("Ogiltig input , ange en siffra");
        }
    }

}

