using System;
namespace Prakta
{class Para
    {private string NazvaniePari;
    private string NomerPari;
    public void Vvod()
    {Console.WriteLine("Vvedite Nazvanie Pari, Nomer Pari");
        NazvaniePari= Console.ReadLine();
        NomerPari= Console.ReadLine();
    }
    public void Vivod()
    {Console.WriteLine("Nazvanie Pari="+NazvaniePari+"Nomer Pari="+NomerPari);
    }
    public void Izmenenie()
    {Vvod();
    }
}
    class Den
    {private string NazvanieDnya;
        private Para odin=new Para();
        private Para dva=new Para();
        private Para tri=new Para();
        private Para chetire=new Para();
        public void VvodD()
        {
            Console.WriteLine("Введите название дня");
            NazvanieDnya = Console.ReadLine();
            odin.Vvod();
            dva.Vvod();
            tri.Vvod();
            chetire.Vvod();
        }
     //Спасибо
        public void VivodD()
        {odin.Vivod();
            dva.Vivod();
            tri.Vivod();
            chetire.Vivod();
        }
        public void IzmenenieD()
        {VvodD();
        }}
        class Nedelya
        {private string NazvaneNedeli;
            private Den ponedelnik=new Den();
            private Den vtornik=new Den();
            private Den sreda=new Den();
            private Den chetverg=new Den();
            private Den pyatnica=new Den();
        public void VvodN()
        {
            Console.WriteLine("Введите название недели");
            NazvaneNedeli = Console.ReadLine();
            ponedelnik.VvodD();
            vtornik.VvodD();
            sreda.VvodD();
            chetverg.VvodD();
            pyatnica.VvodD();
        }
        public void VivodN()
        {ponedelnik.VivodD();
            vtornik.VivodD();
            sreda.VivodD();
            chetverg.VivodD();
            pyatnica.VivodD();
        }
        public void IzmenenieN()
        {VvodN();
        }
}
        
        class MetMain
        {static void Main()
        { Nedelya ned=new Nedelya();
            ned.VvodN();
            ned.VivodN();
            ned.IzmenenieN();
                ned.VivodN();
                Console.ReadKey();
        }}}
