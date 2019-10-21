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
                        SysConsole.Write("Second Number(y): ");
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

                    }
                    else if (calculation > 8)
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

                    switch (advCalculation)
                    {
                        //Methods that use GET 
                        //Quad Eq
                        case 1:
                            SysConsole.Write("Coeficient for x: ");
                            int a = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Coeficient for y: ");
                            int b = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Constant c: ");
                            int c = Int32.Parse(SysConsole.ReadLine());

                            //TO-DO
                            SysConsole.WriteLine($"Root of equation is: {new AdvancedHelper().QuadEq(a, b, c)}");
                            break;
                        //Vertex
                        case 3:
                            //TO-DO
                            break;
                        //Slope
                        case 5:
                            SysConsole.Write("Value for x1: ");
                            int x1 = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Value for y1: ");
                            int y1 = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Value for x2: ");
                            int x2 = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Value for y2: ");
                            int y2 = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Slope is: "); //TO-DO
                            break;
                        //Random
                        case 7:
                            SysConsole.Write("Minimum value: ");
                            int min = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Maximum value: ");
                            int max = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Random number is: "); //TO-DO
                            break;
                        //Area Triangle
                        case 9:
                            SysConsole.Write("Base of Triangle: ");
                            int base_tr = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Height of Triangle: ");
                            int height_tr = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Triangle Area is: "); //TO-DO
                            break;
                        //Area Rectangle
                        case 11:
                            SysConsole.Write("Width for Rectangle: ");
                            int widht = Int32.Parse(SysConsole.ReadLine());
                            SysConsole.Write("Height for Rectangle: ");
                            int height = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Rectangle Area is: "); //TO-DO
                            break;
                        //Area Circle
                        case 13:
                            SysConsole.Write("Radius for Circle: ");
                            int radius = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Circle Area is: "); //TO-DO
                            break;
                        //Fibonacci at (n)
                        case 15:
                            SysConsole.Write("Fibonacci Number for position: ");
                            int index = Int32.Parse(SysConsole.ReadLine());

                            SysConsole.WriteLine($"Fibonnacci at that index is: "); //TO-DO
                            break;

                       //Methods that use POST
                        case 2:
                            break;
                        case 4:
                            break;
                        case 6:
                            break;
                        case 8:
                            break;
                        case 10:
                            break;
                        case 12:
                            break;
                        case 14:
                            break;
                        case 16:
                            break;
                        default:
                            break;
                    }
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
            SysConsole.WriteLine("1.QuadraticEquation(a, b, c) (via GET)");
            SysConsole.WriteLine("2.QuadraticEquation(a, b, c) (via POST)");
            SysConsole.WriteLine("3.Vertex(a, b) (via GET)");
            SysConsole.WriteLine("4.Vertex(a, b) (via POST)");
            SysConsole.WriteLine("5.Slope(x1, y1, x2, y2) (via GET)");
            SysConsole.WriteLine("6.Slope(x1, y1, x2, y2) (via POST)");
            SysConsole.WriteLine("7.Random(min, max) (via GET)");
            SysConsole.WriteLine("8.Random(min, max) (via POST)");
            SysConsole.WriteLine("9.AreaTriangle(base, height) (via GET)");
            SysConsole.WriteLine("10.AreaTriangle(base, height) (via POST)");
            SysConsole.WriteLine("11.AreaRectangle(length, width) (via GET)");
            SysConsole.WriteLine("12.AreaRectangle(length, width) (via POST)");
            SysConsole.WriteLine("13.AreaCircle(radius) (via GET)");
            SysConsole.WriteLine("14.AreaCircle(radius) (via POST)");
            SysConsole.WriteLine("15.Fibonacci(n) (via GET)");
            SysConsole.WriteLine("16.Fibonacci(n) (via POST)");
            return Int32.Parse(SysConsole.ReadLine());
        }

    }
}
