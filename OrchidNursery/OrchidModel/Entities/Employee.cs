using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrchidModel.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmplyID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserAddress { get; set; }

        [Required]
        [MaxLength(25)]
        public int UserNIC { get; set; }

        [Required]
        [MaxLength(25)]
        public int UserTeleNo { get; set; }

        [Required]
        [MaxLength(25)]
        public string UserPass { get; set; }
    }
}
