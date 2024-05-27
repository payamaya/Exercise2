
using Exercise;
using Exercise.UI;

class CalcGroupPriceChecker
{
    private static ConsoleUI _ui = new();

    public static void CalculatGroupPrice()
    {

        _ui.Print("Ange antal personer i sällskapet:");
        //Fix to take only interger and minus number uint
      /*  int numberOfPeople = Convert.ToInt32(_ui.GetInput());*/
        string input = _ui.GetInput();
        // Ensure Input values are valid integer
        // Validate and convert to string
        if(!int.TryParse(input, out int numberOfPeople) || numberOfPeople <= 0)
        {
            _ui.Print("Ogiltigt antal personer. Ange ett giltigt heltal större än 0.");
            return;
        }

        int totalCost = 0;

        for (int i = 0; i < numberOfPeople; i++)
        {
            _ui.Print($"Ange ålder för person {i + 1}:");
            /*int age = Convert.ToInt32(_ui.GetInput());*/
             input = _ui.GetInput();

            if (!int.TryParse(input, out int age) || age < 0) 
            {
                _ui.Print("Ogiltig ålder. Ange ett giltigt heltal större än eller lika med 0.");
                i--; // Prompt for the same person's age again
                continue;
            }
            if (age < 5 || age > 100)
            {
                //Children under five and pensioners over 100 go free
                _ui.Print($"Person {i + 1}: Gratis");
            }
            else if (age < 20)
            {
                totalCost += 80;
            }
            else if (age > 64)
            {
                totalCost += 90;
            }
            else
            {
              //standard price
                totalCost += 120;
            }
        }

        _ui.Print($"Antal personer: {numberOfPeople}");
        _ui.Print($"Totalkostnad för hela sällskapet: {totalCost}kr");

    }
}

