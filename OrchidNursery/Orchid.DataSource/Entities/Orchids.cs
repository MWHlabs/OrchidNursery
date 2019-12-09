using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orchid.DataSource.Entities
{
    public class Orchids
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orchidID { get; set; }

        public string orchidName { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public int price { get; set; }
        public int quanity { get; set; }
        public DateTime manuDate { get; set; }
        public DateTime expTime { get; set; }
    }
}
