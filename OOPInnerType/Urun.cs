﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnerType
{
    public class Urun
    {
        public int urunId {  get; set; }
        public string Tanim {  get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun Yapıcı MEtot ÇAlıştı");
        }
        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
