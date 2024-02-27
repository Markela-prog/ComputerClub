using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClubTemplate
{
    internal class Computer
    {
        private Client _client;
        private int _minutesRemaining;
        public bool IsTaken
        {
            get { return _minutesRemaining > 0; }
        }

        public int PricePerMinute { get; private set; }

        public Computer(int pricePerMinute)
        {

            PricePerMinute = pricePerMinute;
        }

        public void BecomeTaken(Client client)
        {
            _client = client;
            _minutesRemaining = _client.DesiredMinutes;
        }

        public void BecomeEmpty()
        {
            _client = null;

        }

        public void SpendOneMinute()
        {
            _minutesRemaining--;
        }

        public void ShowState()
        {
            if (IsTaken)
                Console.WriteLine($"Computer is occupied by another client, minutes remaining: {_minutesRemaining}");
            else
                Console.WriteLine($"Computer is free, price per minute: {PricePerMinute}");
        }
    }
}
