using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeErrores
{
    public partial class Principal : Form
    {
        string rutaImagen = ""; //Ruta de imagen

        public Principal()
        {
            InitializeComponent();
        }

        void seleccionarImagen()
        {
            OpenFileDialog opF = new OpenFileDialog();
            try
            {
                if (opF.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = opF.FileName;
                    imagen_PBox.Image = Image.FromFile(rutaImagen);
                }
            }
            catch (Exception ex)
            {
                txtImg.Text = "El archivo no es una imagen: ";
                txtImg.Text += ex.Message.ToString();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtImg.Text = " ";
            seleccionarImagen();
        }
    }
}
