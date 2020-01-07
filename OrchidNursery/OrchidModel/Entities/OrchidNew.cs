    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrchidModel.Entities
{
    public class OrchidNew
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orchidID { get; set; }
        [Required]
        [MaxLength (100, ErrorMessage ="Orchid name cannot be more than 100 characters.")]
        public string orchidName { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public int price { get; set; }
        public int quanity { get; set; }
        public DateTime manuDate { get; set; }
        public DateTime expTime { get; set; }
    }
}
