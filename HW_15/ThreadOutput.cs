namespace HW_15;

public class ThreadOutput
{
    public ThreadOutput()
    {
        
    }
    
    public void WriteInThread(string text, int delay)
    {
        ThreadStart task = new ThreadStart(() => WriteWithDelay(text, delay));
        Thread thread = new Thread(task);
        Console.WriteLine("thread started");
        thread.Start();
    }

    private void WriteWithDelay(string text, int delay)
    {
        var currentThread = Thread.CurrentThread;
        Thread.Sleep(delay);
        Console.WriteLine($"thread name: {currentThread.Name} text: {text}");
    }
}