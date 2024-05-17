namespace Command.Example02
{
    public class AmazonCommand : ICommand
    {
        private SmartTV _smartTV;
        public AmazonCommand(SmartTV smartTV)
        {
            _smartTV = smartTV;
        }
        public void Execute()
        {
            _smartTV.OpenAmazon();
        }
    }
}
