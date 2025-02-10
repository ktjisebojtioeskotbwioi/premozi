

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace premozi.Models
{
    [Table("Vetites")]
    public class VetitesModel
    {
        //primary key
        [MaxLength(11)]
        public int id { get; set; }
        //foreign key
        [MaxLength(11)]
        public Film Film { get; set; }
        public DateTime Idopont { get; set; }
        //foreign key
        [MaxLength(11)]
        public Terem Terem {  get; set; }
        
        public string Megjegyzes {  get; set; }
        
    }
}
