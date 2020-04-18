using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._13
{
    class CongNhan: Person, IComparable<CongNhan>
    {
        String _TenCongTy;

        String _NgayLamViec;

        Double _HeSoLuong;

        public string TenCongTy { get => _TenCongTy; set => _TenCongTy = value; }

        public string NgayLamViec { get => _NgayLamViec; set => _NgayLamViec = value; }

        public double HeSoLuong { get => _HeSoLuong; set => _HeSoLuong = value; }

        public CongNhan(string hoTen, string gioiTinh,  int namSinh, string diaChi ,string tenCongTy, string ngayLamViec, double heSoLuong)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.NamSinh = namSinh;
            this.TenCongTy = tenCongTy;
            this.NgayLamViec = ngayLamViec;
            this.HeSoLuong = heSoLuong;
        }

        public CongNhan()
        {

        }

        public override string ToString()
        {

            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", this.HoTen, this.GioiTinh, this.DiaChi, this.NamSinh, this.TenCongTy, this.NgayLamViec, this.HeSoLuong);
        }
         public int CompareTo(CongNhan congNhan)
        {
            return this.HeSoLuong.CompareTo(congNhan.HeSoLuong);
        }

       






        }
}
