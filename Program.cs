using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double salmin = 828116;
            double salario = 0;

            Console.WriteLine("Introduzca su salario: ");
            salario = double.Parse(Console.ReadLine());
            if (salario < salmin * 2)
            {
                Console.WriteLine("Caja Compensacion: A partir de su salario, se le asigna la Tarifa A");
                Console.WriteLine("EPS: A partir de su salario, se le asigna la Tarifa de cuota moderadora A ($3.200)");
            }
            else if (salario >= salmin * 2 && salario < salmin * 4)
            {
                Console.WriteLine("Caja Compensacion: A partir de su salario, se le asigna la Tarifa B");
            }
            else if (salario >= salmin * 4)
            {
                Console.WriteLine("Caja Compensacion: A partir de su salario, se le asigna la Tarifa C");
            }

            if (salario >= salmin * 2 && salario < salmin * 5)
            {
                Console.WriteLine("EPS: A partir de su salario, se le asigna la Tarifa de cuota moderadora B ($12700)");
            }
            else if (salario >= salmin * 5)
            {
                Console.WriteLine("EPS: A partir de su salario, se le asigna la Tarifa de cuota moderadora C ($33700)");
            }
        }
    }
}
