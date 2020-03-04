using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace InterviewCodeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeSamples.Replace();
            CodeSamples.ReferenceEqual();
            CodeSamples.BoxUnbox();
            CodeSamples.NullRefCheck();
            CodeSamples.Enumer();
        }
    }
    public class CodeSamples
    {
        public static void Replace()
        {
            Console.WriteLine("Replace");

            string s1 = "This_is_Test_Example_1";
            string s2 = "This_is_Test_Example_2";
            string s3 = s1;

            s1.Replace('_', '.');
            Console.WriteLine(s1 == s3);
            s3 = s2.Replace('_', '.');
            Console.WriteLine(s3 == s2);

            Console.WriteLine("\r\n");
        }

        public static void ReferenceEqual()
        {
            Console.WriteLine("ReferenceEqual");

            String s1 = "string s1";
            String s2 = "string s2";
            string s3 = "string s1";

            bool r1 = s1 == s2;
            bool r2 = object.ReferenceEquals(s1, s2);
            bool r3 = object.ReferenceEquals(s1, s3);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);

            Console.WriteLine("\r\n");

        }

        public static void BoxUnbox()
        {
            Console.WriteLine("BoxUnbox");

            int x = 444;
            object o = x;

            x = 555;
            Console.WriteLine(x);

            x = (int)o;
            Console.WriteLine(x);

            Console.WriteLine("\r\n");

        }

        class A
        {
            public bool BoolField = false;
        }

        public static void NullRefCheck()
        {
            A a = new A { BoolField = true };
            Console.WriteLine("{0}", a?.BoolField == true);
            a = null;
            Console.WriteLine("{0}", a?.BoolField == false);
        }


        public class Employee
        {
            public virtual int GetSalary()
            {
                return 2;
            }
        }
        public class Manager : Employee
        {
            public override int GetSalary()
            {
                return 5;
            }
        }
        public static void ManagersEmployee()
        {
            //Manager myManager = new Employee();
            //Console.Write(myManager.GetSalary());

            Employee myEmployee = new Manager();
            Console.Write(myEmployee.GetSalary());
        }

        public class UnitTest2
        {
            private bool lockObject = true;
            private int value = 1;

            public void Test2()
            {
                var thread = new Thread(Do);
                var thread2 = new Thread(Do);

                thread.Start();
                thread2.Start();
            }

            private void Do()
            {
                //lock (lockObject)
                //{
                //    Console.WriteLine(this.value);
                //    Thread.Sleep(100);
                //    this.value++;
                //}
            }
        }


        public abstract class Shape
        {
            public Shape()
            {
                Draw();
            }

            public abstract void Draw();
        }

        public class Point
        {

        }

        public class Circle : Shape
        {
            private List<Point> points;

            public Circle()
            {
                points = new List<Point>();
            }

            public override void Draw()
            {
                foreach (var point in points)
                {

                }
            }
        }

        public static void Enumer()
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("Enumer");

            List<Action> actions = new List<Action>();

            foreach (var i in Enumerable.Range(0, 2))
            {
                actions.Add(() => Console.WriteLine(i));
            }

            for (int i = 0; i < 2; i++)
            {
                actions.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
