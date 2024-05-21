namespace Mediator.Example02
{
    public abstract class Aircraft
    {
        protected IAirTrafficControl _tower;
        private string _name;
        protected Aircraft(IAirTrafficControl tower, string name)
        {
            _tower = tower;
            _name = name;

            if(_tower is Tower concreteTower)
            {
                concreteTower.RegisterAircraft(this);
            }
        }

        public void SendMessage(string message)
        {
            _tower.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}
