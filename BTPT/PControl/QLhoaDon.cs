using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPT.PControl
{
    internal class QLhoaDon
    {
        List<CkhachHang> pt = new List<CkhachHang>();
        public void NhapTTkh()
        {
            int sokh;
            do
            {
                Console.Write("Nhap so khach hang:");
                sokh = int.Parse(Console.ReadLine());
            } while (sokh <= 0);
            int loaikh = 0;
            for(int i = 0; i < sokh; i++)
            {
                do
                {
                    Console.WriteLine("Chon 1: De nhap khach hang ca nhan ");
                    Console.WriteLine("Chon 2: De nhap Dai ly cap 1");
                    Console.WriteLine("Chon 3: De nhap khach hang cong ty");
                    loaikh = Int32.Parse(Console.ReadLine());
                } while (loaikh != 1 && loaikh != 2 && loaikh != 3);
                switch (loaikh)
                {
                    case 1:
                        {
                            CkhachHang kh = new CkhachHangcanhan();
                            kh.Nhap();
                            pt.Add(kh);
                            break;
                        }
                    case 2:
                        {
                            CkhachHang kh = new CdaiLycap1();
                            kh.Nhap();
                            pt.Add(kh);
                            break;
                        }
                    case 3:
                        {
                            CkhachHang kh = new CkhachHangCty();
                            kh.Nhap();
                            pt.Add(kh);
                            break;
                        }
                }
            }
        }
        public void XuatTTkh()
        {
            Console.WriteLine("\n\nDANH SACH KHACH HANG LA");
            foreach (CkhachHang c in pt)
                c.Xuat();
        }
        public void XuatTTKhCh()
        {
            Console.WriteLine("\nDANH SACH KHACH HANG CA NHAN LA ");
            foreach (CkhachHang c in pt)
            {
                try
                {
                    CkhachHangcanhan CN = (CkhachHangcanhan)c;//ep kieu
                    if (CN != null)
                        CN.Xuat();
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e.Message);
                }
            }
        }
        public void XuatTTdlc1()
        {
            Console.WriteLine("\nDANH SACH DAI LY CAP 1 LA ");
            foreach (CkhachHang c in pt)
            {
                try
                {
                    CdaiLycap1 CN = (CdaiLycap1)c;//ep kieu
                    if (CN != null)
                        CN.Xuat();
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e.Message);
                }
            }
        }
        public void XuatTTKHCTY()
        {
            Console.WriteLine("\nDANH SACH KHACH HANG CONG TY LA ");
            foreach (CkhachHang c in pt)
            {
                try
                {
                    CkhachHangCty CN = (CkhachHangCty)c;//ep kieu
                    if (CN != null)
                        CN.Xuat();
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e.Message);
                }
            }
        }
        public void TongTientatcaHD()
        {
            Console.WriteLine("\n \nTONG THANH TIEN CUA TAT CA HOA DON ");
            double tong = 0;
            foreach (var a in pt)
            {
                try
                {
                    CkhachHang x = (CkhachHang)a;
                    if (x != null) tong += x.thanhTien();
                }
                catch { }
            }
            Console.WriteLine("Tong tien tat ca hoa don:"+tong);
        }
        public void TongTientrogia()
        {
            Console.WriteLine("\n \nTONG THANH TIEN TRO GIA LA");
            double tong1 = 0;
            double tong2 = 0;
            double tong = 0;
            foreach (var a in pt)
            {
                try
                {
                    CkhachHangcanhan x = (CkhachHangcanhan)a;
                    if (x != null) tong1 += x.troGia();
                }
                catch { }
            }
            foreach (var b in pt)
            { 
                try
                {
                    CkhachHangCty t = (CkhachHangCty)b;
                    if (t != null) tong2 += t.troGia();
                }
                catch { }
            }
            tong = tong1 + tong2;
            Console.WriteLine("Tong tro gia:{0}",tong);
        }
        public void TongTienchieukhau()
        {
            Console.WriteLine("TONG THANH TIEN CHIET KHAU CUA KHACH HANG CONG TY ");        
            double tong = 0;

            foreach (var b in pt)
            {
                try
                {
                    CkhachHangCty t = (CkhachHangCty)b;
                    if (t != null) tong += t.chietKhau();
                }
                catch { }
            }
            Console.WriteLine("Tong chiet khau:{0}", tong);
        }
        public void KHmuanhieunhat()
        {
            List<CkhachHang> sx = pt.OrderBy(pt => pt.soLuong).ToList();
            Console.WriteLine("\n SAP XEP TANG DAN THEO SO LUONG");
            foreach (var a in sx)
            {
                try
                {
                    Console.WriteLine("\n");
                    a.Xuat();
                    
                }
                catch { }
            }
        }

    }
}
