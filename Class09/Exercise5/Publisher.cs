using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Exercise5
{
    
    public static class Publisher
    {
        
        public static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ComposeMessage(string trainerName, string group, string message)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Trainer {trainerName} informs {group}");
            SendMessage(message);
        }
    }
}
