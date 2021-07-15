using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{
    public class TacheContext : DbContext
    {
        public TacheContext() : base("Data Source=DESKTOP-FFQCV30\\SQLEXPRESS01;Initial Catalog=DbEmploye;Integrated Security=True") { }
        public DbSet<Departement> departements { get; set; }
        public DbSet<Employe> employes { get; set; }
        public DbSet<Tache> taches { get; set; }
    }
}
