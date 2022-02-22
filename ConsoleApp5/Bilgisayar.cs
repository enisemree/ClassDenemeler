using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Bilgisayar
    {
        private string BilgisayarSahibi;
        private string Islemci;
        private string Ram;
        private string EkranKartiModeli;
        private string HDD;
        private string SSD;
        private string PowerSupply;

        public Bilgisayar(string bilgisayarSahibi,string islemci, string ram, string ekranKartiModel, string hDD, string ssD, string powerSupply)
        {
           
            Islemci          = islemci        .ToUpper();
            Ram              = ram            .ToUpper();
            EkranKartiModeli = ekranKartiModel.ToUpper();
            HDD              = hDD            .ToUpper();
            SSD              = ssD            .ToUpper();
            PowerSupply      = powerSupply    .ToUpper();
            BilgisayarSahibi = bilgisayarSahibi .ToUpper();
        }

        public Bilgisayar()
        {
            Islemci          ="tanımlanmadi";
            Ram              ="tanımlanmadi";
            EkranKartiModeli ="tanımlanmadi";
            HDD              ="tanımlanmadi";
            SSD              ="tanımlanmadi";
            PowerSupply      = "tanımlanmadi";
            BilgisayarSahibi = "tanımlanmadı";
        }

        public void BilgileriElleGir()
        {
            Console.Write("Adınızı Giriniz :");
            BilgisayarSahibi = Console.ReadLine();
            Console.Write("İşemciyi Giriniz : ");
            Islemci = Console.ReadLine();
            Console.Write("Ram'i Giriniz : ");
            Ram = Console.ReadLine();
            Console.Write("HDD'yi Giriniz : ");
            HDD = Console.ReadLine();
            Console.Write("SSD'yi Giriniz : ");
            SSD = Console.ReadLine();
            Console.Write("PowerSupply'ı Giriniz : ");
            PowerSupply = Console.ReadLine();

        }

        public void BilgileriGoster()
        {
            Console.WriteLine(BilgisayarSahibi + " : " +  Islemci + " " + Ram + " " + EkranKartiModeli + " " + HDD + " " + SSD + " " + PowerSupply);
        }

        public void SadeceRamiGoster()
        {
            Console.WriteLine(Ram);
        }
    }
}
