using Tyuiu.TelminovMS.Sprint4.Task7.V4.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Итоговый Проект                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897\". Преобразуйте ее в   *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            string st = "382976421897";
            int n = 3, m = 4;

            Console.WriteLine($"Строка: {st}");
            Console.WriteLine($"Размер матрицы: {n} на {m}");





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(n, m, st);
            Console.WriteLine($"Сумма нечетных чисел: {res}");

            Console.ReadKey();

        }
    }
}