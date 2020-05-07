using System;

namespace Task4WebApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                //Prompt the user for minutes exercised
                Console.WriteLine("===========================================================");
                Console.WriteLine(" Enter two numbers to play the game or type \"quit\" to end the program : ");

                Console.WriteLine("===========================================================");

                Console.Write("Enter your first number : ");

                string firstEntry = Console.ReadLine();

                Console.Write("Enter your second number : ");

                string secondEntry = Console.ReadLine();

                if (firstEntry.ToLower() == "quit" || secondEntry.ToLower() == "quit"){
                    break;
                }

                double FirstEntry = double.Parse(firstEntry);
                double SecondEntry = double.Parse(secondEntry);

                if (FirstEntry < 0 || SecondEntry < 0) {

                    throw new Exception("Number must be positive and non zero");
                    break;
                }

                double checkedFirstEntry = Math.Sqrt(FirstEntry);
                double checkedSecondEntry = Math.Sqrt(SecondEntry);

                try{
                    
                    if (checkedSecondEntry == checkedFirstEntry)
                    {

                        Console.WriteLine("Please enter two different numbers. Thanks");
                        break;

                    }else if(checkedFirstEntry > checkedSecondEntry){

                        Console.WriteLine(FirstEntry + " with Square root " + checkedFirstEntry + " is higher than " + SecondEntry + " with square root of " + checkedSecondEntry);

                    }else if(checkedSecondEntry > checkedFirstEntry){

                        Console.WriteLine(SecondEntry + " with Square root " + checkedSecondEntry + " is higher than " + FirstEntry + " with square root of " + checkedFirstEntry);

                    }
                }catch (FormatException){
                    Console.WriteLine("That is not valid input!");
                    continue;
                }
                Console.WriteLine("===========================================================");
                Console.WriteLine("Good bye. ");
                Console.WriteLine("===========================================================");
            }
        }
    }
}
