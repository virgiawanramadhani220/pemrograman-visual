using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Repositories;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Controllers
{
    public class InformasiController
    {
        public void Tambah(Informasi info) => InformasiRepository.Insert(info);
        public void Ubah(Informasi info) => InformasiRepository.Update(info);
        public void Hapus(string nama) => InformasiRepository.Delete(nama);
        public DataTable AmbilSemua() => InformasiRepository.GetAll();
        public DataTable Cari(string keyword) => InformasiRepository.SearchByName(keyword);
    }
}
