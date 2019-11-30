using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginform
{
    class Barang
    {
        private string Id_barang;
        private string Nama_barang;

        public Barang() { }
        public Barang(string _id_barang, string _nama_barang)
        {
            this.Id_barang = _id_barang;
            this.Nama_barang = _nama_barang;
        }

        public string id_barang { get => Id_barang; set => Id_barang = value; }
        public string nama_barang { get => Nama_barang; set => Nama_barang = value; }
    }
}
