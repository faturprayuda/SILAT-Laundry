using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginform
{
    class Layanan
    {
        private string Id_layanan;
        private string Nama_layanan;

        public Layanan() { }
        public Layanan(string _id_layanan, string _nama_layanan)
        {
            this.id_layanan = _id_layanan;
            this.nama_layanan = _nama_layanan;
        }

        public string id_layanan { get => Id_layanan; set => Id_layanan = value; }
        public string nama_layanan { get => Nama_layanan; set => Nama_layanan = value; }
    }
}
