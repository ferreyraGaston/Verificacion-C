using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivParcial2
{
    public class Persona
    {
         #region Atributos
        /***************DEFINO LOS ATRIBUTOS*******************/

        //agrego el modificador de acceso private para respetar el 
        //encapsulamiento de los objetos
        private string nombre;
        private long dni;
        private int edad;

        #endregion

        #region Propiedades
        /***************DEFINO LAS PROPIEDADES*******************/

        // para poder acceder desde otra clase, necesito crear propiedades
        // para extraer las variables de tipo private
        // esta propiedad sirve para manupular el codigo
        public string p_nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public long p_dni
        {
            set { this.dni = value; }
            get { return this.dni; }
        }

        // El stock no se va  a modificar desde afuera, lo va a hacer
        // desde los metodos que estan dentro de la clase
        public int p_edad
        {
            set { this.edad = value; }
            get { return edad; }

        }



        #endregion

        #region Constructor
        /**********DEFINO EL CONSTRUCTOR POR DEFECTO**********/
        // por lo general son publicos y llevan el nombre de la clase

        public Persona()
        {
        }

        /**********DEFINO EL CONSTRUCTOR**********/
        // los contructor sirve para inicializar los objetos

        public Persona(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;

        }

        public Persona(int edad)
        {
            this.edad = edad;
        }
        #endregion

        #region Metodos
        /**********CREO UN METODO INGRESO**********/
        public string CalcularEdad()
        {
            return "Tengo " + this.edad.ToString() + " Años...";
        }
        #endregion

    }
}
