using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Whats_anamys_whant
{
    internal class Program
    {
        public int DurInt(String s)
        {
            while (!int.TryParse(s, out int x))
            {
                Console.WriteLine("Вы ввели не целое число.");
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();

            }
            return Convert.ToInt32(s);
        }
        public double DurDub(String s)
        {
            while (!double.TryParse(s, out double x))
            {
                Console.WriteLine("Вы ввели не число.");
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();

            }
            return Convert.ToDouble(s);
        }
        public long Durlong(String s)
        {
            while (!long.TryParse(s, out long x))
            {
                Console.WriteLine("Вы ввели не число.");
                Console.WriteLine("Введите число:");
                s = Console.ReadLine();

            }
            return Convert.ToInt64(s);
        }
        public Char DurChar(String s)
        {
            while (s.Length>1)
            {
                Console.WriteLine("Значение должно принимать ровно один знак!");
                Console.WriteLine("Введите символ:");
                s = Console.ReadLine();

            }
            return Convert.ToChar(s);
        }
        public Char DurMenu(String s)
        {
            return Convert.ToChar(s[0]);
        }
        public bool is2Digits (int x)
        {
            if ((x/10 >0) && (x / 100 == 0))
            {
                return true;
            }
            return false;
        }
        public int CharToNum (char x) {  
            return (int)x -48;
        }
        public double Fraction(double x)
        {
            return x- (int) x;
        }
        public bool isInRange(int a, int b, int num)
        {
            if (a > b)
            {
                if ((num >b) && (num < a))
                {
                    return true;
                }
                return false;
            }
            if ((num <b) && (num > a))
            {
                return true;
            }
            return false;
        }
        public bool isEqual(int a, int b, int c)
        {
            if ((a == b) && (b == c))
            {
                return true ;
            }
            return false;
        }
        public int abs(int x) {
            if (x < 0)
            {
                return -x;
            }
            return x;

        }
        public bool is35(int x)
        {
            if ((x%3==0) || (x % 5 == 0))
            {
                if (x % 15 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public int max3(int x, int y, int z)
        {
            if (x < y)
            {
                x=y;
            }
            if (x < z) {
                x = z;
            }
            return x;
        }
        public int sum2(int x, int y)
        {
            x += y;
            if (x>=10 && x <= 19)
            {
                return x;
            }
            return x;
        }
        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "Понедельник. Работяги, крепитесь.";
                case 2:
                    return "Вторник. Живём.";
                case 3:
                    return "Среда. Ещё половина недели.";
                case 4:
                    return "Четверг! Завтра пятница, живём!";
                case 5:
                    return "Пятница! Гуляй мужик!";
                case 6:
                    return "Суббота! Чил!";
                case 7:
                    return "Воскресенье! Завтра на завод, но сегодня я отдыхыю!";
                default:
                    return "Это не день недень недедели!";
            }
        }
        public String listNums(int x)
        {
            String strs="";
            for (int i=0; i <= x; i++)
            {
                strs += i;
                if (x != i)
                {
                    strs += ' ';
                }
            }
            return strs;
        }
        public String chet(int x) {
            String str = "0";
            for (int i=2; i <= x; i=i+2)
            {
                str += " ";
                str += i;
            }
            return str;

        }
        public int numLen(long x)
        {
            int sh=0;
            while (x > 0)
            {
                sh++;
                x = x / 10;
            }
            return sh;
        }
        public void square(int x) {
            for (int i = 1; i <= x; i++) {
                for (int j = 1; j <= x; j++) {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

        }
        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public int[] fillIn(int len, int l, int r) {
            int[] arr = new int[len];
            Random rnd = new Random();
            for (int i = 0; i<len; i++)
            {
                arr[i] = rnd.Next(l, r);
            }
            return arr;
        }
        public void PrintAra(int[] arr)
        {
            Console.Write("[");
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.Write(arr[i-1]);
                if (i != arr.Length)
                    Console.Write(", ");
            }
            Console.Write("]");
        }
        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == x)
                    return i;
            }

            return -1;
        }
        public int maxAbs(int[] arr)
        {
            int maxim = 0;
            for (int i = 0; i< arr.Length; i++)
            {
                if (abs(arr[i]) > maxim) {  maxim = arr[i];}
            }
            return maxim;
        }
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] tar = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; i++)
            {
                tar[i] = arr[i];
            }
            for (int i = 0; i < ins.Length; i++)
            {
                tar[i+pos] = ins[i];
            }
            for (int i = pos; i < arr.Length; i++)
            {
                tar[ins.Length+i] = arr[i];
            }
            return tar;
        }
        public int[] reverseBack(int[] arr)
        {
            int[] tar = new int[arr.Length];
            for (int i = 0;i < arr.Length; i++)
            {
                tar[tar.Length-i-1] = arr[i];

            }
            return tar;
        }
        public int findCount(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == x) count++;
            }
            return count;
        }
        
        public int[] findAll(int[] arr, int x)
        {
            int[] ind = new int[findCount(arr,x)];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    ind[j] = i;
                    j++;
                }
            }
            return ind;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 5. НЕ ЧЁРНЫЕ ЗАДАНИЯ");
            Program program = new Program();
            char num='z';
            double xd;
            char xc;
            String str;
            char[] chars;
            int[] ara, ins;
            long bong;
            int xi, a, b, c, n;
            while (num != '0')
            {
                Console.WriteLine("Глава 1: Введите номер задания (1-9, < - предидущая глава, > - следующая глава, 0 - выход) ");
                num = program.DurMenu(Console.ReadLine());
                switch (num)
                {
                    case '1':
                        Console.WriteLine("Номер 1");
                        Console.WriteLine("Введите дробное число: ");
                        xd = program.DurDub(Console.ReadLine());
                        Console.WriteLine(program.Fraction(xd));
                        break;
                    case '3':
                        Console.WriteLine("Номер 3");
                        Console.WriteLine("Введите чарку: ");
                        xc = program.DurChar(Console.ReadLine());
                        Console.WriteLine(program.CharToNum(xc));
                        break;
                    case '5':
                        Console.WriteLine("Номер 5");
                        Console.WriteLine("Введите число: ");
                        xi = program.DurInt(Console.ReadLine());
                        if (program.is2Digits(xi))
                            Console.WriteLine("Да, это двузначное");
                        else Console.WriteLine("Нет, это не двузначное");
                        break;
                    case '7':
                        Console.WriteLine("Номер 7");
                        Console.WriteLine("Введите границы: ");
                        Console.WriteLine("[");
                        a = program.DurInt(Console.ReadLine());
                        Console.WriteLine(" : ");
                        b = program.DurInt(Console.ReadLine());
                        Console.WriteLine("]");
                        Console.WriteLine("Введите число ");
                        n = program.DurInt(Console.ReadLine());
                        if (program.isInRange(a, b, n))
                            Console.WriteLine("Да, число входит в диапазон");
                        else Console.WriteLine("Нет, это число не в диапазоне");
                        break;
                    case '9':
                        Console.WriteLine("Номер 9");
                        Console.WriteLine("Введите первое число: ");
                        a = program.DurInt(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = program.DurInt(Console.ReadLine());
                        Console.WriteLine("Введите третье число: ");
                        c = program.DurInt(Console.ReadLine());
                        if (program.isEqual(a, b, c))
                            Console.WriteLine("Да, числа одинаковые");
                        else Console.WriteLine("Нет, числа разные");
                        break;
                    case '>':
                        while (num != '0')
                        {
                            Console.WriteLine("Глава 2: Введите номер задания (1-9, < - предидущая глава, > - следующая глава, 0 - выход) ");
                            num = Convert.ToChar(Console.ReadLine());
                            switch (num)
                            {
                                case '1':
                                    Console.WriteLine("Номер 1");
                                    Console.WriteLine("Введите число: ");
                                    xi = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("Модуль = "+program.abs(xi));
                                    break;
                                case '3':
                                    Console.WriteLine("Номер 3");
                                    Console.WriteLine("Введите число: ");
                                    xi = program.DurInt(Console.ReadLine());
                                    if (program.is35(xi))
                                        Console.WriteLine("Да, делится на 3 или 5, но не одновременно");
                                    else Console.WriteLine("Нет, не делится на 3 или 5 или делится одновременно");
                                    break;
                                case '5':
                                    Console.WriteLine("Номер 5");
                                    Console.WriteLine("Введите первое число: ");
                                    a = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("Введите второе число: ");
                                    b = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("Введите третье число: ");
                                    c = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("МАКСИМальное = "+program.max3(a,b,c));
                                    break;
                                case '7':
                                    Console.WriteLine("Номер 7");
                                    Console.WriteLine("Введите первое число: ");
                                    a = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("Введите второе число: ");
                                    b = program.DurInt(Console.ReadLine());
                                    Console.WriteLine("Сумма чисел = "+program.sum2(a, b));
                                    break;
                                case '9':
                                    Console.WriteLine("Номер 9");
                                    Console.WriteLine("Введите порядковый номер дня: ");
                                    xi = program.DurInt(Console.ReadLine());
                                    Console.WriteLine(program.day(xi));
                                    break;
                                case '>':
                                    while (num != '0')
                                    {
                                        Console.WriteLine("Глава 3: Введите номер задания (1-9, < - предидущая глава, > - следующая глава, 0 - выход) ");
                                        num = program.DurMenu(Console.ReadLine());
                                        switch (num)
                                        {
                                            case '1':
                                                Console.WriteLine("Номер 1");
                                                Console.WriteLine("Введите число: ");
                                                xi = program.DurInt(Console.ReadLine());
                                                Console.WriteLine(program.listNums(xi));
                                                break;
                                            case '3':
                                                Console.WriteLine("Номер 3");
                                                Console.WriteLine("Введите число: ");
                                                xi = program.DurInt(Console.ReadLine());
                                                Console.WriteLine(program.chet(xi));
                                                break;
                                            case '5':
                                                Console.WriteLine("Номер 5");
                                                Console.WriteLine("Введите длинное число: ");
                                                bong = program.Durlong(Console.ReadLine());
                                                Console.WriteLine("Длина числа: "+program.numLen(bong));
                                                break;
                                            case '7':
                                                Console.WriteLine("Номер 7");
                                                Console.WriteLine("Введите высоту квадратов: ");
                                                xi = program.DurInt(Console.ReadLine());
                                                Console.WriteLine("Квадрат размером XxX");
                                                program.square(xi);
                                                break;
                                            case '9':
                                                Console.WriteLine("Номер 9");
                                                Console.WriteLine("Введите высоту треугольника: ");
                                                xi = program.DurInt(Console.ReadLine());
                                                Console.WriteLine("Высота треугольника X");
                                                program.rightTriangle(xi);
                                                break;
                                            case '>':
                                                while (num != '0')
                                                {
                                                    Console.WriteLine("Глава 4: Введите номер задания (1-9, < - предидущая глава, > - следующая глава, 0 - выход) ");
                                                    num = program.DurMenu(Console.ReadLine());
                                                    switch (num)
                                                    {
                                                        case '1':
                                                            Console.WriteLine("Номер 1");
                                                            ara = program.fillIn(10, 1, 10);
                                                            Console.WriteLine("Массив: ");
                                                            program.PrintAra(ara);
                                                            Console.WriteLine("Какое число найти?");
                                                            xi = program.DurInt(Console.ReadLine());
                                                            Console.WriteLine("Его позиция: ");
                                                            Console.WriteLine(program.findFirst(ara,xi));
                                                            Array.Clear(ara,0,ara.Length);
                                                            break;
                                                        case '3':
                                                            Console.WriteLine("Номер 3");
                                                            ara = program.fillIn(10, 1, 10);
                                                            Console.WriteLine("Массив: ");
                                                            program.PrintAra(ara);
                                                            Console.WriteLine("Максимальное в нём: ");
                                                            Console.WriteLine(program.maxAbs(ara));
                                                            Array.Clear(ara, 0, ara.Length);
                                                            break;
                                                        case '5':
                                                            Console.WriteLine("Номер 5");
                                                            ins = program.fillIn(5, 1, 100);
                                                            ara = program.fillIn(10, 1, 100);
                                                            Console.WriteLine("Массив arr: ");
                                                            program.PrintAra(ara);
                                                            Console.WriteLine("\nМассив ins: ");
                                                            program.PrintAra(ins);
                                                            Console.WriteLine("\nКуда поставить ins?");
                                                            xi = program.DurInt(Console.ReadLine());
                                                            Console.WriteLine("Результат: ");
                                                            program.PrintAra(program.add(ara, ins, xi));
                                                            Array.Clear(ara, 0, ara.Length);
                                                            Array.Clear(ins, 0, ins.Length);
                                                            break;
                                                        case '7':
                                                            Console.WriteLine("Номер 7");
                                                            ara = program.fillIn(10, 1, 10);
                                                            Console.WriteLine("Массив: ");
                                                            program.PrintAra(ara);
                                                            Console.WriteLine("\nРазвёрнутый масив: ");
                                                            program.PrintAra(program.reverseBack(ara));
                                                            Array.Clear(ara, 0, ara.Length);
                                                            break;
                                                        case '9':
                                                            Console.WriteLine("Номер 9");
                                                            ara = program.fillIn(10, 1, 10);
                                                            Console.WriteLine("Массив: ");
                                                            program.PrintAra(ara);
                                                            Console.WriteLine("\nКакое число найти?");
                                                            xi = program.DurInt(Console.ReadLine());
                                                            Console.WriteLine("Его позиции: ");
                                                            program.PrintAra(program.findAll(ara, xi));
                                                            Array.Clear(ara, 0, ara.Length);
                                                            break;
                                                    }
                                                    if (num == '<')
                                                        break;
                                                }
                                                break;
                                        }
                                        if (num == '<')
                                            break;
                                    }
                                    break;
                            }
                            if (num == '<') {
                                break;
                                    }
                        }
                        break;

                }
                if (num == '<')
                {
                    break;
                }
            }
            
    }
    }
}
