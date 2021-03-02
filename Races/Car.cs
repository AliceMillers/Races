using System;

namespace Races
{
    class Car
    {
        public string model;
        public int actionSpeed;
        public long secFromStart;

        public Car(string modelName)
        {
            model = modelName;
        }

        public void Go(int startSpeed)
        {
            if (actionSpeed > 0)
            {
                throw new InvalidOperationException("A car is already on move");
            }
            else
            {
                actionSpeed = startSpeed;
                secFromStart = DateTimeOffset.Now.ToUnixTimeSeconds();
            }
        }

        public long Distance()
        {
            long secNow = DateTimeOffset.Now.ToUnixTimeSeconds() - secFromStart;
            long distance = secNow * actionSpeed;
            return distance;
        }
    }
}
