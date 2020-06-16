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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void классовыеОрдераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Классовые_ордера form = new Классовые_ордера();
            form.Show();

        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Контрагенты form = new Контрагенты();
            form.Show();
        }

        private void назначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Назначения form = new Назначения();
            form.Show();
        }

        private void платёжныеПорученияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Платёжные_поручения form = new Платёжные_поручения();
            form.Show();
        }

        private void типыОрдеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Типы_ордеров form = new Типы_ордеров();
            form.Show();
        }

        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Физические_лица form = new Физические_лица();
            form.Show();
        }

        private void журналПоступленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Журнал_поступлений_и_платежей form = new Журнал_поступлений_и_платежей();
            form.Show();
        }

        private void поФизЛицамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ордер_физ_лиц form = new Ордер_физ_лиц();
            form.Show();
        }
    }
}
