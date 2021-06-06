using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posled4iselProgres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество цифр");
            int number = Convert.ToInt32(Console.ReadLine());//кол цифр в массиве
            int[] arrayNumbers = new int[number];//массив чисел
            for(int i=0; i< arrayNumbers.Length; i++)//цикл добавления цифр
            {
                Console.WriteLine($"Введите число {i}");
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());//добавление цифр человеком
            }
           
            IsProgression(arrayNumbers);//вызова метода
            Console.ReadKey();
        }
        public static void  IsProgression(int[] array)//метод проверки
        {
            int difArithmetic = array[1] - array[0];// способ проверки на арифметическую прогрессию
            int difGeometric = array[1] / array[0];//способ проверки на геометрическую прогрессию

            bool isArithmetic = true;
            bool isGeometric = true;

            for (int i = 1; i < array.Length - 1; i++)//цикл проверки чисел
            {
                if (isArithmetic == true)
                    if (array[i + 1] - array[i] != difArithmetic)// проверка на арифметическую прогрессию
                        isArithmetic = false;

                if (isGeometric == true)
                    if (array[i + 1] / array[i] != difGeometric)// проверка на геометрическую прогрессию
                        isGeometric = false;
            }
             if(isArithmetic == true)// условие на вывод информации
                {
                    Console.WriteLine("Массив чисел, является арифметической прогрессией");
                }
            if (isGeometric == true)
                {
                    Console.WriteLine("Массив чисел, является геометрической прогрессией");
                }
            if(isGeometric==false && isArithmetic==false)
                {
                    Console.WriteLine("Массив чисел, не является геометрической и арифметической прогрессией");
                }
        }
    }
}
