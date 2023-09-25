﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupModelEntryModel> Entries { get; set; } = new List<MatchupEntryMode>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }

}

