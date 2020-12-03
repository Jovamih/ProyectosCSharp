using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileConfigurator
{
    public partial class FramePrincipal : Form
    {
        private bool ArchivoCargado = false;
        public FramePrincipal()
        {
            InitializeComponent();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string pathFile = getPathOfFile();
            if (File.Exists(pathFile))
            {
                txtSetNombre.Text = pathFile;
                searchPropierty(pathFile);
                EnabledCheckBox();
            }
     
        }
        private string getPathOfFile()
        {
            string pathFile = string.Empty;
            using(OpenFileDialog openFileDialog= new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Ficheros txt |*.txt|Ejecutables (*.exe)|*.exe|Todos los archivos(*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.Title = "Seleccione el archivo";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathFile = openFileDialog.FileName;
                }
            }
            return pathFile;
        }
        private void searchPropierty(string path)
        {
            string ext = Path.GetExtension(path);
            // MessageBox.Show("La extension es: " + ext);
            //le asigno un nombre
            txtSetNombre.Text = Path.GetFileName(path);
            lblPathFile.Text = path;
            //obtenemos el ultimo acceso del fichero
            DateTime lastAcces = File.GetLastAccessTime(path);
            //la creacion del fichero
            DateTime creationTime = File.GetCreationTime(path);
            //la ultima modificacion del fichero
            DateTime lastModified = File.GetLastWriteTime(path);
            //El icono del fichero
            //ahora reconocemos los patrones de hora y fecha
            //los patrones de Tiempo de acceso
            dateAcceso.Value = lastAcces.Date;
            timeAcceso.Value = Convert.ToDateTime(lastAcces.TimeOfDay.ToString());


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }


        private void checkEditCreation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditCreation.Checked)
            {
                dateCreation.Enabled = true;
                timeCreation.Enabled = true;
                //habilitamos el boton de Aplicar
                btnAplicar.Enabled = true;
            }
            else
            {
                dateCreation.Enabled = false;
                timeCreation.Enabled = false;
            }
        }

        private void checkEditModification_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditModification.Checked)
            {
                dateModification.Enabled = true;
                timeModification.Enabled = true;
                //habilitamos el boton de aplicar
                btnAplicar.Enabled = true;
            }
            else
            {
                dateModification.Enabled = false;
                timeModification.Enabled = false;
            }
        }

        private void checkEditAcceso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditAcceso.Checked)
            {
                dateAcceso.Enabled = true;
                timeAcceso.Enabled = true;
                //habilitamos el boton de Aplicar
                btnAplicar.Enabled = true;
            }
            else
            {
                dateAcceso.Enabled = false;
                timeAcceso.Enabled = false;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //codigo exitoso
            DialogResult diagResult=MessageBox.Show("Desea aplicar los cambios ? ","Informacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if (diagResult == DialogResult.Yes)
            {
                //ejecutar las operaciones

                //desabilitamos el boton Aplicar nuevamente
                btnAplicar.Enabled = false;
            }
                //caso contrario ya sea por opcion NO o X(EXIT)  
        }

        private void FramePrincipal_Load(object sender, EventArgs e)
        {
            DisabledCheckBox();
        }
        private void DisabledCheckBox()
        {
            checkEditCreation.Enabled = false;
            checkEditModification.Enabled = false;
            checkEditAcceso.Enabled = false;
            //tambien desactivamos el Boton aplicar hasta que no haya un cambio significativo
            btnAplicar.Enabled = false;
        }
        private void EnabledCheckBox()
        {
            checkEditCreation.Enabled = true;
            checkEditModification.Enabled = true;
            checkEditAcceso.Enabled = true;
            
        }


    }
}
