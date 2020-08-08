using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EditorRichText
{
    public partial class formEditor : Form
    {
        StringReader leitor = null;

        public formEditor()
        {
            InitializeComponent();
        }
       

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void toolStripOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Selecione o Arquivo";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Images (*.TXT)|*.TXT|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dialogR = this.openFileDialog1.ShowDialog();
            if (dialogR == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader lerArquivo = new StreamReader(fs);
                    
                    lerArquivo.BaseStream.Seek(0, SeekOrigin.Begin);
                   
                    this.rtxtb1.Text = "";
                    string strLine = lerArquivo.ReadLine();
                    while (strLine != null)
                    {
                        this.rtxtb1.Text += strLine + "\n";
                        strLine = lerArquivo.ReadLine();
                    }
                    
                    lerArquivo.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            rtxtb1.Clear();
            rtxtb1.Focus();
        }
        private void toolStripNewFile_Click(object sender, EventArgs e)
        {
            SaveFile();
            rtxtb1.Clear();
            rtxtb1.Focus();
        }
        private void toolStripSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void salvarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(rtxtb1.Text))
            {
                if ((MessageBox.Show("Deseja Salvar o arquivo ?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    try
                    {
                        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.Flush();

                            sw.BaseStream.Seek(0, SeekOrigin.Begin);
                            
                            sw.Write(this.rtxtb1.Text);
                           
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void toolStripCopy_Click_1(object sender, EventArgs e)
        {
            Copy();
        }     
        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Copy();
        }
        private void Copy()
        {
            if (rtxtb1.SelectionLength > 0)
            {
                rtxtb1.Copy();
            }
        }
        private void toolStripPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void Paste()
        {
            rtxtb1.Paste();
        }
        private void toolStripBold_Click(object sender, EventArgs e)
        {
            if (rtxtb1.SelectionFont != null)
            {
                Font Font = rtxtb1.SelectionFont;
                FontStyle novoFomato;
                if (rtxtb1.SelectionFont.Bold == true)
                {
                    novoFomato = FontStyle.Regular;
                }
                else
                {
                    novoFomato = FontStyle.Bold;
                }
                rtxtb1.SelectionFont = new Font(Font.FontFamily, Font.Size, novoFomato);
            }
        }
        private void toolStripItalic_Click(object sender, EventArgs e)
        {
            if (rtxtb1.SelectionFont != null)
            {
                Font Font = rtxtb1.SelectionFont;
                FontStyle novoFomato;
                if (rtxtb1.SelectionFont.Italic == false)
                {
                    novoFomato = FontStyle.Italic;
                }
                else
                {
                    novoFomato = FontStyle.Regular;
                }
                rtxtb1.SelectionFont = new Font(Font.FontFamily, Font.Size, novoFomato);
            }
        }
        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            if (rtxtb1.SelectionFont != null)
            {
                Font Font = rtxtb1.SelectionFont;
                FontStyle novoFomato;
                if (rtxtb1.SelectionFont.Underline == false)
                {
                    novoFomato = FontStyle.Underline;
                }
                else
                {
                    novoFomato = FontStyle.Regular;
                }
                rtxtb1.SelectionFont = new Font(Font.FontFamily, Font.Size, novoFomato);
            }
        }
        private void toolStripFonte_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (rtxtb1.SelectionFont != null)
                {
                    rtxtb1.SelectionFont = fontDialog1.Font;
                }
            }
        }
        private void toolStripAlingLeft_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void toolStripAlingCenter_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Center;   
            
        }
        private void toolStripAlingRight_Click(object sender, EventArgs e)
        {
            rtxtb1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripConfigPrinter_Click(object sender, EventArgs e)
        {
            ConfigPrinter();
        }
        private void configurarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigPrinter();
        }

        private void ConfigPrinter()
        {
            try
            {
                this.printDialog1.Document = this.printDocument1;
                printDialog1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripPrinter_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void Print()
        {
            printDialog1.Document = printDocument1;

            string strTexto = this.rtxtb1.Text;
            leitor = new StringReader(strTexto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizaImpressao();
        }
        private void visualizaImpressao()
        {
            try
            {
                string str = this.rtxtb1.Text;
                leitor = new StringReader(str);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var prn = printPreviewDialog1;
                prn.Document = this.printDocument1;
                prn.Text = "Visualizando a impressão";
                prn.WindowState = FormWindowState.Maximized;
                prn.PrintPreviewControl.Zoom = 1;
                prn.FormBorderStyle = FormBorderStyle.Fixed3D;
                prn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float positionY = 0;
            int counter = 0;

            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;

            if (MargemEsquerda < 5)
            {
                MargemEsquerda = 20;

            }
            if (MargemSuperior < 5)
            {
                MargemSuperior = 20;

            }
            string linha = null;
            Font FonteDeImpressao = this.rtxtb1.Font;
            SolidBrush meupincel = new SolidBrush(Color.Black);
            linhasPag = e.MarginBounds.Height / FonteDeImpressao.GetHeight(e.Graphics);
            linha = leitor.ReadLine();
            while (counter < linhasPag)
            {
                positionY = (MargemSuperior + (counter * FonteDeImpressao.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, FonteDeImpressao, meupincel, MargemEsquerda, positionY, new StringFormat());
                counter += 1;
                linha = leitor.ReadLine();
            }
            if ((linha != null))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            meupincel.Dispose();
        }
        private void toolStripSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void toolStripGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bruno-bento");
        }
    }
}

