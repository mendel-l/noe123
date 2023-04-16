using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noe123
{
    public partial class Form1 : Form
    {
        List<holaCuenta> saldos = new List<holaCuenta>();
        public Form1()
        {
            InitializeComponent();
            // Configurar el DataGridView
            SaldosDataGridView.AutoGenerateColumns = true;
            SaldosDataGridView.DataSource = saldos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            holaCuenta nuevaCuenta = new holaCuenta();
            nuevaCuenta.Nombre = NombreComboBox.Text;
            nuevaCuenta.Tipo = (TipoCuenta)TipoComboBox.SelectedIndex;
            nuevaCuenta.TipoEspecial = (TipoCuentaEspecial)TipoEspecialComboBox.SelectedIndex;

            // Agregar la nueva cuenta a la lista de saldos
            saldos.Add(nuevaCuenta);

            // Actualizar el DataGridView
            SaldosDataGridView.DataSource = null;
            SaldosDataGridView.DataSource = saldos;
        }
    }
}
