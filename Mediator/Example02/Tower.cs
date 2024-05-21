namespace Mediator.Example02
{
    public class Tower : IAirTrafficControl
    {
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        public void RegisterAircraft(Aircraft aircraft)
        {
            if (!_aircrafts.Contains(aircraft))
            {
                _aircrafts.Add(aircraft);
            }
        }
        public void SendMessage(Aircraft sender, string message)
        {
            foreach(var aircraft in _aircrafts)
            {
                if(aircraft != sender)
                {
                    aircraft.ReceiveMessage(message);
                }
            }
        }
    }
}
