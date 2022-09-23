using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
/*kullanmak için override ve virtual niteleyicilerini kullanmak gereklidir.
 * Temel Sınıfın Metotlarını Ezme (Override)
 * Bir virtual metot (ya da property), child sınıftaki aynı isme sahip bir metot tarafından
 * başına override anahtar kelimesi eklenerek ezilmesine olanak sağlar.
 Virtual olarak işaretlenen metotlar miras aldığı classlar da ezilebilir olur. */
{
    class Yonetici : Calisan
    {
        private double _departmanKar;
        public double DepartmanKar
        {
            get { return _departmanKar; }   
            set { _departmanKar = value; } 
            
        }

        public override void ZamYap(double zamMiktar)
        {
            if (DepartmanKar > 50000)
            {
                zamMiktar += 2000;

            }
            base.ZamYap(zamMiktar);
        }

    }
}
