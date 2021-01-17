using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        public string client { get; set; }
        public int numero { get; set; }
        public DateTime emission { get; set; }
        public DateTime reglementAttendu { get; set; }
        public double du { get; set; }
        public double regle { get; set; }

        public Facture(string _client, int _numero, DateTime _emission, DateTime _reglementAttendu, double _du, double _regle)
        {
            client = _client;
            numero = _numero;
            emission = _emission;
            reglementAttendu = _reglementAttendu;
            du = _du;
            regle = _regle;
        }
    }
}
