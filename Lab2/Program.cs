using System;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bl = true;
            Console.WriteLine(bl);
            byte bt = 236;
            Console.WriteLine(bt);
            sbyte sbt = -3;
            Console.WriteLine(sbt);
            char ch = 'a';
            Console.WriteLine(ch);
            decimal de = 3000.5m;
            Console.WriteLine(de);
            double dou = 1.5d;
            Console.WriteLine(dou);
            float fl = 2.0094f;
            Console.WriteLine(fl);
            uint u= 4294967295;
            Console.WriteLine(u);
            long l = 9223372036854775807;
            Console.WriteLine(l);
            ulong ul = 18446744073709551615;
            Console.WriteLine(ul);
            short sh = 32767;
            Console.WriteLine(sh);
            ushort ush = 65535;
            Console.WriteLine(ush);
            int ic;
            Console.WriteLine("Введите число целочисленного типа:");
            ic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"bl = {bl}, bt = {bt}, sbt = {sbt}, ch = {ch}, de = {de}"); //Интерполированное форматирование 
            Console.WriteLine("dou = {0}, fl = {1}, ic= {2}, u= {3}, l = {4}, ul = {5}, sh = {6}, ush = {7}"
                , dou, fl, ic, u, l, ul, sh, ush); //Составное форматирование 

            //b. Явное и неявное преобразование 
            int num = 222;      //Неявное
            long lnum = num;

            char ch2 = 'W';     //Неявное
            int cnum = ch2;

            short sh2 = 353;    //Явное
            int int2 = (int)sh2;

            double dnum = 65.4; //Явное с использованием класса Convert
            int int3 = Convert.ToInt32(dnum);

            int int4 = 34;      //Явное
            char ch3 = (char)int4;

            //с. Упаковка 
            Object a = bt;
            byte bb2 = (byte)a;

            //d. Неявная типизация
            var fl2 = 4.3F;

            //e. Nullable
            int? int5 = null;
            Console.WriteLine(int5 == null);
            //------------------------------------------------
            //Строки
            //а. 
            string str1 = "Hello";
            string str2 = "World";
            int res = String.Compare(str1, str2);
            if (res == 0)
                Console.WriteLine($"Строка {str1} = {str2}");
            else
                Console.WriteLine($"Строка {str1} != {str2}");

            //b. 
            String st1 = "One";
            String st2 = "Two";
            String st3;
            String st4 = "Three Four";

            Console.WriteLine(st1 + st2);           //Сцепление
            st3 = st2;                              //Копирование
            Console.WriteLine(st2.Substring(0,2)); //Подстрока
            string[] words = st4.Split(new char[] { ' ' });//Разделение на слова 
            foreach (string s in words) Console.WriteLine(s);

            st1 = st1.Substring(0, 2) + str2 + st1.Remove(0, 2);
            Console.WriteLine(st1);
            st4 = st4.Remove(4, 6);

            //c.
            string st5 = "";
            string st6 = null;
            if (String.IsNullOrEmpty(st5))
                Console.WriteLine("Str5 пустая или null");
            else
                Console.WriteLine("не null или не пустая");


            if (String.IsNullOrEmpty(st6))
                Console.WriteLine("Str6 пустая или null\n");
            else
                Console.WriteLine("не null или не пустая\n");
            ////d. 
            StringBuilder sb = new StringBuilder(" предоставляет нам и вам");
            sb.Remove(18, 6);
            sb.Insert(0, "Класс System.String");
            sb.Append(" широкую функциональность по работе со строками");
            Console.WriteLine(sb);
            ////---------------------------------------------
            ////Массивы
            ////а.
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int icc = 0; icc < 3; icc++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[icc, j] + " ");
                }
                Console.WriteLine();
            }

            ////b.
            string[] strArr = { "Раз", "Два", "Три", "Четыре" };
            for (int i = 0; i < 4; i++)
                Console.Write(strArr[i] + " ");

            Console.WriteLine(" || Длинна массива строк: " + strArr.Length+"\n");

            string tmp = strArr[0];
            strArr[0] = strArr[3];
            strArr[3] = tmp;

            for (int i = 0; i < 4; i++)
                Console.Write(strArr[i] + " ");

            ////с. 
      
            Console.WriteLine("Начало массива");
            int[][] arrSt = new int[4][];
            arrSt[0] = new int[1];
            arrSt[1] = new int[2];
            arrSt[2] = new int[3];
            arrSt[3] = new int[4];

            Console.WriteLine("\n");
            for (int i=0;i<1;++i)
            {
                arrSt[0][i] = i + 9;
                Console.Write(arrSt[0][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 2; ++i)
            {
                arrSt[1][i] = i + 7;
                Console.Write(arrSt[1][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; ++i)
            {
                arrSt[2][i] = i + 5;
                Console.Write(arrSt[2][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; ++i)
            {
                arrSt[3][i] = i + 3;
                Console.Write(arrSt[3][i] + "  ");
            }

            ////d.
            var ntArr = new int[] { 1, 2, 3, 4 };
            var ntStr = "Не типизированная строка";
            Console.WriteLine("\n" + ntStr);

            ////--------------------------------
            ////Кортежи   
            ////а.
            (string, string, char, int, ulong) crt = ("Nastia", "Kachanova", 'F', 18, 60);
            Console.WriteLine("Имя:     " + crt.Item1);
            Console.WriteLine("Фамилия: " + crt.Item2);
            Console.WriteLine("Символ:  " + crt.Item3);
            Console.WriteLine("Возраст: " + crt.Item4);
            Console.WriteLine("Вес:     " + crt.Item5);

            ////d.
            Console.WriteLine(crt.Item4 + " " + crt.Item2);

            ////c.
            (var aa, var bb3) = (3, "3333");

            ////d
            (int k, byte l) One = (3, 56);
            (long z, uint d) Two = (3, 56);
            Console.WriteLine(One == Two);

            ////---------------------------------
            ////5
            void function(int[] arr, string s)
            {
                int max, min, sum;
                char frst;
                max = arr.Max<int>();
                min = arr.Min<int>();
                sum = arr.Sum();
                frst = s[0];
                var T = Tuple.Create(max, min, sum, frst);
                Console.WriteLine(T);
            }
            string strF = "Hello from the other side";
            int[] arrF = { 1, 2, 3, 4, 5 };
            function(arrF, strF);

            void f1()
            {
                checked//используется для явного включения проверки переполнения
                {
                    int a = 2147483647;
                    Console.WriteLine(a + 1);
                }
            }
            void f2()
            {
                unchecked//используется для подавления проверки переполнения
                {
                    int a2 = 2147483647;
                    Console.WriteLine(a2 + 1);
                }
            }

            //f1();
            f2();

        }
    }
}
