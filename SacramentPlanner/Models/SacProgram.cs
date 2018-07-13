using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SacProgram
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Conducting { get; set; }
        public string OpeningSong { get; set; }
        public string OpeningPrayer { get; set; }
        public string SacramentSong { get; set; }
        public string FirstSpeaker { get; set; }
        public string SecondSpeaker { get; set; }
        public string IntermediateSong { get; set; }
        public string ThirdSpeaker { get; set; }
        public string ClosingSong { get; set; }
        public string ClosingPrayer { get; set; }

    }
}
