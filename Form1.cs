namespace Parcial_II
{
    using System.IO;

    public partial class Form1 : Form
    {
        ArbolAVL arbolAprobados = new ArbolAVL();
        ArbolBinarioBusqueda arbolReprobados = new ArbolBinarioBusqueda();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarCSV_Click(object sender, EventArgs e)
        {
            string ruta = "Estudiantes_Limpio.csv"; // Debe estar copiado al directorio bin

            if (!File.Exists(ruta))
            {
                MessageBox.Show("Archivo no encontrado.");
                return;
            }

            var lineas = File.ReadAllLines(ruta);

            // Comienza en 1 para omitir el encabezado
            for (int i = 1; i < lineas.Length; i++)
            {
                var datos = lineas[i].Split(',');

                string carnet = datos[0].Trim();
                string nombre = datos[1].Trim();
                string correo = datos[2].Trim();

                // ✅ Total está al final de la línea, sin importar cuántas notas intermedias haya
                int nota = int.Parse(datos[datos.Length - 1].Trim());

                Estudiante estudiante = new Estudiante(carnet, nombre, correo, nota);

                if (nota >= 60)
                    arbolAprobados.insertar(estudiante);
                else
                    arbolReprobados.insertar(estudiante);
            }

            MessageBox.Show("Datos cargados correctamente.");
        }

        private void btnMostrarAprobados_Click(object sender, EventArgs e)
        {
            lstAprobados.Items.Clear();
            string datos = ArbolBinario.inorden(arbolAprobados.raizArbol());
            lstAprobados.Items.AddRange(datos.Split('\n', StringSplitOptions.RemoveEmptyEntries));
        }

        private void btnMostrarReprobados_Click(object sender, EventArgs e)
        {
            lstReprobados.Items.Clear();
            string datos = ArbolBinario.inorden(arbolReprobados.raizArbol());
            lstReprobados.Items.AddRange(datos.Split('\n', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
