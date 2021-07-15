using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Tache
    {
        [Key]
        public Int32 Id { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public Employe Employe { get; set; }
    }
}
