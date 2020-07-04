using System;


namespace deneme_11_classes_const_enums
{
    class Oyuncu
    {
        static public int Toplam;
        public Oyuncu()
        {
            Oyuncu.Toplam++;
        }
        static Oyuncu()
        {
            Toplam = 0;
        }
        ~Oyuncu()
        {
            Console.WriteLine("Bir oyuncunuz gitti.");
            Toplam--;
        }
    }
    class Sayisal
    {
        public static int Topla(params int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; ++i)
                toplam += dizi[i];
            return toplam;

        }
    }
    class Time
    {
        private int mHour;
        private int mMinute;
        private int mSecond;
        /// Yıkıcı Tanımlama class ismi ile tanımlanır
        // ~Time()
        // {
        //     Console.WriteLine("Yikici metot cagrildi.");
        // }

        public int Hour
        {
            get
            {
                return mHour;
            }
            set
            {
                mHour = value;
            }
        }
        public int Minute
        {
            get
            {
                return mMinute;
            }
            set
            {
                mMinute = value;
            }
        }
        public int Second
        {
            get
            {
                return mSecond;
            }
            set
            {
                mSecond = value;
            }
        }
        public Time(int h, int m, int s)
        {
            Second = s % 60;
            int newMinute = m + s / 60;
            Minute = newMinute % 60;
            Hour = h + newMinute / 60;
            if (Hour >= 24)
            {
                Hour -= 24;
            }


        }
        public void SaatYaz()
        {
            Console.WriteLine("_____________");
            Console.WriteLine("Saat   : {0,2}  |", mHour);
            Console.WriteLine("Dakika : {0,2}  |", mMinute);
            Console.WriteLine("Saniye : {0,2}  |", mSecond);
            Console.WriteLine("-------------");

        }
        public Time(Time yeni) /// --> Copy Constructor
        {
            mHour = yeni.mHour;
            mMinute = yeni.mMinute;
            mSecond = yeni.mSecond;
        }

    }
    class Rectangular
    {
        private int mEn;
        private int mBoy;
        // Get ve Set yapısı :
        public int En
        {
            get
            {
                return mEn;
            }
            set
            {
                if (value < 0)
                    mEn = 0;
                else
                    mEn = value;
            }
        }
        public int Boy
        {
            get
            {
                return mBoy;
            }
            set
            {
                if (value < 0)
                    mBoy = 0;
                else
                    mBoy = value;

            }

        }
        public int Area()
        {
            int Area = mEn * mBoy;
            return Area;
        }
        public void EnBoyBelirle(int en, int boy)
        {
            if (en < 0 || boy < 0)
            {
                En = 0;
                Boy = 0;
            }
            else
            {
                En = en;
                Boy = boy;
            }
        }
        public bool IsSquare()
        {
            if (mBoy == mEn)
                return true;
            else
                return false;
        }
        public double FindCorner()
        {
            double corner;
            corner = Math.Sqrt(mBoy * mBoy + mEn * mEn);

            return corner;
        }
        public void Yaz()
        {
            Console.WriteLine("********************");
            Console.WriteLine("En     : {0,7}", En);
            Console.WriteLine("Boy    : {0,7}", Boy);
            Console.WriteLine("Kare mi: {0,7}", IsSquare());
            Console.WriteLine("Alan   : {0,7}", Area());
            Console.WriteLine("Köşegen: {0,7}", FindCorner());
            Console.WriteLine("********************");

            Console.WriteLine("Dörtgenin Şekli");

            for (int y = 0; y < Boy; ++y)
            {
                for (int x = 0; x < En; x++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }


    }
    class Dortgen
    {
        public int En;
        public int Boy;
        public int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        public void EnBoyBelirle(int en, int boy)
        {
            if (en < 0 || boy < 0)
            {
                En = 0;
                Boy = 0;
            }
            else
            {
                En = en;
                Boy = boy;
            }
        }
        public void Yaz()
        {
            Console.WriteLine("********************");
            Console.WriteLine("En   : {0,7}", En);
            Console.WriteLine("Boy  : {0,7}", Boy);
            Console.WriteLine("Alan : {0,7}", Alan());
            Console.WriteLine("********************");

            Console.WriteLine("Dörtgenin Şekli");

            for (int y = 0; y < Boy; ++y)
            {
                for (int x = 0; x < En; x++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
    class KrediHesabi
    {
        public ulong HesapNo;
        public double Limit;
        public string Kartsahibi;
    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            KrediHesabi hesap = new KrediHesabi();
            //KrediHesabi account = new KrediHesabi();

            hesap.HesapNo = 5553236622;
            hesap.Limit = 100000000;
            hesap.Kartsahibi = "Amor Fati";


            Console.WriteLine(hesap.HesapNo);
            Console.WriteLine(hesap.Limit);
            Console.WriteLine(hesap.Kartsahibi);

            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2;

            hesap1.HesapNo = 55232321331;

            Console.WriteLine(hesap1.HesapNo);

            hesap2 = hesap1;

            Console.WriteLine(hesap2.HesapNo);

            hesap2.HesapNo = 111111111;

            Console.WriteLine(hesap1.HesapNo);

            // //// public  erişim belirleyiciler ile  /////
            Dortgen d = new Dortgen();
            Console.Write("Alanının hesaplanmasını istediğiniz dörtgenin enini giriniz  : ");
            int en = Convert.ToInt32(Console.ReadLine());

            Console.Write("Alanının hesaplanmasını istediğiniz dörtgenin boyunu giriniz : ");
            int boy = Convert.ToInt32(Console.ReadLine());

            d.EnBoyBelirle(en, boy);
            d.Yaz();

            // //// private  erişim belirleyiciler ile /////
            Rectangular rec = new Rectangular();
            rec.EnBoyBelirle(en, boy);
            rec.Yaz();

            //// Zaman ==> Constructors metotlar ile yapıldı
            Console.Write("Saniyeyi giriniz :");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dakikayı giriniz :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saati giriniz :");
            int h = Convert.ToInt32(Console.ReadLine());

            Time t = new Time(h, m, s);
            Time t2 = new Time(t); // --> copy constructor

            t2.SaatYaz();
            t.SaatYaz();

            Time z1 = new Time(5, 5, 5);
            z1.SaatYaz();
            Time z2 = new Time(6, 6, 6);
            z2.SaatYaz();
            z1 = z2;
            z1.Minute = 50;
            z2.SaatYaz();

            // Statik Metot oluşturma ve kullanma ; Sayisal isminde sınıf oluşturma 
            // ve bu sinıf içinde oluşturulan Statik Topla metodu ile işlemimizi gerçekleştirme. 
            int total;
            total = Sayisal.Topla(4, 5, 85, 36, 12, 99, 1258);
            Console.Write("\nToplam = {0,2} ", total);
            Console.WriteLine();

            // Statik yapıcı metot ve satatik değişken kullanma
            Oyuncu o = new Oyuncu();
            Console.WriteLine("Toplam oyuncu : " + Oyuncu.Toplam);
            Oyuncu o2 = new Oyuncu();
            Console.WriteLine("Toplam oyuncu : " + Oyuncu.Toplam);
         

            //Console.Read();





        }

    }

}
