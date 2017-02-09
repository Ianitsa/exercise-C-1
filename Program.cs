using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Да се напише метод кото приема масив и връща най-големия елемент.
            int[] arr = { 22, 35, 94, 73, 15, 17, 63, 45, 79, 164, 267, 21, 36, 47, 35 };
            int[] arr1 = { 48, 45, 84, 93, 46, 82, 124, 36, 18, 38, 18, 13, 8, 9, 2, 95 };
            Console.WriteLine(MaxElement(arr));
            Console.WriteLine(MaxElement(arr1));

            //2.	Метод който приема число и връща число чиито цифри са в обратен ред
            string num = "5138";
            Console.WriteLine(ReverseElement(num));
            //       string str = " text to me"; //output: em ot txet

            //3.	Метод който въща колко пъти се среща дадена цифра в масив

            int[] array = { 12, 48, 39, 4, 57, 39, 1, 6, 48, 4, 3, 9, 1, 3, 4, 874, 3, 91, 4, 6, 2, 4, 7, 5 };
            Console.WriteLine("Please, choose num of 12, 48, 39, 4, 57, 39, 1, 6, 48, 4, 3, 9, 1, 3, 4, 874, 3, 91, 4, 6, 2, 4, 7, 5 ");
            int info = int.Parse(Console.ReadLine());

            Console.WriteLine(CountDoblicateNum(info, array));

            //4.	Метод който сортира Array от string базиран на броя символи във всеки от тях.
            //input:  those substrings as elements of an array
            //input: for each element, or if                you are doing

            string input = Console.ReadLine();
            SortString(input);

            //5.	Метод който извлича изречения които съдържат определена дума.
            // input: On Windows 7. And earlier versions of Windows. The Start menu contained a “Startup” folder to make this easy. On these versions of Windows. You can simply open your Start menu. Locate a shortcut to an application. You want to start automatically. Right-click it, and select Copy. Next, locate the Startup folder under All Apps in the Start menu, right-click it, and select Paste to paste a copy of that shortcut.
            // On
            string text = Console.ReadLine();
            string word = Console.ReadLine();
            wordInTheText(text, word);

            //6.	Метод който обръща изречение:
            // Пример:„C# is not C++, not PHP and not Delphi“ -> „Delphi not and PHP, not C++ not is C#!“
            string inputText = Console.ReadLine();
            ReverceOrderInSecuence(inputText);


        }

        private static void ReverceOrderInSecuence(string inputText)
        {

        }
        private static void wordInTheText(string text,string str)
        {
            string word=str.ToLower();
            string[] sequence = text.Split(new[] { '?', '.','!'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var seq in sequence)
            {
                string[] wordText=seq.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in wordText)
                {
                    
                    if (word.Equals(item.ToLower()))
                    {
                        Console.WriteLine(seq);
                    }
                }
            }
        }

        private static void SortString(string str)
        {
            string[] words = str.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> result = new Dictionary<string, int>();
            int count;

            foreach (var item in words)
            {
                count = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    count++;
                }
                result.Add(item, count);
            }

          var r=  result.OrderBy(c => c.Value)
                .Select(c => c.Key);

            foreach (var item in r )
            {
                Console.WriteLine(item);
            }

        }
        private static int CountDoblicateNum(int num, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==num)
                {
                    count++;
                }
            }
            return count;
        }


       private static string ReverseElement(string num)
        {
            //variant 1
            // string reverseValue = new string(num.Reverse().ToArray());

            //variant 2
            string reverseValue = new string(num.Select((c, index) => new { c, index })
                                        .OrderByDescending(x => x.index)
                                        .Select(x => x.c)
                                        .ToArray());

            return reverseValue;
        }
        private static int MaxElement(int[] arr)
        {
           int el= arr.Max();
            return el;
        }
    }
}
