using System;

namespace Lab_2._3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult = 1;
            Console.Write("Введiть кiлькiсть елементiв масиву:\t");
            int number = int.Parse(Console.ReadLine());
            int[] mass = new int[number];
            Random r = new Random();
            for (int i = 0; i < mass.Length; i++)
            {

                
                mass[i] = r.Next(-100,100);
                Console.WriteLine($"Eлемент массиву под iндексом {i} =\t"+mass[i]);
            }

            Console.WriteLine("Виводимо масив:");
            for (int i = 0; i < mass.Length; i++) 
            {
                Console.WriteLine(mass[i]);
            }

            for(int i=0;i< mass.Length; i++)
            {
                if (mass[i] > 0)
                    mult *= mass[i];
                

            }

            Console.WriteLine("Добуток додатнiх елементiв массиву=" + mult);
            int sum = 0,elem=0,k=0;
            for(int i = 0; i < mass.Length; i++)
                if(mass[i]>0)
                {
                    elem = mass[i];
                    k = i;
                }
            if (elem <= 0) Console.WriteLine("Додатньiнiх елементiв в массивi немає!");
            else Console.WriteLine("Останній  елемент в масивi: " + elem);
            for (int i = 0; i < k; i++)
                sum += mass[i];
            Console.WriteLine("Сумa елементiв масиву, розташованих до останнього додатного елементa: " + sum);
            Console.ReadKey();

        }
    }
}
