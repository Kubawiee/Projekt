using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jakieleki_databaseDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'jakieleki_databaseDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.jakieleki_databaseDataSet.Users);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
