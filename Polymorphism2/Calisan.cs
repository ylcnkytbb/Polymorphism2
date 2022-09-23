namespace Polymorphism2
{
    class Calisan
    {
        private string _calisanAd;
        private double _calisanMaas;
        public string CalisanAd
        {
            get { return _calisanAd; }
            set { _calisanAd = value; }
        }
        public double CalisanMaas
        {
            get { return _calisanMaas; }
            set { _calisanMaas = value; }
        }
        public virtual void ZamYap (double zamMiktar)
        {
            _calisanMaas += zamMiktar;   
        }


    }
}
