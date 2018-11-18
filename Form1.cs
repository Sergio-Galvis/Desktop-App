using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MonitorDirectory(string path)
        {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.SynchronizingObject = this;
            fileSystemWatcher.Path = path;
            fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Terpel Asistente;
            String Path = @"D:\\Terpel CES\\Sábana de datos\\Datos completos\\Asistente.xml";
            Thread.Sleep(200);
            StreamReader Read = new StreamReader(Path);

            XmlSerializer x = new XmlSerializer(typeof(Terpel));
            Asistente = (Terpel)x.Deserialize(Read);
            Read.Close();

            textBox_CC.Text = Asistente.Asistente.Datos.Identificacion;
            textBox_RazonSocial.Text = Asistente.Asistente.Datos.Razon_social;
            textBox_Identificacion.Text = Asistente.Asistente.Datos.Identificacion;
            textBox_TipoCliente.Text = Asistente.Asistente.Datos.Tipo_cliente;
            textBox_Ejecutivo.Text = Asistente.Asistente.Datos.Nombre_ejecutivo;
            textBox_NroCredito.Text = Asistente.Asistente.Datos.Nro_credito;
            textBox_Contratos.Text = Asistente.Asistente.Datos.Contratos;
            textBox_ActivoSAP.Text = Asistente.Asistente.Datos.Activo_sap;
            textBox_Modalidad.Text = Asistente.Asistente.Datos.Modalidad;
            textBox_Tarjeta.Text = Asistente.Asistente.Datos.Tarjeta;
            comboBox_EstadoVehiculo.SelectedItem = "Diario";
            comboBox_EstadoVehiculo_SelectedIndexChanged(sender, e);

            (sender as FileSystemWatcher).EnableRaisingEvents = false; 
        }
        
        private void panel_AsistenteCES_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Liquidos_Click(object sender, EventArgs e)
        {

        }

        private void button_RBloquear_Click(object sender, EventArgs e)
        {

        }

        private void button_RDesbloquear_Click(object sender, EventArgs e)
        {

        }

        private void button_ConsultaDestinos_Click(object sender, EventArgs e)
        {

        }
        
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            textBox_CC.Text = "10128239";
            textBox_Placa.Text = "OPC003";
            try
            {
                if(textBox_Placa.Text == "")
                {
                    MessageBox.Show("El campo placa está vacío, no se puede realizar la consulta SQL.");
                }
                else
                {
                    Connection_Class Con = new Connection_Class();
                    Con.OpenConection();
                    SqlDataReader dr = Con.DataReader("Select TOP 10 cli_codigosolicitante, cli_strnombre, nombreestacion, ore.* "
                                                        + "From OT_RegistroErroresAprobaciones ore "
                                                        + "Left join CRE_Creditos cc on ore.idcredito = cc.idcredito "
                                                        + "Left join CRM_Cliente c on cc.IdCliente = c.cli_idcliente "
                                                        + "Left join EDS_Estaciones ee on ore.codestacion = ee.idestacion "
                                                        + "Where Nroplaca like '" + textBox_Placa.Text + "' "
                                                        + "And cli_strnombre like '%%' "
                                                        + "And nombreestacion like '%%' "
                                                        + "Order by fecha desc");
                    dr.Read();

                    textBox_EDS.Text = dr["CodEstacion"].ToString();
                    listBox_Notificaciones.Items.Add(dr["Mensaje"].ToString());
                    listBox_Notificaciones.TopIndex = listBox_Notificaciones.Items.Count - 1;
                    Con.CloseConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay conexión con la base de datos.");
            }

            string path = @"D:\\Terpel CES\\Sábana de datos\\Datos completos";
            MonitorDirectory(path);
        }
        
        private void button_Tipificar_Click(object sender, EventArgs e)
        { 

        }
        
        private void button_GVFS_Click(object sender, EventArgs e)
        {

        }

        private void button_GPremios_Click(object sender, EventArgs e)
        {

        }

        private void button_GPuntos_Click(object sender, EventArgs e)
        {

        }

        private void button_ConsultaParametrizacion_Click(object sender, EventArgs e)
        {

        }

        private void panel_Gestion_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button_GCambiar_Click(object sender, EventArgs e)
        {

        }

        private void panel_Consulta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRumbo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_DatosCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Tipificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Gazel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox_Salesforce_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_act_eds form_act = new Form_act_eds();
            form_act.Show();
        }

        private void comboBox_EstadoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Terpel Asistente;
                String Path = @"D:\\Terpel CES\\Sábana de datos\\Datos completos\\Asistente.xml";
                Thread.Sleep(200);
                StreamReader Read = new StreamReader(Path);

                XmlSerializer x = new XmlSerializer(typeof(Terpel));
                Asistente = (Terpel)x.Deserialize(Read);
                Read.Close();

                switch (comboBox_EstadoVehiculo.SelectedItem.ToString())
                {
                    case "Diario":
                        textBox_ViAutorizadas.Text = Asistente.Asistente.Estado.Visitas.Aut.Diarias;
                        textBox_ViBloqueadas.Text = Asistente.Asistente.Estado.Visitas.Blo.Diarias;
                        textBox_ViConsumidas.Text = Asistente.Asistente.Estado.Visitas.Con.Diarias;
                        textBox_ViDisponibles.Text = Asistente.Asistente.Estado.Visitas.Dis.Diarias;
                        textBox_VoAutorizadas.Text = Asistente.Asistente.Estado.Volumen.Aut.Diarias;
                        textBox_VoBloqueadas.Text = Asistente.Asistente.Estado.Volumen.Blo.Diarias;
                        textBox_VoConsumidas.Text = Asistente.Asistente.Estado.Volumen.Con.Diarias;
                        textBox_VoDisponibles.Text = Asistente.Asistente.Estado.Volumen.Dis.Diarias;
                        break;

                    case "Semanal":
                        textBox_ViAutorizadas.Text = Asistente.Asistente.Estado.Visitas.Aut.Semanales;
                        textBox_ViBloqueadas.Text = Asistente.Asistente.Estado.Visitas.Blo.Semanales;
                        textBox_ViConsumidas.Text = Asistente.Asistente.Estado.Visitas.Con.Semanales;
                        textBox_ViDisponibles.Text = Asistente.Asistente.Estado.Visitas.Dis.Semanales;
                        textBox_VoAutorizadas.Text = Asistente.Asistente.Estado.Volumen.Aut.Semanales;
                        textBox_VoBloqueadas.Text = Asistente.Asistente.Estado.Volumen.Blo.Semanales;
                        textBox_VoConsumidas.Text = Asistente.Asistente.Estado.Volumen.Con.Semanales;
                        textBox_VoDisponibles.Text = Asistente.Asistente.Estado.Volumen.Dis.Semanales;
                        break;

                    case "Quincenal":
                        textBox_ViAutorizadas.Text = Asistente.Asistente.Estado.Visitas.Aut.Quincenales;
                        textBox_ViBloqueadas.Text = Asistente.Asistente.Estado.Visitas.Blo.Quincenales;
                        textBox_ViConsumidas.Text = Asistente.Asistente.Estado.Visitas.Con.Quincenales;
                        textBox_ViDisponibles.Text = Asistente.Asistente.Estado.Visitas.Dis.Quincenales;
                        textBox_VoAutorizadas.Text = Asistente.Asistente.Estado.Volumen.Aut.Quincenales;
                        textBox_VoBloqueadas.Text = Asistente.Asistente.Estado.Volumen.Blo.Quincenales;
                        textBox_VoConsumidas.Text = Asistente.Asistente.Estado.Volumen.Con.Quincenales;
                        textBox_VoDisponibles.Text = Asistente.Asistente.Estado.Volumen.Dis.Quincenales;
                        break;

                    case "Mensual":
                        textBox_ViAutorizadas.Text = Asistente.Asistente.Estado.Visitas.Aut.Mensuales;
                        textBox_ViBloqueadas.Text = Asistente.Asistente.Estado.Visitas.Blo.Mensuales;
                        textBox_ViConsumidas.Text = Asistente.Asistente.Estado.Visitas.Con.Mensuales;
                        textBox_ViDisponibles.Text = Asistente.Asistente.Estado.Visitas.Dis.Mensuales;
                        textBox_VoAutorizadas.Text = Asistente.Asistente.Estado.Volumen.Aut.Mensuales;
                        textBox_VoBloqueadas.Text = Asistente.Asistente.Estado.Volumen.Blo.Mensuales;
                        textBox_VoConsumidas.Text = Asistente.Asistente.Estado.Volumen.Con.Mensuales;
                        textBox_VoDisponibles.Text = Asistente.Asistente.Estado.Volumen.Dis.Mensuales;
                        break;
                }
            } catch(Exception)
            {
                MessageBox.Show("El archivo XML no contiene ningún dato para la búsqueda.");
            }
        }
    }
}