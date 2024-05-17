namespace Command.Example01
{
    public class Waiter
    {
        public void TakeCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
