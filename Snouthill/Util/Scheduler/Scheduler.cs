using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snouthill.Util.Scheduler
{
    class Slot
    {

    }

    class ScheduledTask
    {
        public ScheduledTask(Scheduler scheduler, Action action, double deadline)
        {

        }
    }

    class Scheduler
    {
        private Slot[] _wheel;

        private int _state;
        private readonly int STATE_RUNNING = 0;
        private readonly int STATE_SHUTDOWN = 1;

        private readonly ManualResetEvent _workerInitialized;
        private readonly Thread _worker;

        private long ElapsedTicks => DateTime.UtcNow.Ticks / 10000 - _startTicks;
        private long _startTicks = 0;

        private readonly ConcurrentQueue<ScheduledTask> _tasks;

        public Scheduler(TimeSpan tickDuration, int numTicks = 4096)
        {
            _state = STATE_RUNNING;

            _wheel = new Slot[numTicks];

            _workerInitialized = new ManualResetEvent(false);
            _worker = new Thread(Run);
            _worker.Start();

            _tasks = new ConcurrentQueue<ScheduledTask>();
        }
  
        public ScheduledTask RunAfter(TimeSpan span, Action action)
        {
            var deadline = ElapsedTicks + span.TotalMilliseconds;

            while (!_workerInitialized.WaitOne(100));

            var task = new ScheduledTask(this, action, deadline);
            _tasks.Enqueue(task);
            return task;
        }

        public void Stop()
        {
            if (Interlocked.CompareExchange(ref _state, STATE_SHUTDOWN, STATE_RUNNING) == STATE_RUNNING)
            {
                while (_worker.IsAlive)
                {
                    _worker.Join(1000);
                }
            }

        }

        private void Run()
        {
            _startTicks = ElapsedTicks;
            _workerInitialized.Set();

            do
            {

            }
            while (_state == STATE_RUNNING);
        }
    }
}
