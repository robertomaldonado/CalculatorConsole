using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysConsole = System.Console;
using Calculator.Console.Helpers;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SysConsole.ReadKey(); //Pause before starting
            int calcType = 0;
            do
            {
                calcType = PromptCalculatorType();
                if (calcType == 1)
                {
                    int calculation = PromptBasicCalculation();

                    if (calculation > 0 && calculation <= 8) //4 Actions here
                    {
                        SysConsole.Write("First Number(x): ");
                        int leftOperand = Int32.Parse(SysConsole.ReadLine());
                        SysConsole.Write("\nSecond Number(y): ");
                        int rightOperand = Int32.Parse(SysConsole.ReadLine());

                        switch (calculation)
                        {
                            //Functions that use GET (Odd cases)
                            case 1:
                                SysConsole.WriteLine($"Addition is: {new BasicHelper().Addition(leftOperand, rightOperand)}");
                                break;
                            case 3:
                                SysConsole.WriteLine($"Subtraction is: {new BasicHelper().Subtraction(leftOperand, rightOperand)}");
                                break;
                            case 5:
                                SysConsole.WriteLine($"Multiplication is: {new BasicHelper().Multiplication(leftOperand, rightOperand)}");
                                break;
                            case 7:
                                SysConsole.WriteLine($"Division is: {new BasicHelper().Division(leftOperand, rightOperand)}");
                                break;

                            //Functions that use POST (even cases)
                            case 2:
                                SysConsole.WriteLine($"Addition is: {new BasicHelper().Addition(leftOperand, rightOperand)}");
                                break;
                            case 4:
                                SysConsole.WriteLine($"Subtraction is: {new BasicHelper().Subtraction(leftOperand, rightOperand)}");
                                break;
                            case 6:
                                SysConsole.WriteLine($"Multiplication is: {new BasicHelper().Multiplication(leftOperand, rightOperand)}");
                                break;
                            case 8:
                                SysConsole.WriteLine($"Division is: {new BasicHelper().Division(leftOperand, rightOperand)}");
                                break;
                            default:
                                break;
                        }

                    } else if (calculation > 8)
                    {
                        switch (calculation)
                        {
                            //Functions that use GET
                            case 9: //Square root
                                SysConsole.Write("Number(x): ");
                                int num = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Square root is: {new BasicHelper().SquareRoot(num)}");
                                break;
                            case 11: //Power, base and exponent
                                SysConsole.Write("Base(x): ");
                                int num_base = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.Write("Exponent(y): ");
                                int num_exp = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Power is: {new BasicHelper().Power(num_base, num_exp)}");
                                break;
                            case 13: //Exponential(Power): e^Power
                                SysConsole.Write("Power(x): ");
                                int num_power = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Exponential(Power) is: {new BasicHelper().Exp(num_power)}");
                                break;
                            case 15: //Log(base, parameter)
                                SysConsole.Write("Base(x): ");
                                num_base = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.Write("Parameter(y): ");
                                int num_param = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Log(base, parameter) is: {new BasicHelper().Log(num_base, num_param)}");
                                break;
                                
                            //Functions that use POST
                            /*
                            case 10: //Square root
                                SysConsole.Write("Number(x): ");
                                int num = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Square root is: {new BasicHelper().SquareRoot(num)}");
                                break;
                            case 12: //Power, base and exponent
                                SysConsole.Write("Base(x): ");
                                int num_base = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.Write("Exponent(y): ");
                                int num_exp = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Power is: {new BasicHelper().Power(num_base, num_exp)}");
                                break;
                            case 14: //Exponential(Power): e^Power
                                SysConsole.Write("Power(x): ");
                                int num_power = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Exponential(Power) is: {new BasicHelper().Exp(num_power)}");
                                break;
                            case 16: //Log(base, parameter)
                                SysConsole.Write("Base(x): ");
                                num_base = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.Write("Parameter(y): ");
                                int num_param = Int32.Parse(SysConsole.ReadLine());
                                SysConsole.WriteLine($"Log(base, parameter) is: {new BasicHelper().Log(num_base, num_param)}");
                                break;
                                */
                            default:
                                break;
                        }
                    }
                }
                else if (calcType == 2)
                {
                    int advCalculation = PromptAdvancedCalculation();


                }
                else
                {
                    SysConsole.WriteLine("Incorrect option...");
                }


                } while (calcType != 3) ;
         }

        static int PromptCalculatorType()
        {
            SysConsole.WriteLine("#################### WELCOME ###############");
            SysConsole.WriteLine("#################### TO ####################");
            SysConsole.WriteLine("#################### CALCULATOR ############");
            SysConsole.WriteLine("Please choose the type of calculator you want to use:");
            SysConsole.WriteLine("1.Basic Calculator");
            SysConsole.WriteLine("2.Advanced Calculator");
            SysConsole.WriteLine("3.Exit");
            return Int32.Parse(SysConsole.ReadLine());
        }

        static int PromptBasicCalculation() {                              
            SysConsole.WriteLine("1.Addition (via GET)");
            SysConsole.WriteLine("2.Addition (via POST)");
            SysConsole.WriteLine("3.Subtraction (via GET)");
            SysConsole.WriteLine("4.Subtraction (via POST)");
            SysConsole.WriteLine("5.Multiplication(x, y) (via GET)");
            SysConsole.WriteLine("6.Multiplication(x, y)  (via POST)");
            SysConsole.WriteLine("7.Division(x, y) (via GET)");
            SysConsole.WriteLine("8.Division(x, y) (via POST)");
            SysConsole.WriteLine("9.Sqrt(x) (via GET)");
            SysConsole.WriteLine("10.Sqrt(x) (via POST)");
            SysConsole.WriteLine("11.Power(Base, Exponent) (via GET)");
            SysConsole.WriteLine("12.Power(Base, Exponent) (via POST)");
            SysConsole.WriteLine("13.Exponential(Power) (via GET)");
            SysConsole.WriteLine("14.Exponential(Power) (via POST)");
            SysConsole.WriteLine("15.Log(base, parameter) (via GET)");
            SysConsole.WriteLine("16.Log(base, parameter) (via POST)");
            return Int32.Parse(SysConsole.ReadLine());
        }

        static int PromptAdvancedCalculation()
        {
            SysConsole.WriteLine("1.QuadraticEquation(a, b, c): find the roots of f(x) = ax ^ 2 + bx + c using quadratic equation");
            SysConsole.WriteLine("2.Vertex(a, b): return the vertex of the parabola f(x) = ax ^ 2 + bx + c");
            SysConsole.WriteLine("3.Slope(x1, y1, x2, y2): return the slope given two points(x1, y1) and(x2, y2)");
            SysConsole.WriteLine("4.Random(min, max): return a random integer between min and max");
            SysConsole.WriteLine("5.AreaTriangle(base, height): return the area of a triangle with the provided base and height");
            SysConsole.WriteLine("6.AreaRectangle(length, width): return the area of a rectangle with the provided length and width");
            SysConsole.WriteLine("7.AreaCircle(radius): return the area of a circle with the provided radius");
            SysConsole.WriteLine("8.Fibonacci(n): return the nth fibonacci number");
            return Int32.Parse(SysConsole.ReadLine());
        }

    }
}
