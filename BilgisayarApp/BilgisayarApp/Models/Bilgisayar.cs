using System;

namespace BilgisayarApp.Models
{
    class Bilgisayar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double GHz { get; set; }
        public short Hafiza { get; set; }
        public double Inc { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }
        public BilgisayarTipi BilgisayarTipi { get; set; }

    }
}
