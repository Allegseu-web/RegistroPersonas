using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegistroPersonas.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaID { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("PersonaID")]
        public virtual List<PersonasDetalle> Detalles { get; set; } = new List<PersonasDetalle>();
    }
}
