using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._13
{
    class Person
    {
        String _HoTen;

        String _GioiTinh;

        int _NamSinh;

        String _DiaChi;

        public string HoTen { get => _HoTen; set => _HoTen = value; }

        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }

        public int NamSinh { get => _NamSinh; set => _NamSinh = value; }

        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }

        public Person( string hoTen, string gioiTinh, int namSinh, string diaChi)
        {
           
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
            this.DiaChi = diaChi;
        }

        public Person()
        {

        }

       
    }
}
