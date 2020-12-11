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
    public partial class Form2 : Form
    {
        public Form2(string nome, string curso, string ano)
        {
            InitializeComponent();
            lbl_nome.Text = nome;
            lbl_curso.Text = curso;
            lbl_ano.Text = ano;
        }
    }
}
