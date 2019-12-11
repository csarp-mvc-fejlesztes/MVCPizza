using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TobbbformosPizzaAlkalmazasEgyTabla.Repository;
using TobbbformosPizzaAlkalmazasEgyTabla.Model;

namespace _2019TobbformosMvcPizzaEgyTabla
{
    public partial class FormPizzaFutarKft : Form
    {
        private DataTable pizzasDT = new DataTable();
        private Repository repo = new Repository();

        private void buttonBetoltesPizzak_Click(object sender, EventArgs e)
        {
            RepositoryTablePizza rtp = new RepositoryTablePizza();
            repo.setPizzas(rtp.getPizzasFromTable());
            pizzasDT = repo.getPizzaDataTableFromList();
            dataGridViewPizzak.DataSource = pizzasDT;
        }
    }
}
