using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        [Required(ErrorMessage = "Id Kendaraan tidak boleh kosong")]
        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "NO Polisi tidak boleh kosong")]
        [MinLength(3, ErrorMessage = "No Polisi minimal 3 angka")]
        [MaxLength(8, ErrorMessage = "No Polisi maksimal 8 angka")]
        public string NoPolisi { get; set; }
        [Required(ErrorMessage = "No STNK tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "ID Jenis Kendaraan tidak boleh kosong")]
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public virtual JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
