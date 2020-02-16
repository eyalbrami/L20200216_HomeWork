using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200216_HomeWork
{

    /*
     לכתוב מחלקה מלבן שיורשת מ
     shape
     שממשת את 
     getArea
     ומגדירה מתודה נוספת
     getPerimeter.
     אז ליצור מחלקה ריבוע שיורשת ממלבן 
     ומבלי להגדיר דבר חוץ מקונסטרקטור במחלקה ריבוע 
     לקבל מחלקה שתעבוד ותחזיר נכון את שטח והיקף הריבוע.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(25, 10);
            Square square = new Square(10,10); 
            Console.WriteLine($"the Area of this rectangle is : { rectangle.GetArea() }");
            Console.WriteLine($"the Perimeter of this rectangle is : { rectangle.GetPerimeter() }");

            Console.WriteLine($"the Area of this square is : { square.GetArea() }");
            Console.WriteLine($"the Perimeter of this square is : { square.GetPerimeter() }");

            Console.ReadLine();
        }
    }
}
