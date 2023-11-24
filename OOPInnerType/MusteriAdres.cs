using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInnerType
{
    public class MusteriAdres
    {
        #region Inner Type gerektiren field lar
        public string adresTip { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        #endregion
        public MusteriAdres()
        {
            Console.WriteLine("Musteri Adres yapıcı metotu çalıştı....");
        }
        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
