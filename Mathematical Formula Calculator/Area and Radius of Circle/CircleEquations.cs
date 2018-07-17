using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_equations
{
    class Program
    {
        

        private static void Main()

        {
            getvalue();
            void getvalue()
            {
                try
                {
                    Console.WriteLine("Please enter the radius value. ");
                    double radiusInput = double.Parse(Console.ReadLine());
                    if(radiusInput<0)
                    {
                        Console.WriteLine("Enter values larger than 0.");                      
                    }
                    else
                    {
                        return;
                    }

                    double pi = 3.15159;
                    double circumferenceValue = radiusInput * pi * 2;
                    Console.WriteLine($"The circumference is {circumferenceValue}");

                    double areaValue = (radiusInput * radiusInput) * pi;
                    Console.WriteLine($"The area of the circle is {areaValue}");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter only numbers.");
                    Console.WriteLine("");
                    getValues();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The calculated value is too high for this formula.");
                }

                catch (Exception)
                {
                    Console.WriteLine("An error occured. Please try again.");
                }
                finally
                {
                    Console.WriteLine("The program has terminated.");
                }
            }
        }
        
    }
}
             