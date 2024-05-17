namespace Command.Example02
{
    public class NetflixCommand : ICommand
    {
        private SmartTV _smartTV;
        public NetflixCommand(SmartTV smartTV)
        {
            _smartTV = smartTV;
        }
        public void Execute()
        {
            _smartTV.OpenNetflix();
        }
    }
}
