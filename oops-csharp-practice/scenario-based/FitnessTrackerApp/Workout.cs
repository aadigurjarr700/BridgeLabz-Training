using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public abstract class Workout : ITrackable
    {
        protected int durationMinutes;

        public int DurationMinutes
        {
            get { return durationMinutes; }
            set { durationMinutes = value; }
        }

        public abstract void TrackWorkout();
        public abstract int CalculateCalories();
    }
}
