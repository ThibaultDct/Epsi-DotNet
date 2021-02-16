using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatonsBDD.ORM
{
    public class Categorie
    {
        public int Id { get; set; }

        [Display(Name ="Label")]
        [Required]
        [MaxLength(50)]
        public string Libelle { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public List<Chaton> Chatons { get; } = new List<Chaton>();
    }
}
