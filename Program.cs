internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calisan sayisi={0}",Calisan.CalisanSayisi);

        Calisan calisan1=new Calisan("Ayse","Yilmaz","IK");
        Console.WriteLine("Calisan sayisi={0}",Calisan.CalisanSayisi);
        Calisan calisan2=new Calisan("Deniz","Arda","IK");
        Calisan calisan3=new Calisan("Zikriye","Urkmez","IK");
        Console.WriteLine("Calisan sayisi={0}",Calisan.CalisanSayisi);

        Console.WriteLine("Toplama islemi sonucu: {0}",Islemler.Topla(100,300));
        Console.WriteLine("Cikarma islemi sonucu: {0}",Islemler.Cikarma(400,50));
    }

    class Calisan 
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim=soyIsim;
            this.Departman=departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

    // class Ogrenci
    // {
    //     public static int OgrenciSayisi= 0;

    //     public string Isim;
    //     public string SoyIsim;

    //     public Ogrenci()
    //     {
    //         OgrenciSayisi ++;
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         //Static uyelerine erisim
    //         Console.WriteLine("Ogrenci sayisi: {0}",Ogrenci.OgrenciSayisi);

    //         //Static olmayan sinif uyesine erisim
    //         Ogrenci ogrenci1= new Ogrenci();
    //         ogrenci1.Isim="Deniz";
    //         ogrenci1.SoyIsim="Arda";

    //         Ogrenci ogrenci2= new Ogrenci();
    //         ogrenci2.Isim="Ayse";
    //         ogrenci2.SoyIsim="Yilmaz";

    //         Console.WriteLine("Ogrenci sayisi: {0}",Ogrenci.OgrenciSayisi);
    //     }
    // }
}
