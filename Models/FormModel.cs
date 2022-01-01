using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Models
{
    public class FormModel
    {
        public FormModel()
        {
            biodata = new List<Biodata>();
            mobil = new Mobil();
        }

        public List<Biodata> biodata { get; set; }
        public Mobil mobil { get; set; }
    }
}