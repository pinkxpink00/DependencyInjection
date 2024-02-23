class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger(new SimpleLogService());
        logger.Log("Hello METANIT.COM");

        logger = new Logger(new GreenLogService());
        logger.Log("Hello METANIT.COM");
    }
}
//ILOG Interface about abstract
interface ILogService
{
    void Message(string message);
}

//SimpleMessageOnConsole
class SimpleLogService : ILogService
{
    public void Message(string message)
    {
        Console.WriteLine(message);
    }
}
//LogService Which Text Message on Green Color
class GreenLogService : ILogService
{
    public void Message(string message)
    {
        var defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(message);
        Console.ForegroundColor = defaultColor;
    }
}
class Logger
{
    ILogService logService;
    public Logger(ILogService logService)
    {
        this.logService = logService;
    }

    public void Log(string message)
    {
        logService.Message($"{DateTime.Now}-----{message}");
    }
}