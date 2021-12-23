using System;
using System.Diagnostics;

namespace ConsoleApp7._3
{
    struct Worker
    {
        public string surnamename;
        public string dateofbirth;
        public int position;
        public int salary;
        public int education;
        int Displayinfo;
    }
        
    }

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите самого младшего сотрудника");
            Worker[] workers = new Worker[2];
        const string v = "Шачнев";
        workers[0].surnamename = "Шачнев";
            workers[0].dateofbirth = 1990;
        workers[0].position = "офисный работник";
            workers[1].surnamename = "Петухов";
            workers[1].dateofbirth = 1980;
            workers[1].position = "Директор";
            foreach (Worker worker in workers)
            {
                worker.DisplayInfo();
            }
            Worker Шачнев = new Worker("Шачнев", 1990);
            Шачнев.surnamename = "Шачнев";
                Шачнев.dateofbirth = 1990;
            int d = Шачнев.dateofbirth;
            Шачнев.DisplayInfo();
            Console.ReadKey();    
            {

                    {

                    }
                }
            }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
internal class Worker
{
    public Worker(string v1, int v2)
    {
    }

    public string surnamename { get; internal set; }
    public int dateofbirth { get; internal set; }
    public string position { get; internal set; }

    internal void DisplayInfo()
    {
        throw new NotImplementedException();
    }
}