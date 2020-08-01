using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    //atiklar ve atikkutusu siniflari olusturuldu
    class CamSise : IAtik
    {
        private String _isim = "Cam Şişe(600)";

        private String _turu = "cam";

        private int _hacim = 600;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.camSise;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }            
        }
    }

    class Bardak : IAtik
    {
        private String _isim = "Bardak(250)";

        private String _turu = "cam";

        private int _hacim = 250;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.bardak;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class Gazete : IAtik
    {
        private String _isim = "Gazete(250)";

        private String _turu = "kagit";

        private int _hacim = 250;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.gazete;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class Dergi : IAtik
    {
        private String _isim = "Dergi(200)";

        private String _turu = "kagit";

        private int _hacim = 200;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.dergi;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class Domates : IAtik
    {
        private String _isim = "Domates(150)";

        private String _turu = "organik";

        private int _hacim = 150;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.domates;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class Salatalik : IAtik
    {
        private String _isim = "Salatalık(120)";

        private String _turu = "organik";

        private int _hacim = 120;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.salatalik;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class KolaKutusu : IAtik
    {
        private String _isim = "Kola Kutusu(350)";

        private String _turu = "metal";

        private int _hacim = 350;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.kolaKutusu;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
            
        }
    }

    class SalcaKutusu : IAtik
    {
        private String _isim = "Salça Kutusu(550)";

        private String _turu = "metal";

        private int _hacim = 550;

        private System.Drawing.Image _image= global::ndpproje.Properties.Resources.salcaKutusu;

        public String Isim
        {
            get
            {
                return _isim;
            }
        }
        public String Turu
        {
            get
            {
                return _turu;
            }
        }

        public int Hacim
        {
            get
            {
                return _hacim;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return _image;
            }
           
        }
    }

    class OrganikAtikKutusu : IAtikKutusu
    {

        private int _kapasite = 700;

        private int _doluHacim;

        private int _bosaltmaPuani=0;

        public int Kapasite
        {
            get
            {
                return _kapasite;
            }
        }

        public int DoluHacim
        {
            get
            {
                return _doluHacim;
            }
            set
            {
                _doluHacim = value;
            }
        }
    
        public int DolulukOrani
        {
            get
            {
                return ((DoluHacim * 100) / Kapasite);
            }
        }
    
        public int BosaltmaPuani
        {
            get
            {
                return _bosaltmaPuani;
                
            }
        }    

        public bool Ekle(IAtik atik)
        {
            if (atik.Turu == "organik")
            {
                return true;
            }

            else
            {
                return false;
            }       
        }
        
        public bool Bosalt()
        {
            if (DolulukOrani >= 75) 
            {
                return true;            
            }

            else
            {
                return false;
            }
        }
    
    }

    class KagitKutusu : IAtikKutusu
    {

        private int _kapasite = 1200;

        private int _doluHacim;

        private int _bosaltmaPuani = 1000;

        public int Kapasite
        {
            get
            {
                return _kapasite;
            }
        }

        public int DoluHacim
        {
            get
            {
                return _doluHacim;
            }
            set
            {
                _doluHacim = value;
            }
        }

        public int DolulukOrani
        {
            get
            {
                return ((DoluHacim * 100) / Kapasite);
            }
        }

        public int BosaltmaPuani
        {
            get
            {
                return _bosaltmaPuani;

            }
        }

        public bool Ekle(IAtik atik)
        {
            if (atik.Turu == "kagit")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }

    class CamKutusu : IAtikKutusu
    {

        private int _kapasite = 2200;

        private int _doluHacim;

        private int _bosaltmaPuani = 600;

        public int Kapasite
        {
            get
            {
                return _kapasite;
            }
        }

        public int DoluHacim
        {
            get
            {
                return _doluHacim;
            }
            set
            {
                _doluHacim = value;
            }
        }

        public int DolulukOrani
        {
            get
            {
                return ((DoluHacim * 100) / Kapasite);
            }
        }

        public int BosaltmaPuani
        {
            get
            {
                return _bosaltmaPuani;

            }
        }

        public bool Ekle(IAtik atik)
        {
            if (atik.Turu == "cam")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }

    class MetalKutusu : IAtikKutusu
    {

        private int _kapasite = 2300;

        private int _doluHacim;

        private int _bosaltmaPuani = 800;

        public int Kapasite
        {
            get
            {
                return _kapasite;
            }
        }

        public int DoluHacim
        {
            get
            {
                return _doluHacim;
            }
            set
            {
                _doluHacim = value;
            }
        }

        public int DolulukOrani
        {
            get
            {
                
                return ((DoluHacim*100)/Kapasite);
            }
        }

        public int BosaltmaPuani
        {
            get
            {
                return _bosaltmaPuani;
            }
        }

        public bool Ekle(IAtik atik)
        {
            if (atik.Turu == "metal")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
