using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSolidaria_FranGV.Modelo_Datos;

namespace PSolidaria_FranGV.API
{
    public static class API_BD
    {


        private const string CONEXION =
            "Data Source=(localdb)\\MSSQLLocalDB; " +
            "Initial Catalog=Competicion; " +   
            "Integrated Security=true";

        // Conexión a la base de datos
        private static SqlConnection ConexionBD()
        {
            SqlConnection conexion = null;

            conexion = new SqlConnection(CONEXION);

            return conexion;
        }

        // Para cargar el DataSet necesitamos 3 recursos:
        // 1. DataSet
        // 2. SqlConnection lo inicializamos haciendo uso del método creado anteriormente
        // 3. SqlDataAdapter necesita inicializarse  la conexión y la instrucción
        // No hay que olvidar que el en puente se usa .Fill, cogiendo por parámetro el DataSet
        // y el nombre de la tabla para rellenar el DataSet
        /// <summary>
        /// Asigna el contenido de la base de datos al dataset
        /// </summary>
        /// <param name="INSTRUCCION"></param>
        /// <returns></returns>
        private static DataSet ObtenerParticipantees(string INSTRUCCION)
        {


            DataSet datos = null;  // Datos de la base de datos

            SqlConnection conexionBaseDatos = null;
            SqlDataAdapter Puente = null;

            // 1. Inicializar Data Set
            datos = new DataSet();

            // 2. Establecer conxión
            conexionBaseDatos = ConexionBD();

            // 3. Hacemos el enlace
            Puente = new SqlDataAdapter(INSTRUCCION, conexionBaseDatos);

            // Cargamos el contendio de la tabla con FILL
            Puente.Fill(datos, "Participantes");

            // NO OLVIDAR CERRAR LA CONEXIÓN ----------------
            conexionBaseDatos.Close();

            return datos;


        }
        // Para pasarlos a array necesitamos:
        // 1. el array del objeto
        // 2. el DataSet inicializado con el método anterior el cual tiene la tabla cargada
        // 3. num de filas
        // 4. DataRow el cual se iguala con el contenido del DataSet
        // y luego igualamos el contenido de las filas con el Array objeto
        /// <summary>
        /// Asigna dataset al objeto
        /// </summary>
        /// <param name="instruccion"></param>
        /// <returns>Lista de participantes</returns>
        public static Participantes[] ObtenerListaParticipantes(string instruccion)
        {
            // Recursos
            Participantes[] ListaParticipantes = null;
            DataSet datosParticipantes = null;
            int numParticipantes = 0;
            DataRow fila = null;

            // Asignamos el dataset
            // No hacemos conexión porque ya lo hicimos en este método
            datosParticipantes = ObtenerParticipantees(instruccion);

            // Obtener num filas tabla Participantes
            numParticipantes = datosParticipantes.Tables["Participantes"].Rows.Count;

            // Array tamaño de Participantes
            ListaParticipantes = new Participantes[numParticipantes];

            // Asignar valor de la tabla a la clase
            for (int indice = 0; indice < ListaParticipantes.Length; indice++)
            {
                int edad;
                int min;
                int seg;
                fila = datosParticipantes.Tables["Participantes"].Rows[indice];
                // Converir string a int
                edad = Convert.ToInt32(fila["Edad"]);
                min = Convert.ToInt32(fila["Minutos"]);
                seg = Convert.ToInt32(fila["Segundos"]);


                ListaParticipantes[indice] = new Participantes((string)fila["Nombre"], (string)fila["Apellidos"], edad, min, seg);



            }
            return ListaParticipantes;

            // Devolver
        }

        // 1. Necesitamos un SqlConnection igualado con el método
        // 2. Necesitamos el SqlCommand instanciado con la conexión y la instrucción
        // Insert, Update, Delete
        /// <summary>
        /// Ejecuta la instrucción que le asignemos
        /// </summary>
        /// <param name="Instruccion">Instrucción, aviso, no consultas</param>
        public static void EjecutarInstruccion(string Instruccion)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;

            try
            {
                conexion = ConexionBD();

                comando = new SqlCommand(Instruccion, conexion);

                // Abrir conexión
                conexion.Open();

                // Ejecución de la instrucción
                comando.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                // NO OLVIDAR CERRAR LA CONEXIÓN ----------------
                conexion.Close();
            }


        }

    }
}
