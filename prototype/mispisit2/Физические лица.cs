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
    public partial class Физические_лица : Form
    {
        public Физические_лица()
        {
            InitializeComponent();
        }

        private void физические_лицаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.физические_лицаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Физические_лица_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Физические_лица". При необходимости она может быть перемещена или удалена.
            this.физические_лицаTableAdapter.Fill(this.mispisitDataSet.Физические_лица);

        }
    }
}
