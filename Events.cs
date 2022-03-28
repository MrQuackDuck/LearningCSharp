using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Events
    {
        public void Start()
        {
            Clock myClock = new Clock();
            myClock.AddingTime += Log;
            myClock.AddedTime += Log;
            myClock.TakingTime += Log;
            myClock.TakedTime += Log;

            // Demonstrating anonymous method
            myClock.ShowingTime += delegate (object sender, ClockEventArgs args)
            {
                Console.WriteLine(args.Message);
            };

            myClock.ShowTime();
            myClock.AddTime(100000000);     
            myClock.ShowTime();
        }

        static void Log(object sender, ClockEventArgs args)
        {
            Console.WriteLine(args.Message);
        }
    }

    class Clock
    {
        DateTime Time = DateTime.Now;

        public event EventHandler<ClockEventArgs> AddingTime;
        public event EventHandler<ClockEventArgs> AddedTime;

        public event EventHandler<ClockEventArgs> TakingTime;
        public event EventHandler<ClockEventArgs> TakedTime;

        public event EventHandler<ClockEventArgs> ShowingTime;

        public void AddTime(int seconds)
        {
            // ?. - check on null operator
            AddingTime?.Invoke(this, new ClockEventArgs($"Adding {seconds} seconds", seconds));
            Time = Time.Add(new TimeSpan(0, 0, seconds));
            AddedTime?.Invoke(this, new ClockEventArgs($"{seconds} added", seconds));
        }

        public void TakeTime(int seconds)
        {
            TakingTime?.Invoke(this, new ClockEventArgs($"Taking {seconds} seconds", seconds));
            Time = Time.Add(new TimeSpan(0, 0, seconds));
            TakedTime?.Invoke(this, new ClockEventArgs($"{seconds} seconds taked", seconds));
        }

        public void ShowTime()
        {
            ShowingTime?.Invoke(this, new ClockEventArgs($"Current Time: {Time}", 0));
        }
    }

    class ClockEventArgs : EventArgs
    {
        public string Message { get; }
        public int Seconds { get; }

        public ClockEventArgs(string msg, int secs)
        {
            Message = msg;
            Seconds = secs;
        }
    }
}
