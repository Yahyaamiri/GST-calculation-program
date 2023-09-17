using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GST_calculation_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string product_name,checkGST;
            int product_quantity, checkGST1, checkGST2, product_cost ;
           
            Console.WriteLine("please enter the product name");
              product_name = Convert.ToString(Console.ReadLine());
               Console.WriteLine("please enter the product quantity");
                product_quantity = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("please enter the product cost");
                  product_cost = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Please enter the GST if included");
                     checkGST=Convert.ToString(Console.ReadLine());

            if (checkGST=="yes") {

                checkGST1= product_cost * (3 / 23);

                Console.WriteLine("The GST is counted and is equal to: " + checkGST1);

            } else {
                checkGST2 = product_cost * 15 / 100;
                Console.WriteLine("The GST for your product is equal to: "+checkGST2);

                Console.ReadLine();
            }
            
                Console.ReadKey();
              
            }
          

        }


    }
        
   
            
            
            
        
    


/*
 int[] y1 = new int[10];
            int i, counter_even, counter_odd, n;



            Console.WriteLine("Enter 10 numbers :");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {

                if (y1[i] % 2 == 0)
                {
                    counter_even = y1[i]++;
                    Console.WriteLine("The even numbers are" + counter_even);

                }
                else if (y1[i] % 2 == 1)
                {
                    counter_odd = y1[i]++;
                    Console.WriteLine("The odd numbers are" + counter_odd);
                }
                Console.ReadKey();
*/
        
/*
int num, sum;              //declare a variable for later use
int[] a = new int[10];   // declare array type variable 

Console.WriteLine("Enter five numbers");  // aske users to enter five numbers
num = Convert.ToInt32(Console.ReadLine());  //covert all the users input and store in num
for (num = 1; num < 10; num++)    // this loop start values, condition and increment
{

    a[num] = Convert.ToInt32(Console.ReadLine());  // num results array store in a

}
*/











