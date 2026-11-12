using Tyuiu.GaitovaAA.Sprint3.Task3.V12.Lib;

namespace Tyuiu.GaitovaAA.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Гаитова А. А. | Группа: ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Гаитова А. А. | Группа: ПКТб-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: bkkrk ckkkcs ksr             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "bkkrk ckkkcs ksr";
            char chr = 'k';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимальное количество символов подряд = " + ds.GetMaxCharCount(value, chr));
            Console.ReadKey();
        }
    }
}