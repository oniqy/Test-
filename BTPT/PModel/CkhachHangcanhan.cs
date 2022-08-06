using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPT
{
    internal class CkhachHangcanhan : CkhachHang,Interface1
    {
        private int khoangCach;

        protected int KhoangCach { get => khoangCach; set { if (value < 0) { Console.WriteLine("Loi khoang cach"); } else khoangCach = value; } }
        public override double chietKhau()
        {
            double ckkc = 0;
            double chietkhau = 0;
            double a = 0;
            if (KhoangCach < 1000)
            {
                for (int i = 1; i <= SoLuong; i++)
                {
                     ckkc += chietkhau + 20000;
                }
            }
            if (SoLuong >= 5)
            {
                for (int i = 1; i <= SoLuong; i++)
                {
                    double b = 0;
                    b = GiaBan * 0.03;
                    a += b;
                }
                 chietkhau = a;
            }
            else return ckkc;
            return ckkc + chietkhau;
        }
        public CkhachHangcanhan(string mkh, string tkh, int sl, double gia, int kc) : base(mkh, tkh, sl, gia)
        {
            KhoangCach = kc;
        }
        public CkhachHangcanhan()
        {
            KhoangCach = 1;
        }
        public CkhachHangcanhan(CkhachHangcanhan a)
        {
            this.KhoangCach = a.KhoangCach;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap khoang cach (m):");
            KhoangCach = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khoang cach:{0}m\ntrogia:{1}", KhoangCach,troGia());
             Console.WriteLine("Tong tien:{0}",thanhTien()-troGia());
        }

        public double troGia()
        {
            double trogia = 0;
            double a = 0;
            for (int i = 1; i <= SoLuong; i++)
            {
                double b = 0;
                b = GiaBan * 0.02;
                a += b;
            }
            trogia = a;
            if (SoLuong > 2) return trogia + 100000;
            else return trogia;
        }
    }
    
}
