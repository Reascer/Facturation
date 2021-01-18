using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Facturation.Server.Models
{
    public class FacturationDataSql : IBusinessData, IDisposable
    {
        private SqlConnection cnct;

        public FacturationDataSql(string connString)
        {
            cnct = new SqlConnection(connString);

        }

        public IEnumerable<Facture> Factures =>
              cnct.Query<Facture>("SELECT * FROM Factures");

        decimal IBusinessData.CA => throw new NotImplementedException();

        public void Dispose()
        {
            cnct.Dispose();
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
