using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        [Required(ErrorMessage = "IdGender tidak boleh kosong")]
        public int IdGender { get; set; }
        [Required(ErrorMessage = "Nama Gender tidak boleh kosong")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
