namespace Command.Example02
{
    public class RemoteControl
    {
        public void TakeCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
