using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuEn_Dictionary
{
    public class Record
    {
        [Key]
        public string Rus { get; set; }
        public string Eng { get; set; }
        public string Transcription { get; set; }
        public string Description { get; set; }
    }
}
