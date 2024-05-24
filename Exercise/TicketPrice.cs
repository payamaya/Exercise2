/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class TicketPrice
    {
        private string _age;
        private string _price;
        public string Age { 
            get
            {
                Console.WriteLine("Ange ålder:");
                string input = Console.ReadLine()!;
                //Check if the input is a valid integer , no whitespaces(IsNullOrWhiteSpace)
                *//* if(int.TryParse(input, out int age))*//*
                if (uint.TryParse(input, out uint age))
                {
                    if (age < 5 || age > 100)
                    {
                        // Barn under fem och pensionärer över 100 går gratis
                        Console.WriteLine($"Person {age}: Gratis");
                    }
                    else if (age < 20)
                    {
                        Console.WriteLine("Ungdomspris: 80kr");
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else
                    {
                        Console.WriteLine("Standardpris: 120kr");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig input , ange en siffra");
                }
                return input;
            }
              
            
            
            set{
                _age = value;
            }
            }
      
        public int Price { get; set; }

    }

}




*//*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal enum TicketPrice
    {
        Youth,
        Pensioner,
        Standard
    }
   
}

 */