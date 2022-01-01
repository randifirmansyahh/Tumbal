using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Models
{
    public class Biodata
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telepon { get; set; }
        public List<string> Hp { get; set; }
        public string File { get; set; }
    }
}