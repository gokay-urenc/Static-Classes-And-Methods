using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_ve_Methodlar
{
    class Bisiklet
    {
        public byte vites_sayisi { get; set; }
        public double tekerlek_capi { get; set; }
        public string markasi { get; set; }
        public string rengi { get; set; }
        public static int satilan_bisiklet_sayisi { get; set; } // Her alınan instance için bu bir                                                         kere oluşturulur ve hepsi bunu                                                          kullanır.
    }
}
// Static üyeler her class'ta tanımlanır.
// Property'ler sınıfın kendine ait özellikleridir.
// Sınıftan her instance alındığında yeniden tanımlanır.
// Static property classın sabit ve ortak özelliğidir.