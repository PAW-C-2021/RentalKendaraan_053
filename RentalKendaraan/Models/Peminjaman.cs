using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        [Required(ErrorMessage = "ID Kendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "ID Customer tidak boleh kosong")]
        public int? IdCustomer { get; set; }
        [Required(ErrorMessage = "ID Jaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int? Biaya { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual Jaminan IdJaminanNavigation { get; set; }
        public virtual Kendaraan IdKendaraanNavigation { get; set; }
        public virtual Pengembalian IdPeminjamanNavigation { get; set; }
    }
}
