using System;

namespace homework7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
                class Rectangle{
            public double side1 {get; set; }
            public double side2 {get; set; }
            public Rectangle (double side1, double side2){
                this.side1 = side1;
                this.side2 = side2;
            }
            public Rectangle(){
                
            }
            public double AreaCalculate(){
                return side1 * side2;
            }
            public double PerimeterCalculate(){
                return 2 * (side1 + side2);
            }
            public double Area {
                get{
                    return side1 * side2;
                }
                }
            public double Perimeter {
                get{
                    return 2 * (side1 + side2);
                }
                }
        }
    }
}
