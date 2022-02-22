using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Bilgisayar enisinBilgisayari = new Bilgisayar("Enis","i7 9850h","16gb","gtx","1tb","500gb","gamepower bronze");
            enisinBilgisayari.BilgileriGoster();

            Bilgisayar ilaydaninBilgisayari = new Bilgisayar();

            ilaydaninBilgisayari.BilgileriElleGir();
            ilaydaninBilgisayari.BilgileriGoster();

            double daire1YariCap = 4;
            Daire daire1 = new Daire(daire1YariCap);
            
            double dairbirinAlani = daire1.AlanBul();
            Console.WriteLine("Yariçapı " + daire1YariCap + " olan dairenin alanı = " + dairbirinAlani);
            double dairbirinCevresi = daire1.CevreBul();
            Console.WriteLine("Yariçapı " + daire1YariCap + " olan dairenin çevresi = " + dairbirinCevresi);
        }
    }
}
