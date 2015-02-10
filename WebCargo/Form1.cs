using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;


namespace WebCargo
{
    public partial class flowLayoutPanel1 : Form
    {
        public flowLayoutPanel1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void selecionarArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selecionarArquivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ofd1.InitialDirectory = @"C:\";
            ofd1.Filter = "Abrir Arquivos JavaScript (*.js)|*.java";

            DialogResult dialog = this.abrirpasta.ShowDialog();

            if (dialog == System.Windows.Forms.DialogResult.OK)
            {

                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                }
                    }

            
                }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {

                }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {
        

    }

        private void abrirpasta_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)
        {

        }
}
        }
 