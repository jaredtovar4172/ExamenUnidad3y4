using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;



namespace ExamenUnidad3y4
{
    class Alumno
    {
        public string Matricula;
        public string NombreAlumno;
        public string Especialidad;
        public int Semestre;
        public double Promedio;
        public string matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string nombrealumno
        {
            get { return NombreAlumno; }
            set { NombreAlumno = value; }
        }
        public string especialidad
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }
        public int semestre
        {
            get { return Semestre; }
            set { Semestre = value; }
        }
        public double promedio
        {
            get { return Promedio; }
            set { Promedio = value; }
        }
        public Alumno()
        {
            Matricula = "";
            NombreAlumno = "";
            Especialidad = "";
            Semestre = 0;
            Promedio = 0;
        }
        public Alumno[] AgregarDatos(Alumno[] A, int i)
        {
            DialogBoxCaptura captura = new DialogBoxCaptura();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Matricula = captura.matricula;
                A[i].NombreAlumno = captura.nombre;
                A[i].Especialidad = captura.especialidad;
                A[i].Semestre = int.Parse(captura.semestre);
                A[i].Promedio = double.Parse(captura.promedio);
                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }
        public void MostrarTodos(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (A[i].Semestre != 0)
                {
                    ListViewItem lista = new ListViewItem(A[i].Matricula);
                    lista.SubItems.Add(A[i].NombreAlumno);
                    lista.SubItems.Add(A[i].Especialidad);
                    lista.SubItems.Add(A[i].Semestre.ToString());
                    lista.SubItems.Add(A[i].Promedio.ToString());
                    caja.Items.Add(lista);
                }
            }
        }
        public void MostrarDatosEspecialidad(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            DialogBoxBuscarEspecialidad buscar = new DialogBoxBuscarEspecialidad();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Especialidad.ToUpper() == buscar.especialidad.ToUpper())
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Matricula);
                        lista.SubItems.Add(A[i].NombreAlumno);
                        lista.SubItems.Add(A[i].Especialidad);
                        lista.SubItems.Add(A[i].Semestre.ToString());
                        lista.SubItems.Add(A[i].Promedio.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro en los datos la especialidad del alumno", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void MostrarSemestrePar(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (A[i].Semestre != 0)
                {
                    if (A[i].Semestre % 2 == 0)
                    {
                        ListViewItem lista = new ListViewItem(A[i].Matricula);
                        lista.SubItems.Add(A[i].NombreAlumno);
                        lista.SubItems.Add(A[i].Especialidad);
                        lista.SubItems.Add(A[i].Semestre.ToString());
                        lista.SubItems.Add(A[i].Promedio.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
        }
    }
}
