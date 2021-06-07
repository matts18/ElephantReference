using System;

namespace ElephantReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };


            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while(true)
            {
                var line = Console.ReadLine();
                if(int.TryParse(line,out int number))
                {
                    if(number == 1)
                    {
                        Console.WriteLine("You pressed 1");
                        Console.WriteLine("Calling lloyd.WhoAmI()");
                        lloyd.WhoAmI();
                    }
                    else if(number == 2)
                    {
                        Console.WriteLine("You pressed 2");
                        Console.WriteLine("Calling lucinda.WhoAmI()");
                        lucinda.WhoAmI();
                    }
                    else if(number == 3)
                    {
                        Console.WriteLine("You pressed 3");
                        exchangeReferences();
                        Console.WriteLine("References have been swapped");
                    }
                    else if(number == 4)
                    {
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                    }
                    else if(number == 5)
                    {
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            void exchangeReferences()
            {
                Elephant placeHolder = lloyd;
                lloyd = lucinda;
                lucinda = placeHolder;
                
            }
        }

        
    }
}
