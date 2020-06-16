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
    public partial class Платёжные_поручения : Form
    {
        public Платёжные_поручения()
        {
            InitializeComponent();
        }

        private void платёжные_порученияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.платёжные_порученияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Платёжные_поручения_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Платёжные_поручения". При необходимости она может быть перемещена или удалена.
            this.платёжные_порученияTableAdapter.Fill(this.mispisitDataSet.Платёжные_поручения);

        }
    }
}
