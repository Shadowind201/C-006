using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, mundo. Projeto no Visual Studio!");
            MessageBox.Show("A execução acabou. Bate enter para terminar...");
            Close();
        }
    }
}
