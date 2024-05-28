using PSolidaria_FranGV.API;
using PSolidaria_FranGV.Modelo_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSolidaria_FranGV.Formularios
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        private void CargarListadoParticipantes()
        {
            // Limpiar previamente CB
            comboBoxListaParticipantes.Items.Clear();
            // Recursos
            // Instrucción completa
            const string INSTRUCCION = "SELECT * FROM Participantes";

            // Lista clase
            List<Participantes> ParticipantesList = new List<Participantes>();

            // Asignar lista con el contenido de la base de datos
            ParticipantesList.AddRange(API_BD.ObtenerListaParticipantes(INSTRUCCION));
            // Redactar lista con los datos de la BD
            for (int indice = 0; indice < ParticipantesList.Count; indice++)
            {
                comboBoxListaParticipantes.Items.Add($"{ParticipantesList[indice].Apellidos},{ParticipantesList[indice].Nombre},{ParticipantesList[indice].Edad}");
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true

            // Clase

            try
            {
                // AL CARGAR el formulario se cargarán las marcas
                CargarListadoParticipantes();

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);

            }
        }


        private void comboBoxListaParticipantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTiempoAnterior.Text = "";
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true

            // cadena = apellidos,nombre,edad
            // apellido = apellidos...
            string apellidos = comboBoxListaParticipantes.Text.Split(',')[0];
            string nombre = comboBoxListaParticipantes.Text.Split(',')[1];
            string edad = comboBoxListaParticipantes.Text.Split(',')[2];


            // Consulta la cual capta la información del participante seeleccionado
            string instruccion = $"SELECT * FROM Participantes WHERE Nombre = '{nombre}' AND Apellidos = '{apellidos}' AND Edad = '{edad}'";
            // Clase

            try
            {

                // Lista clase
                List<Participantes> ParticipantesList = new List<Participantes>();

                // Asignar lista con el contenido de la base de datos
                ParticipantesList.AddRange(API_BD.ObtenerListaParticipantes(instruccion));
                // ESCRIBIR los minutos y segundos el usuario seleccionado
                for (int indice = 0; indice < ParticipantesList.Count; indice++)
                {
                    textBoxTiempoAnterior.Text= $"{ParticipantesList[indice].Minutos}:{ParticipantesList[indice].Segundos}";
                }

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
                else
                {
                    // Habilitar objetos
                    buttonUpdate.Enabled = true;
                    textBoxNewSegundos.Enabled = true;
                    textBoxNewMin.Enabled = true;
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true

            // Datos participante
            string apellidos = comboBoxListaParticipantes.Text.Split(',')[0];
            string nombre = comboBoxListaParticipantes.Text.Split(',')[1];
            string edad = comboBoxListaParticipantes.Text.Split(',')[2];

            Participantes participante = null;

            string instruccion1 = "";
            string instruccion2 = "";
            // Clase

            try
            {
                participante = new Participantes(nombre, apellidos, Conversiones.ConvertInt(edad), Conversiones.ConvertInt(textBoxNewMin.Text), Conversiones.ConvertInt(textBoxNewSegundos.Text));

                instruccion1 = $"UPDATE Participantes SET Minutos = {participante.Minutos} WHERE Nombre = '{participante.Nombre}' AND Apellidos = '{participante.Apellidos}' AND Edad = '{participante.Edad}'";
                instruccion2 = $"UPDATE Participantes SET Segundos = {participante.Segundos} WHERE Nombre = '{participante.Nombre}' AND Apellidos = '{participante.Apellidos}' AND Edad = '{participante.Edad}'";


                if (UI.VentanaConfirmacion($"¿Desea actualizar a {participante.Nombre}?") == DialogResult.Yes)
                {
                    API_BD.EjecutarInstruccion(instruccion1);
                    API_BD.EjecutarInstruccion(instruccion2);


                    // Limpiar formulario
                    comboBoxListaParticipantes.Text = "";
                    textBoxNewMin.Text = "";
                    textBoxNewSegundos.Text = "";
                    textBoxTiempoAnterior.Text = "";
                    CargarListadoParticipantes();
                }

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
                else
                {
                    buttonUpdate.Enabled = true;
                    textBoxNewSegundos.Enabled = true;
                    textBoxNewMin.Enabled = true;
                }
                buttonUpdate.Enabled = false;

            }
        }
    }
}
