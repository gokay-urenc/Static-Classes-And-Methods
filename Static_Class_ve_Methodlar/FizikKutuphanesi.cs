using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_ve_Methodlar
{
    public static class FizikKutuphanesi
    {
        public static decimal YerCekimiKuvveti
        {
            get
            {
                return 9.865M;
            }
        }
        public const int KaldirmaKuvveti = 12;
    }
}
/* Static class: Eğer nesneye bağımlı işlemler gerçekleştirilmiyorsa, yani amaç sadece belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplama ise ilgili sınıfı static olarak         işaretleyebilir ve içerisindeki tüm öğelere instance'den bağımsız olarak ulaşılabilir. 
   Static class içerisinde static olmayan hiç bir üye tanımlanamaz. 
   Static bir class başka bir class'tan  miras alamaz. 
   Ancak .NET Framework mantığı gereği tüm sınıflar System.Object sınıfından kalıtım alırlar.
   Static sınıflara en güzel örnek Math sınıfıdır.
   Aynı amaca (Math => Matematiksel işlemlerin bir arada tutulması.) hizmet eden öğeleri içerisinde barındıran ve hızlıca ulaşılmayı sağlayan sınıftır. 
   Ancak her sınıf static olarak işaretlenmemelidir. 
   Çünkü tanımlanmış olan her static ufakta olsa performans kaybı olarak geri dönecektir. 
   Const: Sabir değer ... kendiliğinden static olma özelliğine sahiptir. 
*/