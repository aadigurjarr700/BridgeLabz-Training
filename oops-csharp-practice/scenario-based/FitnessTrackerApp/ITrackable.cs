using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    
    public interface ITrackable
    {
        void TrackWorkout();
        int CalculateCalories();
    }
}
