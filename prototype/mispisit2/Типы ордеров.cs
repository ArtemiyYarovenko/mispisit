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
    public partial class Типы_ордеров : Form
    {
        public Типы_ордеров()
        {
            InitializeComponent();
        }

        private void типы_ордеровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_ордеровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Типы_ордеров_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Типы_ордеров". При необходимости она может быть перемещена или удалена.
            this.типы_ордеровTableAdapter.Fill(this.mispisitDataSet.Типы_ордеров);

        }
    }
}
