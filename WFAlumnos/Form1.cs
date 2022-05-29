using p1BC13Crud.Entidades;
using p1BC13Crud.Servicios;
using p1BC13Crud.Clases;
using System.Data.SqlClient;

namespace WFAlumnos
{
    public partial class Form1 : Form
    {
        ServicioAlumno srvAlumno = new();
        MdAlumno oAlumno = new();
        



        public Form1()
        {
            InitializeComponent();
        }


        void cargaGrid()
        {
            var resultado = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridViewAlumno.DataSource = resultado;
        }

        private void button1Conexion_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }


        void MapeoDatosFormalio (MdAlumno _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBoxparcial1.Text = Convert.ToString(_alumnos.parcial1);
            textBoxparcial2.Text = Convert.ToString(_alumnos.parcial2);
            textBoxparcial3.Text = Convert.ToString(_alumnos.parcial3);
        }

        void buscaAlumno(string carnet)
        {
            oAlumno = null;
            oAlumno = srvAlumno.ObtenerAlumno(carnet);

            if (oAlumno == null)
            {
                MessageBox.Show("este cuate no esta");
                LimpiarFormulario();
            } else
            {
                MapeoDatosFormalio(oAlumno);
            }

        }

        
        
        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }


        void LimpiarFormulario()
        {
            oAlumno = new();
            MapeoDatosFormalio(oAlumno);
           // MapeoDatosFormalio(new());

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private MdAlumno DatosForumulario()
        {
            MdAlumno _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo = textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = Convert.ToInt32(textBoxparcial1.Text);
            _alumnos.parcial2 = Convert.ToInt32(textBoxparcial2.Text);
            _alumnos.parcial3 = Convert.ToInt32(textBoxparcial3.Text);
            return _alumnos;
        }


        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                oAlumno = DatosForumulario();
                if (oAlumno.parcial1 > 20)
                {
                    ComproNo();
                }
                else if (oAlumno.parcial2 > 20)
                {
                    ComproNo();
                }
                else if (oAlumno.parcial3 > 35)
                {
                    ComproNo();
                }
                int respusta = srvAlumno.crearAlumno(oAlumno);

                if (respusta > 0)
                {
                    MessageBox.Show("Se grabo con exito");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Lo lamento hubo un clavo");
                }


            }
            else
            {
                MessageBox.Show("Debes llenar todos los espacios");
            }
            
            

        }

        

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                oAlumno = DatosForumulario();
                int respuesta = srvAlumno.actualizarAlumno(oAlumno);
                if (respuesta > 0)
                {
                    MessageBox.Show("Se grabo con exito");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("Lo lamento hubo un clavo");
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los espacios");
            }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"c:\tmp2\alumnos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"c:\tmp2\nuevo.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos where seccion='B'", archivo));
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            DialogResult cant = MessageBox.Show("Seguro de eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
            if (cant == DialogResult.Yes)
            {
                oAlumno = DatosForumulario();
                int resp = srvAlumno.ElimAlum(oAlumno);
                if (resp > 0)
                {
                    MessageBox.Show("Datos Eliminados");
                    LimpiarFormulario();
                    cargaGrid();
                }
                else
                {
                    MessageBox.Show("No se ha eliminado ningun dato");
                }

            }
            if(cant== DialogResult.Yes)
            {
                LimpiarFormulario();
                cargaGrid();
            }
            

        }

        

        public void ComproNo()
        {
            MessageBox.Show("Ingrese una nota dentro del rango aceptado");
            LimpiarFormulario();
            oAlumno = DatosForumulario();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}