using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        public List<Facture> Factures { get; }

        public double getCAMensuelreel(DateTime date)
        {
            double CA = 0;
            foreach (Facture facture in Factures)
            {
                if (facture.reglementAttendu.Month == date.Month && facture.reglementAttendu.Year == date.Year)
                {
                    CA += facture.regle;
                }
            }
            return CA;
        }

        public double getCAMensuelattendu(DateTime date)
        {
            double CA = 0;
            foreach (Facture facture in Factures)
            {
                if (facture.reglementAttendu.Month == date.Month && facture.reglementAttendu.Year == date.Year)
                {
                    CA += facture.du;
                }
            }
            return CA;
        }
    }

}
