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
    public partial class Журнал_поступлений_и_платежей : Form
    {
        public Журнал_поступлений_и_платежей()
        {
            InitializeComponent();
        }

        private void журнал_поступлений_и_платежейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_поступлений_и_платежейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Журнал_поступлений_и_платежей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Журнал_поступлений_и_платежей". При необходимости она может быть перемещена или удалена.
            this.журнал_поступлений_и_платежейTableAdapter.Fill(this.mispisitDataSet.Журнал_поступлений_и_платежей);

        }
    }
}
