using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Donos
    {
        public Donos() {
            ListaAnimais = new HashSet<Animais>();
        }
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
