using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglapfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so tu nhien n:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++) 
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
