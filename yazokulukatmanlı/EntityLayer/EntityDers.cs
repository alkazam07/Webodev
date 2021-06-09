using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr
{
    public class EntityDers
    {
        private string DersAd;
        private int min;
        private int max;
        private int id;

        public string DERSAD { get => DersAd; set => DersAd = value; }
        public int MIN { get => min; set => min = value; }
        public int MAX { get => max; set => max = value; }
        public int ID { get => id; set => id = value; }
    }
}
