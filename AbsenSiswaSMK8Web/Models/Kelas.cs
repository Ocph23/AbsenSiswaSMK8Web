using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenSiswaSMK8Web.Models
{
   public class Kelas
    {

        public int Id { get; set; }
        public string Nama { get; set; } /// X 

        public Jurusan Jurusan { get; set; }

        public Siswa KetuaKelas { get; set; }
    }
}
