using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidacaoWorkAreas;

namespace ValidacaoWorkAreas.Classes
{
    class Employee
    {
        public void ValidarCampos(int totLinhas, ProgressBar bar, IXLWorksheet w)
        {
            // primeira linha é o cabecalho
            for (int l = 2; l <= totLinhas; l++)
            {
                bar.Step = (int)100 / totLinhas * l;
                bar.PerformStep();

                ValidaCampoObrigatorio('n', "A", l, w, w.Cell($"A{l}").Value.ToString().Length != 18, "CNPJ inválido\nFormato compatível:\n00.000.000/0000-00");
                ValidaCampoObrigatorio('n', "B", l, w, w.Cell($"B{l}").Value.ToString().Length == 0, "Setor obrigatório");
                ValidaCampoObrigatorio('n', "C", l, w, w.Cell($"C{l}").Value.ToString().Length == 0, "Cargo obrigatório");
                ValidaCampoObrigatorio('s', "D", l, w, w.Cell($"D{l}").Value.ToString().Length == 0, "Desc. Atvd. condicional\nVide parametrizador");
                ValidaCampoObrigatorio('n', "E", 1, w, true, "Campo Opcional");
                ValidaCampoObrigatorio('n', "F", l, w, w.Cell($"F{l}").Value.ToString().Length == 0, "Matricula obrigatorio");
                ValidaCampoObrigatorio('n', "G", l, w, w.Cell($"G{l}").Value.ToString().Length == 0, "Informe o nome completo");

            }
        }

        public void ValidaCampoObrigatorio(char parametrizador, string letraColuna, int linha, IXLWorksheet worksheet, bool expressao, string msg)
        {
            if (expressao)
            {
                if (worksheet.Cell($"{letraColuna}{linha}").Comment.Length == 0)
                    worksheet.Cell($"{letraColuna}{linha}").Comment.AddText(msg);

                if (linha == 1)
                {
                    worksheet.Cell($"{letraColuna}{linha}").Style.Fill.BackgroundColor = XLColor.LightYellow;
                }
                else
                {
                    worksheet.Cell($"{letraColuna}{1}").Style.Fill.BackgroundColor = XLColor.Purple;
                    worksheet.Cell($"{letraColuna}{1}").Style.Font.FontColor = XLColor.White;
                    if (Char.ToUpper(parametrizador) == 'N')
                    {
                        worksheet.Cell($"{letraColuna}{linha}").Style.Fill.BackgroundColor = XLColor.CanaryYellow;
                    }
                    else if (Char.ToUpper(parametrizador) == 'S')
                    {
                        worksheet.Cell($"{letraColuna}{linha}").Style.Fill.BackgroundColor = XLColor.WhiteSmoke;
                    }
                }
            }
        }
    }
}
