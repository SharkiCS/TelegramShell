namespace TelegramShell
{
    public interface ICommand
    {
        string IsMatch();
        string Execute();
    }
}