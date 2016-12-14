using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Future_Game
{
    /// <summary>
    /// traveler hover action choices
    /// </summary>
    public enum HoverAction
    {
        None, 
        Hover,
        Speed,
        Cruise
      
    }

    /// <summary>
    /// possible hover results
    /// </summary>
    public enum HoverResult
    {
        None,
        TravelerHovers,
        TravelerSpeeds,
        TravelerCrashes,
        TravelerLands,
        TravelerCruises
        
    }
}
