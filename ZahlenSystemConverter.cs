using System;
using System.Diagnostics;
using System.Xml;
using ConsoleApp2;

namespace Zahlensysteme
{
    internal class ZahlenSystemConverter:IZahlensystemConverter, IZahlenSystemConverter2
    {
        public string DecToBin(int zahl)
        {
            string result = "";

            while (zahl > 0)
            {
                var rest = zahl % 2;
                zahl = zahl / 2;
                result = rest + result;
            }
            return result;
        }
    

        public string DecToHex(int zahl)
        {

            var länge1 = zahl.ToString();
            var länge = länge1.Length;
            var result = "";
            
            

            while (zahl > 0)
            {
                var rest = zahl % 16;
                zahl = zahl / 16;
                var zc = "";
                zc = DecToHexHelper(rest);

                result = zc + result;
            }


            return result;
        }

        private string DecToHexHelper(int rest) =>
            rest switch
            {
                10 => "A",
                11 => "B",
                12 => "C",
                13 => "D",
                14 => "E",
                15 => "F",
                _ => rest.ToString()
            };

        private int HexToDecHelper(char rest) =>
            rest switch
            {
                'A' => 10,
                'B' => 11,
                'C' => 12,
                'D' => 13,
                'E' => 14,
                'F' => 15,
                _ => int.Parse(rest.ToString())
            };

        string Alpha = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private int SymbolToDecHelper(char c)
        {

            
            var index = Alpha.IndexOf(c.ToString().ToUpper());
            return index;
        }

        private char DecToSymbolHelper(int i)
        {

            var c = Alpha[i];

            return c;
        }

        public int HexToDec(string hex)
        {

            var länge = hex.Length;
            var result = 0;

            for (int i = länge; i > 0; i--)
            {
                var c = hex[i - 1];
                var umwandlung = HexToDecHelper(c);
                var Multi = (int)Math.Pow(16, länge - i);
                result = result + umwandlung * Multi;
            }
            return result;

        }

        public string DecToOct(int zahl)
        {
            var umwandler = zahl.ToString();
            var länge = umwandler.Length;
            var result = "";

            for (int i = länge; i > 0; i--)
            {
                var rest = zahl % 8;
                zahl = zahl / 8;
                result = rest + result;
            }

            string ergebnis = result.ToString();
            return ergebnis;
        }
        public int OctToDec(string oct)
        {
            var länge = oct.Length;
            var result = 0; 

            for (int i = länge; i > 0; i--)
            {
                var c = oct[i - 1];
                var umwandlung = int.Parse(c.ToString());
                var Multi = (int)Math.Pow(8, länge - i);
                result = result + umwandlung * Multi;
            }
            return result;
        }

        public int BinToDec(string binärzahl)
        {
            var länge = binärzahl.Length;
            var result = 0;

            for (int i = länge; i > 0; i--)
            {
                var c = binärzahl[i - 1];
                var umwandlung = int.Parse(c.ToString());
                var Multi = (int)Math.Pow(2, länge - i);
                result = result + umwandlung * Multi;
            }
            return result;
        }

        public string Convert(string eingabe, int basisVon, int basisNach)
        {


            var länge = eingabe.Length;
            var Decimalzahl = 0;
            

            for (int i = länge; i > 0; i--)
            {
                var c = eingabe[i - 1];
                var umwandlung = SymbolToDecHelper(c);
                var Multi = (int)Math.Pow(basisVon, länge - i);
                Decimalzahl = Decimalzahl + umwandlung * Multi;
            }

            var result = "";


            while (Decimalzahl > 0)
            {
                var rest = Decimalzahl % basisNach;
                Decimalzahl = Decimalzahl / basisNach;
                var zc = DecToSymbolHelper(rest).ToString();

                result = zc + result;
            }



            return result;
        }
    }
}
