
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Praktika2
{
    class Program
    {
        static void Main() => Start();
        static void Start()
        {
            WriteLine("\n1. Игра угадай число.\n2. Таблица умножения\n3. Вывод делителей числа\n0\0. Выход\n\nВведите команду");
            int caseID = Convert.ToInt32(ReadLine());
            SelectedCase(caseID);
        }
        static void SelectedCase(int caseID)
        {
            switch (caseID) {
                case 0:
                    WriteLine("Уверены что хотите выйти?\ny/n");
                    string exit = Convert.ToString(ReadLine());
                    if (exit == "n") Main();
                    else break;
                    break;
                case 1:
                    Random rand = new Random();
                    int Secret = rand.Next(1, 100);
                    WriteLine("Я сгенерировал число от 1 до 100, угадай его, а я буду подсказывать\nPS. У тебя 20 попыток" );
                    for (int i = 1; i<20; i++)
                    {
                        WriteLine("\nВведи число ");
                        int a = Convert.ToInt32(ReadLine());
                        if (a == Secret)
                        {
                            WriteLine("Умничка, ты угадал\n");
                            Main();
                        }
                        else
                        {
                            if (a < Secret) WriteLine(" Побольше");
                            else WriteLine(" Поменьше");
                        }
                    }
                    WriteLine("\nДа ты вообще бездарь, увидимся позже");
                    Main();
                    break;
                case 2:
                    List<int> arr = new List<int>();
                    WriteLine("Таблица умножения:");
                    for (int k = 1; k!=10; k++)
                    {
                        for (int g = 1; g!= 10; g++)
                        {
                            arr.Add(g * k);
                            if (arr[g-1] >9) Write(arr[g - 1]+"  ");
                            else Write(arr[g - 1] + "   " );
                        }
                        arr.Clear();
                        WriteLine();
                    }
                    Main();
                    break;
                case 3:
                    WriteLine("\nВведи целое  число ");
                    int nnn = Convert.ToInt32(ReadLine());
                    for (int i = 1; i!= nnn; i++) if (nnn % i == 0) WriteLine(nnn / i);
                    WriteLine("1");
                    Main();
                    break;
            }
        }
    }
}