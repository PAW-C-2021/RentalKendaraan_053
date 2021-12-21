using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        [Required(ErrorMessage = "ID Pengambilan tidak boleh kosong")]
        public int IdPengambilan { get; set; }
        [Required(ErrorMessage = "Tanggal Pengambilan tidak boleh kosong")]
        public DateTime? TglPengambilan { get; set; }
        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }
        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? Denda { get; set; }

        public virtual KondisiKendaraan IdKondisiNavigation { get; set; }
        public virtual Peminjaman Peminjaman { get; set; }
    }
}
 