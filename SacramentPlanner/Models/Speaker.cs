﻿using System;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
            public int SpeakerID { get; set; }
            public int SacProgramID{get;set;}
            public String SpeakerName { get; set; }
            public String Topic { get; set; }
            public String SpeakerOrder { get; set; }


        public SacProgram SacProgram {get;set;}
    }
}
