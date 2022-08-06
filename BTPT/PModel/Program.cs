using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTPT.PControl;
namespace BTPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLhoaDon nw = new QLhoaDon();
            nw.NhapTTkh();
            nw.XuatTTKhCh();
            nw.XuatTTKHCTY();
            nw.XuatTTdlc1();
            //nw.TongTientatcaHD();
            nw.TongTientrogia();
            //nw.TongTienchieukhau();
            //nw.KHmuanhieunhat();
            Console.ReadKey();
        }
        
    }
}
