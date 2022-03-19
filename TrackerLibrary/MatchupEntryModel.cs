using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {

        /// <summary>
        /// Represent one team in the matchup 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent the score for this particular team
        /// </summary>

        public double Score  { get; set; }

        /// <summary>
        /// Represent the matchup that 
        /// this came from as the winner.
        /// </summary>

       public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>


        public MatchupEntryModel(double initialScore)
        {
            Console.WriteLine();

        }
}
}
