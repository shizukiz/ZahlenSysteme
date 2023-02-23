// ///////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright ©2022 IcamSystems GmbH - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// 
// 
// Created at 24.10.2022  09:47
// Autor:  Danny Sotzny <danny.sotzny@icamsystems.de>
// 
// ///////////////////////////////////////////////////////////////////////////////////////////////////
// 

namespace ConsoleApp2
{
    interface IZahlensystemConverter
    {
        /// <summary>
        /// Dezimal Zahl nach Binär
        /// </summary>
        /// <param name="zahl"></param>
        /// <returns></returns>
        string DecToBin(int zahl);

        /// <summary>
        /// Binär nach Dezimal
        /// </summary>
        /// <param name="binärzahl"></param>
        /// <returns></returns>
        int BinToDec(string binärzahl);

        /// <summary>
        /// Dezimal nach Hexadecimal
        /// </summary>
        /// <param name="zahl"></param>
        /// <returns></returns>
        string DecToHex(int zahl);

        /// <summary>
        /// Hexadecimale Zahl nach Dezimal
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        int HexToDec(string hex);

        /// <summary>
        /// Dezimale Zahl nach Octal
        /// </summary>
        /// <param name="zahl"></param>
        /// <returns></returns>
        string DecToOct(int zahl);

        /// <summary>
        /// Octale Zahl nach Dezimal
        /// </summary>
        /// <param name="oct"></param>
        /// <returns></returns>
        int OctToDec(string oct);


    }
}