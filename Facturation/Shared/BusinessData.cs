using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public List<Facture> Factures = new List<Facture>();

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
                
                DateTime emission = DateTime.Now.AddDays(rng.Next(-80,-20));
                DateTime reglementAttendu = DateTime.Now.AddDays(rng.Next(-20, 40));
                double du = rng.Next(100, 2000) + Math.Round(rng.NextDouble(), 2);
                double regle;
                if (reglementAttendu < date)
                {
                    regle = du;
                }
                else {
                    regle = rng.Next(0, Convert.ToInt32(du)) + Math.Round(rng.NextDouble(), 2);
                }
                Factures.Add(new Facture(client, numero, emission, reglementAttendu, du, regle));
            }
        }
        // Pour le parametre mois, 0 signifie le mois en cours, 1 le mois suivant, -1 le mois precedent
        public double getCAMensuelreel(int Mois)
        {
            DateTime date = DateTime.Now;
            date = date.AddMonths(Mois);
            double CA = 0;
            foreach (Facture facture in Factures)
            {
                if (facture.reglementAttendu.Month == date.Month)
                {
                    CA += facture.regle;
                }
            }
            return CA;
        }

        public double getCAMensuelattendu(int Mois)
        {
            DateTime date = DateTime.Now;
            date = date.AddMonths(Mois);
            double CA = 0;
            foreach (Facture facture in Factures)
            {
                if (facture.reglementAttendu.Month == date.Month)
                {
                    CA += facture.du;
                }
            }
            return CA;
        }

    }
}
