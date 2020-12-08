using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture : IFacture
    {
        public string client;
        public int numero;
        public DateTime emission;
        public DateTime reglementAttendu;
        public double du;
        public double regle;

        public Facture(string _client, int _numero, DateTime _emission, DateTime _reglementAttendu, double _du, double _regle)
        {
            client = _client;
            numero = _numero;
            emission = _emission;
            reglementAttendu = _reglementAttendu;
            du = _du;
            regle = _regle;
        }

        string IFacture.client { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IFacture.numero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IFacture.emission { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IFacture.reglementAttendu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IFacture.du { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IFacture.regle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
