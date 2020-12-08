using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IFacture
    {
        string client { get; set; }
        int numero { get; set; }
        DateTime emission { get; set; }
        DateTime reglementAttendu { get; set; }
        double du { get; set; }
        double regle { get; set; }
    }
}
