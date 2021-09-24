//using Example;
//using System;
//using System.Diagnostics;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////namespace DelegateDemo
////{
////    //Declaration
////    public delegate void AddDelegate(int a, int b);
////    public delegate string GreetingsDelegate(string name);
////    public class Program1
////    {
////        static void Main(string[] args)
////        {
////            var sw = new Stopwatch();
////            Program obj = new Program();
////            //Instantiation using 2 types
////            //1.calling non static method through object
////            AddDelegate ad = new AddDelegate(obj.Add);

////            //2.Calling static method with class name
////            GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);
////            //Invoking the delegates
////            sw.Start();
////            ad(50, 50);

////            string GreetingsMessage = gd("Nagendra Sai");
////            sw.Stop();
////            Console.WriteLine(GreetingsMessage);
////            Console.WriteLine(sw.Elapsed);
////            Console.ReadKey();
////        }
////    }
////}
////namespace Anonymousandlambda
////{

////    public delegate string GreetingsDelegate(string name);
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            var sw = new Stopwatch();
////            GreetingsDelegate gd =  delegate (string name)
////             {
////                 return @"Hello : " + name;
////             };
////            sw.Start();
////            string msg = gd.Invoke("Nagendra Sai");
////            sw.Stop();
////            Console.WriteLine(sw.Elapsed);
////            Console.WriteLine(msg);
////            Console.ReadKey();
////        }
////    }
////}
//namespace LambdaExpressionDemo
//{
//    public class LambdaExpression
//    {
//        public delegate string GreetingsDelegate(string name);

//        static void Main(string[] args)
//        {
//            GreetingsDelegate obj = (name) =>
//            {
//                return "Hello @" + name;
//            };

//            string GreetingsMessage = obj.Invoke("NagendraSai");
//            Console.WriteLine(GreetingsMessage);
//            Console.ReadKey();
//        }
//    }
//}
