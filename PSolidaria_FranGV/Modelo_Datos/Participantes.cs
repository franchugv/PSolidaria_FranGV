using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolidaria_FranGV.Modelo_Datos
{
    public class Participantes
    {

        #region Constantes
        // CONSTANTES
        // Default
        private const int NUM_DEF = 0;
        //  NombreS
        private const int MIN_NAME = 3;
        private const int MAX_NAME = 20;
        // Apellidos
        private const int APELLIDO_MIN = 4;
        private const int APELLIDO_MAX = 50;
        // Edad
        private const int EDAD_MIN = 10;
        private const int EDAD_MAX = 85;
        // Minutos
        private const int MINUTOS_MAX = 50;
        #endregion


        // Miembros
        private string _nombre;
        private string _apellidos;
        private int _edad;

        private int _minutos;
        private int _segundos;

        // CONSTRUCTORES

        // Solo claves primarias,

        public Participantes(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;

            _minutos = NUM_DEF;
            _segundos = NUM_DEF;
        }

        // Todo

        public Participantes(string nombre, string apellidos, int edad, int min, int seg) :this(nombre, apellidos, edad)
        {
            Minutos = min;
            Segundos = seg;
        }


        // PROPIEDADES
        
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = ValidarCadena(value, MIN_NAME, MAX_NAME);
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = ValidarCadena(value, APELLIDO_MIN, APELLIDO_MAX);
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                ValidarEdad(value); 
                _edad = value;
            }
        }

        public int Minutos
        {
            get
            {
                return _minutos;
            }
            set
            {
                ValidarMinutos(value);
                _minutos = value;
            }
        }

        public int Segundos
        {
            get
            {
                return _segundos;
            }
            set
            {
                _segundos = value;  
            }
        }

        // MÉTODOS
        // Validaciones

        private static string ValidarCadena(string Cadena, int MIN, int MAX)
        {
            // Quitar espacios y ponerlo a mayúsculas
            Cadena = Cadena.ToUpper().Trim();

            // Validar que no sea cadena vacía
            if (string.IsNullOrEmpty(Cadena)) throw new CadenaVaciaException();

            if (Cadena.Length < MIN) throw new RangoMinException();
            if (Cadena.Length > MAX) throw new RangoMaxException();

            // Validar que no conenga caracteres especiales ni números
            foreach(char caracter in Cadena)
            {
                if (char.IsDigit(caracter)) throw new Exception("Formato incorrcto");
            }

            return Cadena;

        }

        private static void ValidarEdad(int num)
        {
            if (num < EDAD_MIN) throw new RangoMinException($"Edad inferior a {EDAD_MIN}");
            if (num > EDAD_MAX) throw new RangoMaxException($"Edad superior a {EDAD_MAX}");

        }

        private static void ValidarMinutos(int min)
        {
            if (min > MINUTOS_MAX) throw new RangoMaxException($"Minutos es superior a {MINUTOS_MAX}");
        }


    }

    public class RangoMaxException : Exception
    {
        public RangoMaxException() :base("Supera el rango máximo de valores permitido") { }
        public RangoMaxException(string message) : base(message) { }
    }

    public class RangoMinException : Exception
    {
        public RangoMinException() : base("Es inferior al rango mínimo de valores permitido") { }
        public RangoMinException(string message) : base(message) { }
    }

    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() : base("Cadena vacía") { }
        public CadenaVaciaException(string message) : base(message) { }
    }




}
