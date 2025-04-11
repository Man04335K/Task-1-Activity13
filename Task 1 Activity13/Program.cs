using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 50: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            if (number >= 1 && number <= 50)
            {
                if (number % 2 == 0 || number % 3 == 0)
                {
                    Console.WriteLine("Success");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
///Pseudiocode
///Start
///Initialize integer variable "number"
///Display "Enter a number between 1 and 50:"
///Read user input into "number"
///If number < 1 OR number > 50 THEN
   /// Display "Invalid"
///ELSE
   /// If number MOD 2 = 0 OR number MOD 3 = 0 THEN
      ///  Display "Success"
    ///ENDIF
///ENDIF
///End
