using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PROYECTOJUEGOS
{
    public partial class Form1 : Form
    {
        private int totalPoints = 0;

        private string saveDirectory = AppDomain.CurrentDomain.BaseDirectory;
        

        public Form1()
        {
            InitializeComponent();

            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            this.cbgane.CheckedChanged += new System.EventHandler(this.cbgane_CheckedChanged);
            this.cbperdi.CheckedChanged += new System.EventHandler(this.cbperdi_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar el ListView con columnas
            lv1.View = View.Details;
            lv1.Columns.Add("Nombre del Juego", 150, HorizontalAlignment.Left);
            lv1.Columns.Add("Resultado", 100, HorizontalAlignment.Left);
            lv1.Columns.Add("Puntos", 50, HorizontalAlignment.Left);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string gameName = txbjuego.Text;
            bool isWin = cbgane.Checked;
            bool isLose = cbperdi.Checked;

            if (string.IsNullOrWhiteSpace(gameName))
            {
                MessageBox.Show("Por favor, ingrese el nombre del juego.");
                return;
            }

            if (isWin == isLose)
            {
                MessageBox.Show("Por favor, seleccione solo uno: Gané o Perdí.");
                return;
            }

            int points = 0;
            string result = "";

            if (isWin)
            {
                points = 100;
                result = "Ganó";
            }
            else if (isLose)
            {
                points = -20;
                result = "Perdió";
            }

            totalPoints += points;

            // Agregar la información al ListView
            ListViewItem item = new ListViewItem(gameName);
            item.SubItems.Add(result);
            item.SubItems.Add(points.ToString());
            lv1.Items.Add(item);

            // Actualizar el Label con el total de puntos
            lblpuntos.Text = "Total de Puntos: " + totalPoints.ToString();

            // Limpiar los campos después de agregar
            txbjuego.Clear();
            cbgane.Checked = false;
            cbperdi.Checked = false;
        }

        private void cbgane_CheckedChanged(object sender, EventArgs e)
        {
            if (cbgane.Checked)
            {
                cbperdi.Checked = false;
            }
        }

        private void cbperdi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbperdi.Checked)
            {
                cbgane.Checked = false;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(saveDirectory, "base_de_informacion.txt");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (ListViewItem item in lv1.Items)
                    {
                        sw.WriteLine($"{item.Text},{item.SubItems[1].Text},{item.SubItems[2].Text}");
                    }
                    // Guardar la cantidad total de puntos al final del archivo
                    sw.WriteLine($"Total de Puntos,{totalPoints}");
                }
                MessageBox.Show("Lista guardada correctamente en " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }
    }
}
