using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;

            Console.WriteLine("Class alan hesabı    :{0}",dikdortgen.AlanHesapla());
            
            Diktortgen_Struct diktortgen_Struct=new Diktortgen_Struct(3,4);
            
            Console.WriteLine("Struct alan hesabı   :{0}",diktortgen_Struct.AlanHesapla());
        }
    }
    
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen(){
            KisaKenar=3;
            UzunKenar=4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }

    struct Diktortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public Diktortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }
}
