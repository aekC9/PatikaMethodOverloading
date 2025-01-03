﻿using System;
namespace MethodOverloading;
class Solution
{
    static void Main(string[] args)
    {
        // out parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi,out int outSayi);
        if(sonuc){
            System.Console.WriteLine("Başarılı!");
            System.Console.WriteLine(outSayi);
        }else{
            System.Console.WriteLine("Başarısız");
        }
        Metotlar instance = new Metotlar();
        instance.Topla(4,5,out int toplamSonucu);
        System.Console.WriteLine(toplamSonucu);
        //Metot aşırı yükleme - Overloading
        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Zikriye","Ürkmez");
        //Metot imzası
        //MetotAdı + parametreSayisi + parametre
    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam){
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        System.Console.WriteLine(veri1 + ' ' + veri2);
    }
}