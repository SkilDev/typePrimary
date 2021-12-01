using System;

namespace typePrimary
{
    class Program
    {
        public static void Main()
        {
           // пример работы с циклом while
           /* int i = 0;            
            while (i < 5)
            {
                int j = 0;
                
                while (j < 5)
                {                    
                    Console.Write("[]");
                    j++;
                }
                Console.WriteLine();
                i++;
            }*/

            // Пример работы с циклом  do - while

            int i = 0;

            do
            {
                int j = 0;
                do
                {
                    Console.Write("[ ]");
                    j++;
                    
                } while (j < 5);
                Console.WriteLine();
                i++;
                
            } while (i < 5);
            
        }

    }
}