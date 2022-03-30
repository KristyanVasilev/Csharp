using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return "Race cannot be completed because both racers are not available!";
            }

            if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }

            if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }

            var racerOneChanceOfWinnig = RacerOneChanceOfWinnig(racerOne);
            var racerTwoChanceOfWinnig = RacerTwoChanceOfWinnig(racerTwo);

            racerOne.Race();
            racerTwo.Race();

            IRacer winner;
            if (racerOneChanceOfWinnig > racerTwoChanceOfWinnig)
            {
                winner = racerOne;
            }
            else
            {
                winner = racerTwo;
            }

            return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";
        }

        private static double RacerTwoChanceOfWinnig(IRacer racerTwo)
        {
            if (racerTwo.RacingBehavior == "strict")
            {
                var racerTwoChanceOfWinnig = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.2;
            }
            else if (racerTwo.RacingBehavior == "aggressive")
            {
                var racerTwoChanceOfWinnig = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.1;
            }

            return 0;
        }

        private static double RacerOneChanceOfWinnig(IRacer racerOne)
        {
            if (racerOne.RacingBehavior == "strict")
            {
                return racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
            }
            else if (racerOne.RacingBehavior == "aggressive")
            {
                return racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
            }

            return 0;
        }
    }
}
