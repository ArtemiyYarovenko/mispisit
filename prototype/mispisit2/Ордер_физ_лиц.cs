using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mispisit2
{
    public partial class Ордер_физ_лиц : Form
    {
        public Ордер_физ_лиц()
        {
            InitializeComponent();
        }

        private void Ордер_физ_лиц_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Ордер_физ_лиц". При необходимости она может быть перемещена или удалена.
            this.ордер_физ_лицTableAdapter.Fill(this.mispisitDataSet.Ордер_физ_лиц);

        }
    }
}
