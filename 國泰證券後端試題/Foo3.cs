using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;

namespace 國泰證券後端試題
{
    internal class Foo3
    {
        //private ImmutableList<string> list2 = ImmutableList<string>.Empty;
        private static List<string> list1 = new List<string>();
        object locker = new object();

        /// <summary>
        /// 新增成員值
        /// </summary>
        /// <param name="s"></param>
        public void Add(string s)
        {
            // Interlocked.Exchange 可以保證這個操作的原子性
            //Interlocked.Exchange(ref list2, list2.Add(s));

            lock (locker) 
            {
                list1.Add(s);
            }

        }

        /// <summary>
        /// 顯示成員值
        /// </summary>
        public void Show()
        {
            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }

        /*原本題目的範例*/
        /*
        private static List<string> list1;

        /// <summary>
        /// 建構子
        /// </summary>
        public Foo3() 
        { 
            list1 = new List<string>();
        }

        /// <summary>
        /// 新增成員值
        /// </summary>
        /// <param name="s"></param>
        public void Add(string s)
        {
            list1.Add(s);
        }

        /// <summary>
        /// 顯示成員值
        /// </summary>
        public void Show()
        {
            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }
        */
    }
}
