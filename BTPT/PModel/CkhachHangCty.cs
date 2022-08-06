using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPT
{
    internal class CkhachHangCty : CkhachHang,Interface1
    {
        private int slNhanvien;

        protected int SlNhanvien
        {
            get => slNhanvien; set
            {
                if (value < 0)
                {
                    Console.WriteLine("Loi khoang cach");
                }
                else slNhanvien = value;
            }
        }
        public override double chietKhau()
        {
            if (SlNhanvien > 1000 && SlNhanvien<=5000)
            {
                return GiaBan * 0.03;
            }
            else if (SlNhanvien > 5000)
            {
                return GiaBan * 0.05;
            }
            else
                return 0;
           
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so luong nhan vien:");
            SlNhanvien = int.Parse(Console.ReadLine());
        }

        public double troGia()
        {
            double trogia = 0;
            double a = 0;
            for (int i = 1; i <= SoLuong; i++)
            {
                double b = 0;
                b = b+120000;
                a = a + b;
            }
            return trogia = a;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So luong nhan vien la:"+SlNhanvien);
            Console.WriteLine("Tro gia:"+troGia());
            Console.WriteLine("Tong tien:{0}",thanhTien()-troGia());
        }
    }
}
