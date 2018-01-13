using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionAvanzada.Login
{
    public partial class UsuarioComun : Form
    {
        public UsuarioComun( string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = "Bienvenido" + nombre;

           
        }

        private void UsuarioComun_Load(object sender, EventArgs e)
        {

        }
    }
}
