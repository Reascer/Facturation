using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }

        decimal CA { get; }

        void Add(Facture facture);

        IEnumerable<Facture> GetFactures(DateTime? debut, DateTime? fin);

    }

}
