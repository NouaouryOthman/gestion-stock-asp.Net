using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Employe
    {
        [Key]
        public Int32 Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public Departement Departement { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ICollection<Tache> Taches { get; set; }
    }
}
