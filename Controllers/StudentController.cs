using Blogs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var data = new List<Biodata>();
            var dataMobil = new Mobil();
            var formModel = new FormModel();

            data.Add(
                new Biodata() {
                    Id = 1,
                    Foto = "image/foto_orang.jpg",
                    Nama = "Randi Firmansyah",
                    Alamat = "Bandung",
                    Telepon = "022-202-020"
                }
            );

            data.Add(
                new Biodata() {
                    Id = 2,
                    Foto = "image/foto_orang.jpg",
                    Nama = "Udin sedunia",
                    Alamat = "Jakarta",
                    Telepon = "022-202-020"
                }
            );

            data.Add(
                new Biodata()
                {
                    Id = 3,
                    Foto = "image/foto_orang.jpg",
                    Nama = "Udin sedunia",
                    Alamat = "Jakarta",
                    Telepon = "022-202-020"
                }
            );

            dataMobil.Nama = "kijang";
            dataMobil.Merk = "Toyota";

            formModel.biodata = data;
            formModel.mobil = dataMobil;

            string nama = "Online";

            ViewBag.nama = nama;

            return View(formModel);
        }

        [HttpPost]
        public object Create()
        {
            var item = Request.Form;
            var a = item["[]hp"].ToList();
            return FormCol(a);
        }

        private List<string> FormCol(List<string> data)
        {
            return data;
        }
    }
}
