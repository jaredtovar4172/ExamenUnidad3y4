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
    public partial class Form1 : Form
    {
        Alumno[] A;
        Alumno x = new Alumno();
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A = new Alumno[30];
            for (int i = 0; i < 30; i++)
            {
                A[i] = new Alumno();
            }
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarDatos(A, cont);
            cont++;
        }

        private void mostrarDatoPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarTodos(A, listView1);
        }

        private void mostrarDatoPorEspecialidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x.MostrarDatosEspecialidad(A, listView1);
        }

        private void mostrarDatosSemestreParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarSemestrePar(A, listView1);
        }
    }
}
