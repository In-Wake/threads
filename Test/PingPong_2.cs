namespace Test
{
    public class RunPingPong
    {
        public void Run(int pingCount)
        {
            //lock(monitor) is simple
            //but auto reset event is more flexible
            var pingEvent = new AutoResetEvent(false);
            var pongEvent = new AutoResetEvent(true);
            var stopEvent = new AutoResetEvent(false);

            var pingThread = new Thread(() =>
             {
                 for (int i = 0; i < pingCount; i++)
                 {
                     pongEvent.WaitOne();
                     Console.WriteLine($"Ping n{i}");
                     pingEvent.Set();
                 }
             });

            var pongThread = new Thread(() =>
             {
                 for (var i = 0; i < pingCount; i++)
                 {
                     pingEvent.WaitOne();
                     Console.WriteLine($"Pong n{i}");
                     pongEvent.Set();
                 }
                 stopEvent.Set();

             });

            pingThread.Start();
            pongThread.Start();
            stopEvent.WaitOne();
        }
    }
}
