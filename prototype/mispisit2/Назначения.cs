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
    public partial class Назначения : Form
    {
        public Назначения()
        {
            InitializeComponent();
        }

        private void назначенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Назначения_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Назначения". При необходимости она может быть перемещена или удалена.
            this.назначенияTableAdapter.Fill(this.mispisitDataSet.Назначения);

        }
    }
}
