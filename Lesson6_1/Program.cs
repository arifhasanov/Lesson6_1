using System;
using System.Diagnostics;

namespace Lesson6_1
{
    class Program
    {
        static Process[] processes = Process.GetProcesses();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program will help you to kill a process");
            Console.WriteLine("Press ENTER to see the list of all processes...");
            Console.ReadLine();

            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"Id: {processes[i].Id}, Name: {processes[i].ProcessName}");
            }

            Console.WriteLine("Please enter name or ID of the process to kill it:");
            string inp = Console.ReadLine();
            int id;

            if (int.TryParse(inp, out id))
            {
                KillProcess(inp, 1);
            }
            else
            {
                KillProcess(inp, 2);
            }
        }

        static void KillProcess(string idName, int type)
        {
            for (int i = 0; i < processes.Length; i++)
            {
                if(type == 1)
                {
                    if(processes[i].Id.ToString() == idName)
                    {
                        Console.WriteLine($"Process {processes[i].ProcessName} was killed ==================");
                        processes[i].Kill();
                    }
                }
                else
                {
                    if (processes[i].ProcessName == idName)
                    {
                        Console.WriteLine($"Process {processes[i].ProcessName} was killed ==================");
                        processes[i].Kill();
                    }
                }
            }
        }
    }
}
