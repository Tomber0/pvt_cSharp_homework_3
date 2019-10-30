using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_cSharp_homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 строки:
            string exaampleString1 = "Эта строка содержит пробелы и спец символы!"
                ;
            //1 поиск подстроки в строке
            if (exaampleString1.IndexOf("Эта") >= 0) {
                exaampleString1 = exaampleString1.Remove(exaampleString1.IndexOf("Эта"), "Эта".Length);

            }
            string mess = "аыывсывфыв";
            Console.Out.WriteLine(exaampleString1);
            // демнострация работы: стека очереди строки 
            Queue<string> exampleQueue = new Queue<string>();
            
            Stack<string> exampleStack = new Stack<string>();

            exampleStack.Push(exaampleString1);
            exampleStack.Push(mess);
            exampleStack.Push(mess);
            exampleStack.Push(mess);
            exampleStack.Push(exaampleString1);
            string exampleString4 = "Эта строка из стека, которая"+exampleStack.Pop();
            Console.Out.WriteLine(exampleString4);
            exampleQueue.Enqueue(exaampleString1);
            exampleQueue.Enqueue("Только не эта");
            string exampleString2 = exampleQueue.Dequeue();
            string exampleString3 = exampleQueue.Dequeue();
            exampleString3+=exampleString2;
            Console.Out.WriteLine(exampleString3);

        }
    }
}

/*
 
     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvt_lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] array = new int[6][];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //
            //        array[i] = new int[10] ;
            //
            //    }
            //}

            // int[] testArray = new int[5];
            // for (int i = 0; i < testArray.Length; i++)
            // {
            //     testArray[i] = Convert.ToInt32(Console.In.ReadLine());
            //
            // }
            //
            // for (int i = 0; i < testArray.Length - 1; i++)
            // {
            //     int minEl = i;
            //     for (int j = i+1; j < testArray.Length; j++)
            //     {
            //         if (testArray[j] < testArray[minEl])
            //         {
            //             minEl = j;
            //         }
            //     }
            //     int temp = testArray[minEl];
            //     testArray[minEl] = testArray[i];
            //     testArray[i] = temp; 
            //
            // }
            //
            //  int sumOfArray = 0;
            //  foreach (int arrayElement in testArray)
            //  {
            //     Console.Out.WriteLine(" {0}", arrayElement);
            // }

            //полндром


            //string str = "полоп";
            //bool polindrome = true;
            //for (int i = 0, j = str.Length-1; i < str.Length / 2; i++,j--) {
            //    if (str[i] == str[j]) { 
            //    
            //    }
            //    else
            //    {
            //        Console.Out.WriteLine("Строка не полиндром!");
            //        polindrome = false;
            //        break;
            //    }
            //
            //
            //}
            //if (polindrome)
            //                Console.Out.WriteLine("строка {0}, является полиндромом", str);
            //

            //string str = "Hello, World!";
            //string word = "Hello";
            //if (str.IndexOf(word) >= -1)
            //{
            //    Console.Out.WriteLine("Строка {0} присутствует", word);
            //
            //}
            //
            //else
            //{
            //    Console.Out.WriteLine("Строка {0} не присутствует!", word);
            //}
            // string[] words = str.Split(' ',',','!','.');
            //Console.Out.WriteLine("sum = {0}", words);
            // Console.Out.WriteLine("sum = {0}", sumOfArray);
            // Array.Sort(testArray);

            //List<int> list = new List<int>();
            //list.Add(12);
            //
            //list.Add(13);
            //list.Add(1);
            //
            //list.Remove(12);
            //list.RemoveAt(1);
            //Console.Out.WriteLine(list);
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(13);
            //Console.Out.WriteLine(q.Dequeue());
            //
            //Console.Out.WriteLine(q.Dequeue());




            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(11);
            s.Push(1111);

            Console.Out.WriteLine(s.Pop());

            //Queue последний зашел - последний вышел
            //stack - первый зашел - первый вышел
        }
    }
}
//д\з: 
/*
    1)строки 
    2)  списки очереди стек (продемонстрировать)
    3)
    4)
     
     
     */
