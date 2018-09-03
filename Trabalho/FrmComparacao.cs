using MetodosOrdenacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmComparacao : Form
    {
        public FrmComparacao()
        {
            InitializeComponent();
            Lista = new List<int>();
            o = 100;
        }
        private bool JaGerou { get; set; }
        private bool Ordenado { get; set; }

        private List<int> ListaAuxiliar { get; set; }

        private List<int> Lista { get; set; }

        private void GeraNumeros()
        {
            var r = new Random();

            dataGridView1.ColumnCount = o;

            dataGridView1.RowCount = o;
            for (int i = 0; i < o; i++)
            {
                for (int j = 0; j < o; j++)
                {
                    Lista.Add(r.Next(1, 1000));
                }
            }
            CarregaGrid(Lista);
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GeraNumeros();

            btGerar.Enabled = false;
            JaGerou = true;
            VerificaBloqueiaCalcular();
        }
        private int o { get; set; }
        private void VerificaBloqueiaCalcular()
        {
            if (!JaGerou || Ordenado)
            {
                btnC1.Enabled = false;
                btnC2.Enabled = false;
                btnC3.Enabled = false;
                btnC4.Enabled = false;
            }
            else
            {
                btnC1.Enabled = true;
                btnC2.Enabled = true;
                btnC3.Enabled = true;
                btnC4.Enabled = true;
            }


        }

        private void FrmComparacao_Load(object sender, EventArgs e)
        {
            JaGerou = false;
            btnDesord.Enabled = false;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            SelectSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label1.Text = "Select Sort = " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            QuickSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label3.Text = "Quick Sort = " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            BubbleSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label2.Text = "Bubble Sort = " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Ordenado = true;
            ListaAuxiliar = new List<int>(Lista);
            var t1 = DateTime.Now;
            ShellSort.Sort(ListaAuxiliar);
            var t2 = DateTime.Now;
            label4.Text = "Shell Sort = " + (t2 - t1).Milliseconds.ToString() + " ms";
            CarregaGrid(ListaAuxiliar);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = true;

        }

        private void btnDesord_Click(object sender, EventArgs e)
        {
            Ordenado = false;

            CarregaGrid(Lista);
            VerificaBloqueiaCalcular();
            btnDesord.Enabled = false;

        }

        private void CarregaGrid(List<int> Lista)
        {
            int z = 0;
            for (int i = 0; i < o; i++)
            {
                for (int j = 0; j < o; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Lista[z++];
                }
            }
        }
    }


}

