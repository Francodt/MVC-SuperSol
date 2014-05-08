using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_SuperSol.Repositories
{
    public class RepositoryBase
    {
        protected IDbConnection _db;
        public RepositoryBase()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["SuperSolDB"].ConnectionString);
            _db.Open();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Close();
            }
        }
        ~RepositoryBase()
        {
            Dispose(false);
        }
    }

    }
}
