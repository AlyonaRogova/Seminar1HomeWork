using System;

namespace Seminar1HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
            
            //Ввод данных
            int num_a;

            int num_b;

            Console.Write("Введите число a: ");
            num_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            num_b = Convert.ToInt32(Console.ReadLine());
            
            //Сравнение чисел и вывод
            if (num_a > num_b){
                Console.WriteLine("Число a большее, число b  меньшее");
            }    
            else{
                Console.WriteLine("Число b большее, число a меньшее");
            }
            */

            
            /*
            // Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

            //Ввод данныхх пользователем
            int num1;

            int num2;

            int num3;

            Console.Write("Введите число 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Сравнение чисел между собой
            if (num1 > num2 && num1 > num3){
                Console.WriteLine ("Максимальное число 1");
            }

            else if (num2 > num1 && num2 > num3){
                Console.WriteLine ("Максимальное число 2");    
            }

            else if (num3 > num1 && num3 > num2){
                Console.WriteLine ("Максимальное число 3");
            }
            */

            /*
            //Напишите программу, которая на ввод принимает чсло и выдаст, 
            //является ли число четным (делиться ли оно на 2 без остатка)

            //Ввод числа
            int num;

            Console.Write("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Вывод результата
            if (num % 2 == 0){
                Console.WriteLine("Число четное");
            } 
            else{
                Console.WriteLine("Число нечетное");
            }           
            */

            
            //Напишите программу, которая на вход принимает число (N),
            //а на выходе показывает все четные числа от 1 до N

            //Ввод данных
            
            int num;

            Console.Write("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
    
            int current = 1;

            // Вывод результата

            while (current <= num){
                if (current % 2 == 0){
                    Console.WriteLine (current + " ");
                }
                current++;                   
            }

                 
            
        }
    }
}


