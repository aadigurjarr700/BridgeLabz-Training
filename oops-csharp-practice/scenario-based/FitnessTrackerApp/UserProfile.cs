using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class UserProfile
    {
        private string userName;

        public UserProfile(string name)
        {
            userName = name;
        }

        public void PerformWorkout(Workout workout)
        {
            workout.TrackWorkout();

            Console.WriteLine("User: " + userName);
            Console.WriteLine("Duration: " + workout.DurationMinutes + " minutes");
            Console.WriteLine("Calories Burned: " + workout.CalculateCalories());
        }
    }
}
