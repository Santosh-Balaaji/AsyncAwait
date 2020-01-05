using System;
using System.Threading.Tasks;

namespace AsyncAwait
{

    public class AsyncAwait
    {
        public static async Task Method1()
        {
            await Task.Run(()=> {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1");

                }
            });
        }

        public static async  void Method2()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 2");
                }
            });
            
        }

        public static async void Method3()
        {
            await Task.Run(()=> {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 3");
                }
            });
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            AsyncAwait.Method2();
            AsyncAwait.Method1();
            AsyncAwait.Method3();
            //Console.WriteLine("Hello World!");
        }
    }
}
