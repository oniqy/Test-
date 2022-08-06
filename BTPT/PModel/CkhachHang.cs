using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPT
{
    abstract class CkhachHang
    {
        private string maKhachang;
        private string tenKhachhang;
        public int soLuong;
        private double giaBan;

        protected string MaKhachang
        {
            get => maKhachang; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Khong duoc de trong");
                }
                else maKhachang = value;
            }
        }
        protected string TenKhachhang
        {
            get => tenKhachhang; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Khong duoc de trong");
                }
                else tenKhachhang = value;
            }
        }
        protected int SoLuong { get => soLuong; set { if (value < 0) { Console.WriteLine("Loi"); } else soLuong = value; } }
        protected double GiaBan { get => giaBan; set => giaBan = value; }
        public abstract double chietKhau();
        public double thueVAT()
        {
            return (SoLuong * GiaBan) * 0.1;
        }
        public double thanhTien()
        {
            return SoLuong * GiaBan - chietKhau() + thueVAT();
        }
        public CkhachHang(string mkh, string tkh, int sl, double gia)
        {
            MaKhachang = mkh;
            TenKhachhang = tkh;
            SoLuong = sl;
            GiaBan = gia;

        }
        public CkhachHang()
        {
            MaKhachang = "unknown";
            TenKhachhang = "unknown";
            SoLuong = 0;
            GiaBan = 0;
        }
        public CkhachHang(CkhachHang a)
        {
            this.MaKhachang = a.MaKhachang;
            this.TenKhachhang = a.TenKhachhang;
            this.SoLuong = a.SoLuong;
            this.GiaBan = a.GiaBan;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma khach hang:");
            MaKhachang = Console.ReadLine();
            Console.Write("Nhap ten khach hang:");
            TenKhachhang = Console.ReadLine();
            Console.Write("Nhap so luong:");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban:");
            GiaBan = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ten cong ty:GGShop");
            Console.WriteLine("So dien thoai:0123456789");
            Console.WriteLine("Dia chi:Nowhere");
            Console.WriteLine("Ma khach hang:{0}\nTen khach hang:{1}\nSo luong:{2}\nGia Ban:{3}\nThue VAT:{4}\nChiet khau:{5}\nThanh tien:{6}", MaKhachang, TenKhachhang, SoLuong, GiaBan, thueVAT(), chietKhau(), thanhTien());
        }
    }
}
