using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class CardioWorkout : Workout
    {
        public override void TrackWorkout()
        {
            Console.WriteLine("Cardio workout selected.");
        }

        public override int CalculateCalories()
        {
            return durationMinutes * 8; // calories per minute
        }
    }
}
