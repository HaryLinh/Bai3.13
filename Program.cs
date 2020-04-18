using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._13
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<CongNhan> listCongNhan = new List<CongNhan>();
            Console.WriteLine("Hey, Muon gi? Nhap so nhan vien di bro:");
            int numCongNhan = int.Parse(Console.ReadLine());
            //nhap cong nhan
            Console.WriteLine("Nhap thong tin cong nhan:");
            for (int i = 0; i < numCongNhan; i++)
            {
                Console.Write("Nhap ten cong nhan:");
                string hoTen = Console.ReadLine();
                Console.WriteLine("\nNhap gioi tinh:");
                string gioiTinh = Console.ReadLine();
                Console.WriteLine("\nNhap nam sinh:");
                int namSinh = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNhap dia chi:");
                string diaChi = Console.ReadLine();
                Console.WriteLine("\nNhap ten cong ty:");
                string tenCty = Console.ReadLine();
                Console.WriteLine("\nNhap ngay lam viec:");
                string ngayLamViec = Console.ReadLine();
                Console.WriteLine("\nNhap he so luong:");
                double salary = double.Parse(Console.ReadLine());
                CongNhan congNhan = new CongNhan(hoTen, gioiTinh, namSinh, diaChi, tenCty, ngayLamViec, salary);
                listCongNhan.Add(congNhan);

            }
            // in danh sach cong nhan
            Console.WriteLine("Thong tin danh sach cong nhan:");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", "Hoten", "GioiTinh", "DiaChi", "NamSinh", "TenCongTy", "NgayLamViec", "HeSoLuong");
            
            foreach (CongNhan congNhan in listCongNhan)
            {
                Console.WriteLine(congNhan.ToString());
            }
            //in max salary
            Console.WriteLine("\nThong tin cong nhan co Max salary: ");
            CongNhan congNhanMax = listCongNhan.Max();
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", "Hoten", "GioiTinh", "DiaChi", "NamSinh", "TenCongTy", "NgayLamViec", "HeSoLuong");
            Console.WriteLine(congNhanMax.ToString());
            Console.ReadLine();
         
        }
    }
}
