using System;

namespace CG_5_1_whatisyourname
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("What is your name?");

            //added blank line in between name of app and first user input for readability
            Console.WriteLine();

            //ask user to enter first name and last name
            //define each name input as a string and give each variable a name
            Console.Write("Please type your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please type your last name: ");
            string lastName = Console.ReadLine();

            //blank space added for clarity for user
            Console.WriteLine();

            Console.WriteLine("Your full name is: {0}", FullName(firstName, lastName));
            
            Console.ReadLine();

        }

       
        //create new method to combine user entered first name and last name into one variable
        
        private static string FullName(string firstName, string lastName)
        {
            //create string variable name for first name, a space, and last name together
            /*use return + new variable name (of first space and last names combined) to carry variable *out of* 
             * the method to be used in line of code above*/

            string firstlast = firstName + " " + lastName;
            return firstlast;
        }





    }
}
