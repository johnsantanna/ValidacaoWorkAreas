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
using ClosedXML.Excel;
using ValidacaoWorkAreas.Classes;

namespace ValidacaoWorkAreas
{
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd { get; set; }
        bool result = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidaWa_Click(object sender, EventArgs e)
        {
            CaixaDialogoSelecionarArquivo();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (result) // openFileDialog1 clicou em OK
                {
                    if (openFileDialog1.FileName.Length == 0)
                    {
                        // openFileDialog1 NAO capturou um arquivo
                        MessageBox.Show("Arquivo não informado!");
                    }
                    else
                    {
                        progressBar1.Show();
                        // openFileDialog1 capturou um arquivo e está criando um objExcel dentro do C#
                        var xls = new XLWorkbook(ofd.FileName);
                        var planilha = xls.Worksheets.First();
                        var totalLinhas = planilha.RowsUsed().Count();
                        var totalColunas = planilha.ColumnsUsed().Count();
                        progressBar1.Minimum = 1;
                        progressBar1.Maximum = totalLinhas;

                        if (!(ValidarLayout(planilha)))
                        {
                            throw new Exception("Layout Incorreto!");
                        }

                        Employee employee = new Employee();
                        employee.ValidarCampos(totalLinhas, progressBar1, planilha);

                        SalvarComo(xls);
                    }
                }
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidarLayout(IXLWorksheet w) 
        {
            int totalColunas = w.ColumnsUsed().Count();
            if (totalColunas != 79)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CaixaDialogoSelecionarArquivo()
        {
            ofd = new OpenFileDialog
            {
                ValidateNames = false,
                Filter = "excel files (*.xlsx)|*.xlsx"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                result = true;
                //label da seleção do arquivo
                openFileDialog1.FileName = ofd.SafeFileName;
                label2.Text = ofd.SafeFileName;
                label2.ForeColor = Color.DarkGreen;
                label2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            }
        }

        public void SalvarComo(XLWorkbook xls)
        {
            // SALVAR COMO
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Salvar um arquivo Excel",
                FileName = $"Log_{DateTime.Now:yyyyMMdd-HHmm}_" + openFileDialog1.SafeFileName
            };
            saveFileDialog.ShowDialog();
            if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                xls.SaveAs(saveFileDialog.FileName);

            openFileDialog1.Reset();
            label2.Text = "Nenhum arquivo selecionado";
            label2.ForeColor = Color.Black;
            label2.Font = new Font(Label.DefaultFont, FontStyle.Regular);
        }
    }
}
