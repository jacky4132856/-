using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 國泰證券後端試題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //國泰證券題目二
            //以下程式顯示的 true / false 結果為何？ 
            object a = 2, b = 2;

            Console.WriteLine("國泰證券題目二");
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            //國泰證券題目三
            string example = "Hello, world!";
            char? firstChar = example.GetFirstChar();
            Console.WriteLine("國泰證券題目三");
            Console.WriteLine(firstChar); //輸出

            example = "";
            Console.WriteLine(example.GetFirstChar()); //輸出

            //國泰證券題目四
            StringBuilder str = new StringBuilder();
            for (var i = 0; i < 5000000; i++)
            {
                str.Append(i.ToString());
            }
            Console.WriteLine("國泰證券題目四 (這題會跑很久先不印)");
            //Console.WriteLine(str.ToString());

            //國泰證券題目六
            Foo_1 foo = new Foo_1();
            Console.WriteLine("國泰證券題目六");
            Console.WriteLine(foo["A"]); //輸出


            //國泰證券題目九
            var list = new List<Foo> {
            new Foo("A", new[] { 0, 1, 2 }),
            new Foo("B", new[] { 3, 4, 5 }),
            };

            //輸出
            Console.WriteLine("國泰證券題目九");
            Console.WriteLine(string.Join(",", list.SelectMany(O => O.Scores).ToArray()));


            //國泰證券題目十
            Foo3 _Foo3 = new Foo3();

            int numberOfThreads = 10;

            Task[] tasks = new Task[numberOfThreads];
            
            for (int i = 0; i < numberOfThreads; i++)
            {
                int taskId = i;
                tasks[i] = Task.Run(() => _Foo3.Add($"上宏測試 {taskId}"));
            }

            //等候所有提供的 Task 物件完成執行
            //Task.WaitAny(tasks);
            Task.WaitAll(tasks);
            //Task.Delay(1000);

            //輸出
            Console.WriteLine("國泰證券題目十");
            _Foo3.Show();

        }
    }
}
