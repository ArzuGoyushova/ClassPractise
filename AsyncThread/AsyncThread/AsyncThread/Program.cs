Loop1();
Loop2();

Thread thread1 = new Thread(Loop1);
Thread thread2 = new Thread(Loop2);

thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();//oz aralarinda paralel, ama ashagidakini bloklayir

Console.WriteLine("test"); //her hansi yerde chixa biler
Loop3(); //Loop3 test ishleyenden sonra ishleyir,qarisha biler threadlerle amma mutleq testden sonra chixir.


void Loop1()
{
    for(int i = 0; i < 100; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Loop1=>{i}");
    }
}
void Loop2()
{
    for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Loop2=>{i}");
    }
}
void Loop3()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Loop3=>{i}");
    }
}