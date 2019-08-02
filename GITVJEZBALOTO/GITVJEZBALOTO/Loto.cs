using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITVJEZBALOTO
{
    class Loto
    {
        public List<int> UplaceniBrojevi = new List<int>();
        public List<int> DobitniBrojevi = new List<int>();

        public Loto()
        {
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int broj = random.Next(1, 40);
                DobitniBrojevi.Add(broj);
            }
        }

        public void SpremiUplaceneBrojeve(int prvi, int drugi, int treci, int cetvrti, int peti, int sesti, int sedmi)
        {
            UplaceniBrojevi.Add(prvi);
            UplaceniBrojevi.Add(drugi);
            UplaceniBrojevi.Add(treci);
            UplaceniBrojevi.Add(cetvrti);
            UplaceniBrojevi.Add(peti);
            UplaceniBrojevi.Add(sesti);
            UplaceniBrojevi.Add(sedmi);
        }
    }
}
