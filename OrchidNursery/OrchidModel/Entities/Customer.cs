using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrchidModel.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegnoID { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmpName { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmpAddress { get; set; }

        [Required]
        [MaxLength(50)]
        public string  NIC { get; set; }

        [Required]
        [MaxLength(90)]
        public string TelephoneNo { get; set; }

        [Required]
        [MaxLength(80)]
        public string password { get; set; }
    }
}
