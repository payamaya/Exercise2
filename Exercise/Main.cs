using Exercise.Helpers;
using Exercise.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{

    internal class Main
    {
        private void ShowMainMenu()
        {
            _ui.Print("Välkommen till huvudmenyn");
            _ui.Print("Välj en funktion genom att skriva in motsvarande siffra:");
            _ui.Print($"{MenyHelpers.CheckAge}. Ungdom eller pensionär");
            _ui.Print($"{MenyHelpers.CalculateGroupPrice}. Räkna ut priset för ett helt sällskap");
            _ui.Print($"{MenyHelpers.RepeatText}. Upprepa en text tio gånger");
            _ui.Print($"{MenyHelpers.ThirdWord}. Det tredje ordet");
            _ui.Print($"{MenyHelpers.Quit}. Avsluta programmet");
        }
        private IUI _ui;

        public Main(IUI ui)
        {
           _ui = ui;
        }

        public void Run()
        {
            /*  Main mani = new Main();*/
            bool isRunning = true;

            while (isRunning)
            {
                ShowMainMenu();

                _ui.PrintWrite("Ditt val: ");
                string input = _ui.GetInput()!;// ! to hide the null

                switch (input)
                {
                    case MenyHelpers.CheckAge:
                        CheckAge();
                        break;
                    case MenyHelpers.CalculateGroupPrice:
                        CalculateGroupPrice();
                        break;
                    case MenyHelpers.RepeatText:
                        RepeatText();
                        break;
                    case MenyHelpers.ThirdWord:
                        ThirdWord();
                        break;
                    case MenyHelpers.Quit:
                        Environment.Exit(0);
                        _ui.Print("Programmet avslutas.");
                        isRunning = false;
                        break;
                    default:
                        _ui.Print("Felaktigt val. Försök igen.");
                        break;
                }

                _ui.Print(string.Empty); // Lägg till en tom rad för ökad läsbarhet
            }
        }
        public void CheckAge()
        {
            AgeChecker.CheckAge();
        }

        public void CalculateGroupPrice()
        {
            CalcGroupPriceChecker.CalculatGroupPrice();
        }

        public void RepeatText()
        {
            RepeatTextChecker.RepeatChecker();

        }

        public void ThirdWord()
        {
            ThirdWordChecker.ThirdWordTextChecker();

        }
    

    }
}
