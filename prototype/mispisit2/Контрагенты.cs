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
    public partial class Контрагенты : Form
    {
        public Контрагенты()
        {
            InitializeComponent();
        }

        private void контрагентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.контрагентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Контрагенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Контрагенты". При необходимости она может быть перемещена или удалена.
            this.контрагентыTableAdapter.Fill(this.mispisitDataSet.Контрагенты);

        }
    }
}
