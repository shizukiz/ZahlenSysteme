// ///////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright ©2022 IcamSystems GmbH - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// 
// This file is part of ConsoleApp2
// 
// Created at 25.10.2022  14:21
// Autor:  Danny Sotzny <danny.sotzny@icamsystems.de>
// 
// ///////////////////////////////////////////////////////////////////////////////////////////////////
// 

namespace ConsoleApp2
{
    public interface IZahlenSystemConverter2
    {
        string Convert(string eingabe, int basisVon, int basisNach);
    }
}