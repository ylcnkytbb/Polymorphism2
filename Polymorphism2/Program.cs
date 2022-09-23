namespace Polymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.CalisanAd = "Bill Gates";
            yonetici.CalisanMaas = 8500;
            yonetici.DepartmanKar = 55000;
            Console.WriteLine("Yönetici Adı: {0}, Yönetici Maaşı: {1}, Yonetici Departman Kar: {2}", yonetici.CalisanAd, yonetici.CalisanMaas, yonetici.DepartmanKar);
            yonetici.ZamYap(4000);
            Console.WriteLine("Yeni Maaş:  {0}  ", yonetici.CalisanMaas);
        }
    }
}