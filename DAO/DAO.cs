using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO
    {
        public KinoEntities mKino;

        public void Load()
        {
            Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

            mKino = new KinoEntities();

            mKino.Set<Film>().ToList();
            mKino.Set<Saal>().ToList();
            mKino.Set<Vorfuehrung>().ToList();
            mKino.Set<Buchung>().ToList();             
        }

        public void Save()
        {
            try
            {
                mKino.SaveChanges();
                Load();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
