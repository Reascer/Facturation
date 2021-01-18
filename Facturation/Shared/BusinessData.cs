using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        private List<Facture> Factures = new List<Facture>();

        IEnumerable<Facture> IBusinessData.Factures { get => Factures; }

        decimal IBusinessData.CA => throw new NotImplementedException();

        public BusinessData(int nb)
        {
            string[] Names = new[] { "Bartelemy", "luca", "Ronaldo", "Sonia", "Edgard", "Wilfried", "Jean-jack", "george", "Slitherin", "Anderson" };
            var rng = new Random();
            List<int> range = new List<int>();
            DateTime date = DateTime.Now;

            for (int i = 1; i <= nb; i++)
            {
                range.Add(i);
            }
            for (int i = 0; i < nb; i++)
            {
                string client = Names[rng.Next(Names.Length)];
                int j;
                int numero;
                if (range.Count != 1)
                {
                    j = rng.Next(0, range.Count-1);
                    numero = range[j];
                    range.RemoveAt(j);
                }
                else
                {
                    numero = range[0];
                }
                
                DateTime emission = DateTime.Now.AddDays(rng.Next( -300 , 0 ));
                DateTime reglementAttendu = emission.AddDays(rng.Next( 0 , 80 ));
                double du = rng.Next(100, 2000) + Math.Round(rng.NextDouble(), 2);
                double regle;
                if (reglementAttendu < date)
                {
                    regle = du;
                }
                else {
                    regle = rng.Next(0, Convert.ToInt32(du)) + Math.Round(rng.NextDouble(), 2);
                }
            }
        }

        void IBusinessData.Add(Facture facture)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Facture> IBusinessData.GetFactures(DateTime? debut, DateTime? fin)
        {
            throw new NotImplementedException();
        }
    }
}
