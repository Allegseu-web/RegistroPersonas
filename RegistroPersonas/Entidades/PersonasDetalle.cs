using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroPersonas.Entidades
{
    public class PersonasDetalle
    {
        //Detalle
        [Key]
        public int ID { get; set; }
        public int PersonaID { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public PersonasDetalle(string nombre, string numero)
        {
            ID = 0;
            Nombre = nombre;
            Numero = numero;
        }
    }
}
