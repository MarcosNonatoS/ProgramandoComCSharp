using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int w = 45;
        int z = 32;
        int y = 16;
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 42;
            int meuInteiro = 10;
            string nome = "Marcos";
            char letra = 'a';
            var dataNascimento = new DateTime(1992, 9, 4);

            bool aprovado = true;
            aprovado = false;

            //x = "Marcos";

            decimal valor = 20.52m;
            float distancia = 20.56f;
            double outraDistancia = 20.56;

            decimal bimestre1 = 5.5m;
            int numero = 11, outroNumero = 12, esseNumero = 25;
            string nomeCancao = "Release";

            string classe = "3D";

            var a = 2;
            var b = 6;
            var c = 10;
            var d = 13;

            resultadoListBox.Items.Add("a =" + a);
            resultadoListBox.Items.Add(string.Concat("b =", b));
            resultadoListBox.Items.Add(string.Format("c ={0}", c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c*d = {c * d}");
            resultadoListBox.Items.Add($"d/a = {d / a}");
            resultadoListBox.Items.Add($"d%a = {d % a}");
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add($"x%a = {x}");
            resultadoListBox.Items.Add($"x/3 = {x / 3}");

            x = x + 5;
            x += 5;

            resultadoListBox.Items.Add("a = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremento");
            resultadoListBox.Items.Add("a = "+a);
            resultadoListBox.Items.Add($"2 + ++a = {2+ ++a}");
            resultadoListBox.Items.Add("a = " + a);

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremento");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add("a = " + a);


        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirVariaveis();

            resultadoListBox.Items.Add($"w<=x = {w <= x}");
            resultadoListBox.Items.Add($"x==z = {x == z}");
            resultadoListBox.Items.Add($"x!=z = {x != z}");
        }

        private void ExibirVariaveis()
        {
            resultadoListBox.Items.Clear();

            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);

            resultadoListBox.Items.Add(new string('-',50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExibirVariaveis();

            resultadoListBox.Items.Add($"w<=x || y==16 = {w <= x || y==16}");
            resultadoListBox.Items.Add($"x==z && x!=z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!y>w = {!(y>w)}");
        }

        private void ternarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2016;

               resultadoListBox.Items.Add($"O ano {ano} é bissexto?{(ano % 4 == 0 ? "Sim":"Não")}.");

               resultadoListBox.Items.Add($"O ano {ano} é bissexto?{(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");

            if (DateTime.IsLeapYear(ano))
            {
                resultadoListBox.Items.Add($"O ano {ano} é bissexto");
            }
            else
            {
                resultadoListBox.Items.Add($"O ano {ano} não é bissexto");
            }
            


        }
    }
}
