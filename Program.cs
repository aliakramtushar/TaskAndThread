using System.Threading;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var t1 = Task.Run(() => TimeCount());
        TimeCount1();

        Console.WriteLine("Done");

        //Task.WhenAll(t1);
        Console.ReadKey();
        //await Task.Run(() => Console.WriteLine("Done"));

        //return Task.FromResult(temp);

    }
    public static async Task TimeCount()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine(i + " Method1");
            }
        });
    }
    public static void TimeCount1()
    {
        for (int i = 0; i < 3; i++)
        {
            Task.Delay(1000).Wait();
            Console.WriteLine(i + " Method2");

        }
    }

    //static void Main(string[] args)
    //{
    //    Method1();
    //    Method2();
    //    //Console.ReadKey();
    //}

    //public static async Task Method1()
    //{
    //    await Task.Run(() =>
    //    {
    //        for (int i = 0; i < 50; i++)
    //        {
    //            Console.WriteLine(" Method 100");
    //            // Do something
    //            Task.Delay(1000).Wait();
    //        }
    //    });
    //}


    //public static void Method2()
    //{
    //    for (int i = 0; i < 2; i++)
    //    {
    //        Console.WriteLine(" Method 2");
    //        // Do something
    //        Task.Delay(500).Wait();
    //    }
    //}

}