using System;

namespace homework7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRec = new Rectangle();
            System.Console.Write("Enter length of rectangle: ");
            firstRec.side1 = double.Parse(Console.ReadLine());
            System.Console.Write("Enter width of rectangle: ");
            firstRec.side2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Perimeter of your rectangle: {firstRec.PerimeterCalculate()}");
            System.Console.WriteLine($"Area of your rectangle: {firstRec.Area}");
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
