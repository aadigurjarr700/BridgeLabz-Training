using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class StrengthWorkout : Workout
    {
        public override void TrackWorkout()
        {
            Console.WriteLine("Strength workout selected.");
        }

        public override int CalculateCalories()
        {
            return durationMinutes * 5; // calories per minute
        }
    }
}
