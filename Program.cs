namespace Zahlensysteme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var converter = new ZahlenSystemConverter();
            var zahl = 123456;


            
            var bin = converter.DecToBin(zahl);
            var bin2dec = converter.BinToDec(bin);

            var t3 = converter.DecToOct(bin2dec);
            var t4 = converter.OctToDec(t3);

            var t5 = converter.DecToHex(t4);
            var t6 = converter.HexToDec(t5);
            var t9 = converter.Convert("123456", 10, 11);

            

            if (t9 != t5) throw new Exception("Zahlen Stimmen nicht überein!");
            if (bin2dec != zahl) throw new Exception("Zahl stimmt nicht überein");

            Console.WriteLine("Ende");
            Console.ReadKey();

        }
    }
}