using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPT
{
    internal class CdaiLycap1 : CkhachHang
    {
        private int tgHoptac;

        protected int TgHoptac 
        { 
            get => tgHoptac; 
                 set 
        
                { 
                    if (value < 0) 
                    { 
                        Console.WriteLine("Loi khoang cach"); 
                    } 
                    else tgHoptac = value;
                } 
        }
        public override double chietKhau()
        {
            double a =30;
            double ck =  GiaBan * 0.3;
            if (TgHoptac > 3 && TgHoptac < 36)
            {
                a = (a+TgHoptac)*0.01;
                return ck =  GiaBan * a;
            }
            else
                return ck;
        }
        public CdaiLycap1(string mkh, string tkh, int sl, double gia, int tg) : base(mkh, tkh, sl, gia)
        {
            TgHoptac = tg;
        }
        public CdaiLycap1()
        {
            TgHoptac = 1;
        }
        public CdaiLycap1(CdaiLycap1 b)
        {
            this.TgHoptac = b.TgHoptac;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap thoi gian hop tac:");
            TgHoptac = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Thoi gian hop tac:" + TgHoptac);
        }
    }
}
