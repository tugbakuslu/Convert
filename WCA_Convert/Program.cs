using System;

namespace WCA_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s1 = "10";
            string s2 = "10";
            Console.WriteLine(s1 + s2);

            int s1 = 10;
            int s2 = 10;
            Console.WriteLine("Toplama İslemi Sonucu :" + (s1 + s2));
             */
            string cevrilecek = "123";
            byte s1 = Convert.ToByte(cevrilecek);
            sbyte s2 = Convert.ToSByte(cevrilecek);
            short s3 = Convert.ToInt16(cevrilecek);
            ushort s4 = Convert.ToUInt16(cevrilecek);
            int s5 = Convert.ToInt32(cevrilecek);
            uint s6 = Convert.ToUInt32(cevrilecek);
            long s7 = Convert.ToInt64(cevrilecek);
            ulong s8 = Convert.ToUInt64(cevrilecek);
            float s9 = Convert.ToSingle(cevrilecek);
            double s10 = Convert.ToDouble(cevrilecek);
            decimal s11 = Convert.ToDecimal(cevrilecek);



        }
    }
}
