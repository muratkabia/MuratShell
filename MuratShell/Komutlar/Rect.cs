using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratShell.Komutlar
{
    class Rect
    {
        public Rect(String[] args)
        {
            int area, length, width;
            length = Convert.ToInt32(args[1]);
            width = Convert.ToInt32(args[2]);
            area = length * width;
            Console.WriteLine("The area of rectangle : {0}", area);
        }

        public Rect()
        {
            int area, length, width;
            Console.Write("Please write the length of your rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the width of your rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("The area of rectangle : {0}", area);
        }
    }
}
