using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginform
{
    class User
    {
        private string Id_user;
        private string Nama_user;
        private string Alamat_user;
        private string No_user;

        public User() { }
        public User(string _id_user, string _nama, string _alamat, string _no)
        {
            this.Id_user = _id_user;
            this.Nama_user = _nama;
            this.Alamat_user = _alamat;
            this.No_user = _no;
        }

        public string nama_user { get => Nama_user; set => Nama_user = value; }
        public string alamat_user { get => Alamat_user; set => Alamat_user = value; }
        public string no_user { get => No_user; set => No_user = value; }
        public string id_user { get => Id_user; set => Id_user = value; }
    }
}
