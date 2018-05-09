/********************** Programming Assignment #1 ***************************** 
* Programmer:  Stephanie Zendejo 
* 
* Course:  CSCI 3321
* 
* Date:  February 2, 2018
* 
* Assignment:  Rounding Errors versus Truncation Errors
* 
* Environment:  Visual Studio, C# 
* 
* Purpose:   To design and construct a computer program that will illustrate the
* effects of rounding errors and truncation errors. 
* 
* Input: The following values are initially defined as x = 2, h = 1. These values are
* for the function sin(x^3)+x^2 and the derivative formula [f(x+h) - f(x)] / h. 
* 
* Preconditions: The variable h will be halved until it is less than 2.0e-12.
* The true answer is given as 4 + 12cos(8). The approximation to f'(x) by the true 
* answer to calculate the error in approximation.
* 
* Output:  Printed on the console: the values of h, approximation to f'(x), error
* 
* Algorithm: 
* Function
* defined by the given function
* 
* Derivative
* defined by given formula
* 
* Main
* x  = 2 as point
* 4+12cos(8) as approx
* 2.0e-12 as stop
* Print headers to console
* While h is less than stop
*   Print h, derivative, error
*   h = h / 2
*           
***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment1 {
    class Program {
        public const double point = 2.0;
        public const double approx = 2.2539995942966376896;
        public const double stop = 2.0e-12;
        static double function(double x) {
            double fx = Math.Sin(x * x * x) + (x * x);
            return fx;
        }
        static double derivative(double x, double h) {
            double dfx = (function(x + h) - function(x)) / h;
            return dfx;
        }
        static void Main(string[] args) {
            double h = 1;
            Console.WriteLine("{0,-30}{1,30}{2,30}", "h", "approx to f'(x)", "error");
            while(h > stop) {
                //Console.WriteLine(h + "\t\t" + derivative(point, h) + "\t\t" + (approx - derivative(point,h)));
                Console.WriteLine("{0,-30}{1,30}{2,30}", h, derivative(point, h), (approx - derivative(point, h)));
                h /= 2;
            }
            Console.ReadLine();
        }
    }
}
