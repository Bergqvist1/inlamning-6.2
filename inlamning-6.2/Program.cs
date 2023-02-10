using System;
namespace Uppgift_6_2
{
    class Program
    {

        static void Största(int tal1, int tal2)
        {

            if(tal1 > tal2)
            {
                Console.WriteLine($"{tal1} är störst. {tal1} är större än {tal2}");
 
            }

            if(tal2 > tal1)
            {
                Console.WriteLine($"{tal2} är störst. {tal2} är större än {tal1}");
  
            }

            if(tal1 == tal2)
            {
                Console.WriteLine($"Tal1 och Tal2 = {tal1} & {tal2} är lika stora");
            }

        }

        static void Main(string[] args)
        {

            Största(25, 30);

        }
    }
}
