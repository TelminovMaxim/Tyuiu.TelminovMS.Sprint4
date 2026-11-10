using Tyuiu.TelminovMS.Sprint4.Task6.V7.Lib;

namespace Tyuiu.TelminovMS.Sprint4.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            


            Console.Title = "Спринт #4 | Выполнил: Тельминов М. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Тельминов Максим Сергеевич | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных  [\"Математика\", \"Физика\", \"Химия\",    *");
            Console.WriteLine("* \"Биология\", \"География\", \"История\", \"Экономика\"] используя      *");
            Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых больше 8.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            string[] st = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };

            Console.WriteLine("Массив: ");

            foreach (string s in st) 
            { 
                Console.WriteLine(s);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(st);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
