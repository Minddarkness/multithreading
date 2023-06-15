namespace HW_15;

public class ThreadOutput
{
    private int _threadID = 0;
    private List<Thread> _threads = new List<Thread>();
    
    public void WriteInThread(string text, int delay)
    {
        ThreadStart task = new ThreadStart(() => WriteWithDelay(text, delay));
        Thread thread = new Thread(task);
        thread.Name = "Thread " + _threadID++;
        _threads.Add(thread);
        Console.WriteLine("thread started");
        thread.Start();
    }

    private void WriteWithDelay(string text, int delay)
    {
        var currentThreadName = Thread.CurrentThread.Name;

        while (true)
        {
            Thread.Sleep(delay);
            Console.WriteLine($"thread name: {currentThreadName} text: {text}");
        }
    }
}