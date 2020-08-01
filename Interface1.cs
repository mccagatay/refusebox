using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    //interface ler olusturuldu
    public interface IAtik
    {
        String Isim { get; }
        String Turu { get; }
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    public interface IDolabilen
    {
        int Kapasite { get; }
        int DoluHacim { get; set; }
        int DolulukOrani { get; }
    }
    
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle(IAtik atik);
        bool Bosalt();
    }
}
