using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasExcTP.Medico
{
    public class Medico
    {
        public string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public Medico(string nombre)
        {

            if (nombre.Trim().Length >= 50)
            {


                throw new Exception("El nombre supero el maximo de 50 caracteres");

            }

            if (nombre.Trim().Length < 1)
            {
                throw new Exception("El nombre debe tener al menos un caracter");
            }

            Nombre = nombre;
        }

    }

}

