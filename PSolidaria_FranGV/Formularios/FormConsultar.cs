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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true
            const string INSTRUCCION = "SELECT * FROM Participantes";
            float SumaEdad = 0;
            float media = 0;
            // Clase
            List<Participantes> ParticipantesList = new List<Participantes>();

            try
            {
                // Asignar lista con el contenido de la base de datos
                ParticipantesList.AddRange(API_BD.ObtenerListaParticipantes(INSTRUCCION));
                // Redactar lista
                for (int indice = 0; indice < ParticipantesList.Count; indice++)
                {
                    // Sumar edades de la bd
                    SumaEdad += ParticipantesList[indice].Edad;
                    listBoxListaParticipantes.Items.Add($"{ParticipantesList[indice].Apellidos}, {ParticipantesList[indice].Nombre} ({ParticipantesList[indice].Edad} Años) - {ParticipantesList[indice].Minutos}:{ParticipantesList[indice].Segundos}");
                }

                // Asignar edad media
                media = SumaEdad / ParticipantesList.Count;
                textBoxEdadMedia.Text = media.ToString();
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


    }
}
