/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
namespace tesk64
{
    public class Tesk
    {
        public static void Main()
        {
            Console.Write("Первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            FillArray(number1, number2);


        }
        public static void FillArray(int number1, int number2)
        {
            if (number1 > number2) return;
            FillArray(number1 + 1, number2);
            Console.Write(number1 + ", ");
        }
        /*public static void PrintArray(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }*/
    }
}