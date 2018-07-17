using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SacProgram
    {
        public SacProgram()
        {
            Speaker = new HashSet<Speaker>();
        }

        public int ID { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Conduncting")]
        public string Conducting { get; set; }
        [Required]
        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }
        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }
        [Required]
        [Display(Name = "Sacrament Song")]
        public string SacramentSong { get; set; }

        public string FirstSpeaker { get; set; }
        public string SecondSpeaker { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public string IntermediateSong { get; set; }
        public string ThirdSpeaker { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }
        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
        public ICollection<Speaker> Speaker { get; set; }

    }
}
