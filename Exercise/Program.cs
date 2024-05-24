
using Exercise.Helpers;
using Exercise.UI;
using System;


namespace Exercise
{


internal class Program
{

        //  private static ConsoleUI _ui = new ConsoleUI() 
        //  private static ConsoleUI _ui = new();
 
        // Instantiate a class that implements the interface,BUT WE CAN PUT IT IN THE IUI 


 
    static void Main()
    {
          IUI ui = new ConsoleUI();
            Main main = new Main(ui); 
            main.Run();
    }

  

}

}