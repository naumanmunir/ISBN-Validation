using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN_Validator
{
    class ISBN
    {
        static void Main(string[] args)
        {
            string isbnInput;
            string close;
            bool closeAPP = false;
            do
            {
                Console.WriteLine("To close the app any time, press X. \nEnter a ISBN number: ");
                isbnInput = Console.ReadLine();

                validator(isbnInput);

                if (isbnInput.Length > 10 || isbnInput.Length < 10)
                {
                    Console.WriteLine("Invalid ISBN! Try again.");
                }
            }
            while
            (closeAPP == true);
        }

        public static bool validator(string isbnNum)
        {
            int multiplier = 10;
            char holder;
            int result = 0;
            for (int i = 0; i < isbnNum.Length; i++ )
            {
                holder = isbnNum[i];

                result += Convert.ToInt32(holder.ToString()) * multiplier;
                //Console.WriteLine(result);
                multiplier--;
            }

            if(result % 11 == 0)
            {
                Console.WriteLine("Valid ISBN.");
            }
            else
                Console.WriteLine("Invalid ISBN.");
            //Console.WriteLine(result);
                
            return true;
        }
    }
}
