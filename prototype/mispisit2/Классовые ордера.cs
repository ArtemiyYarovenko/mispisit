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
    public partial class Классовые_ордера : Form
    {
        public Классовые_ордера()
        {
            InitializeComponent();
        }

        private void классовые_ордераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.классовые_ордераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mispisitDataSet);

        }

        private void Классовые_ордера_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Типы_ордеров". При необходимости она может быть перемещена или удалена.
            this.типы_ордеровTableAdapter.Fill(this.mispisitDataSet.Типы_ордеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Физические_лица". При необходимости она может быть перемещена или удалена.
            this.физические_лицаTableAdapter.Fill(this.mispisitDataSet.Физические_лица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Контрагенты". При необходимости она может быть перемещена или удалена.
            this.контрагентыTableAdapter.Fill(this.mispisitDataSet.Контрагенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Назначения". При необходимости она может быть перемещена или удалена.
            this.назначенияTableAdapter.Fill(this.mispisitDataSet.Назначения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mispisitDataSet.Классовые_ордера". При необходимости она может быть перемещена или удалена.
            this.классовые_ордераTableAdapter.Fill(this.mispisitDataSet.Классовые_ордера);

        }
    }
}
