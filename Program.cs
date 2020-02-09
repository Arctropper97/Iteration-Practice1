using System;

namespace Iteration_Practice1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            int i;
            

            for (i = start; i <= end; i++)
            {
                Console.WriteLine(i + " ");
            }

            //We are declaring the variables for our while loop
            int end1 = 10;
            int count = 1;
            

            while(count <= end1)
            {
                Console.WriteLine(count + " ");
                count++;  
            }
            Console.WriteLine("You did it!");
            
        }
    }
}


