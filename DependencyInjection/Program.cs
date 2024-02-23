class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger();
        logger.Log("Hello");
    }
}

class SimpleLogService
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}

class Logger
{
    SimpleLogService simpleLogService = new SimpleLogService();
    public void Log(string message) => simpleLogService.Write($"{DateTime.Now}-{message}");
}