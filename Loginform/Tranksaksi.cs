using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginform
{
    class Tranksaksi
    {
        private string Id_tranksaksi;
        private string Tgl_masuk;
        private string Tgl_keluar;
        private string Nama_layanan;
        private string Nama_barang;
        private string Banyak_barang;
        private string Harga;
        private string Total_harga;
        private string Id_user;

        public Tranksaksi() { }
        public Tranksaksi(string _id_tranksaksi, string _tgl_masuk, string _tgl_keluar, string _nama_layanan,
            string _nama_barang, string _banyak_barang, string _harga, string _total_harga, string _id_user)
        {
            this.Id_tranksaksi = _id_tranksaksi;
            this.Tgl_masuk = _tgl_masuk;
            this.Tgl_keluar = _tgl_keluar;
            this.Nama_layanan = _nama_layanan;
            this.Nama_barang = _nama_barang;
            this.Banyak_barang = _banyak_barang;
            this.Harga = _harga;
            this.Total_harga = _total_harga;
            this.Id_user = _id_user;
        }

        public string id_tranksaksi { get => Id_tranksaksi; set => Id_tranksaksi = value; }
        public string tgl_masuk { get => Tgl_masuk; set => Tgl_masuk = value; }
        public string tgl_keluar { get => Tgl_keluar; set => Tgl_keluar = value; }
        public string nama_layanan { get => Nama_layanan; set => Nama_layanan = value; }
        public string nama_barang { get => Nama_barang; set => Nama_barang = value; }
        public string banyak_barang { get => Banyak_barang; set => Banyak_barang = value; }
        public string harga { get => Harga; set => Harga = value; }
        public string total_harga { get => Total_harga; set => Total_harga = value; }
        public string id_user { get => Id_user; set => Id_user = value; }
    }
}
