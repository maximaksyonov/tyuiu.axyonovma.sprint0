using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AxyonovMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.AxyonovMA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива: " + Dataservice.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива: " + Dataservice.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива: " + Dataservice.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}
