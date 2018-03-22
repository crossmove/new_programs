using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class AysncAndAwaitExample
{
    public static void Method()
    {
        Call();
        Console.WriteLine("Main Thread one");
        Thread.Sleep(500);
        Console.WriteLine("Main Thread two");
        Console.ReadLine();
    }

    private static async void Call()   //if you use await inside method then in method we should use await always
    {
        Console.WriteLine("async method called");
        await Task.Run(new Action(PrintNumbersMethod)); //this blocks the next statement execution until this completes

        Console.WriteLine("Finished"); //this method executes after the previous statement executes completedly
    }

    private static void PrintNumbersMethod()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(200);
        }
    }
}