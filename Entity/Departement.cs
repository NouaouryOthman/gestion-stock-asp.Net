using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Departement
    {
        [Key]
        public Int32 Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public ICollection<Employe> Employes { get; set; }
        public string Ville { get; set; }
    }
}
