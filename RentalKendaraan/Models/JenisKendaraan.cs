using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }
        [Required(ErrorMessage = "Id Jenis Kendaraan tidak boleh kosong")]
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "NamaJenisKendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
