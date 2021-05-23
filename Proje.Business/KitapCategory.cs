using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class KitapCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Proje.DataAccess.category> Listele()
        {
            Proje.DataAccess.WebProjesiEntities ent = new DataAccess.WebProjesiEntities();
            var sonuc = ent.category.ToList();
            return sonuc; 
        }

    }
}
