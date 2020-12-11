using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_InformacaoEntreForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2(txt_Nome.Text, txt_Curso.Text, txt_Ano.Text);
            frm1.Hide();
            frm2.ShowDialog();
        }
    }
}
