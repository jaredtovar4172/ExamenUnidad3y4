using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad3y4
{
    public partial class DialogBoxCaptura : Form
    {
        public DialogBoxCaptura()
        {
            InitializeComponent();
        }
        public string matricula
        {
            get { return (textBox1.Text); }
        }
        public string nombre
        {
            get { return (textBox2.Text); }
        }
        public string especialidad
        {
            get { return (textBox3.Text); }
        }
        public string semestre
        {
            get { return (textBox4.Text); }
        }
        public string promedio
        {
            get { return (textBox5.Text); }
        }
        private void DialogBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }
    }
}
