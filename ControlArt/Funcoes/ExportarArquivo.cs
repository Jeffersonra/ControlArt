using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace ControlArt.Funcoes
{
    class ExportarArquivo
    {
        /// <summary>
        /// Exportar arquivo para .CSV
        /// </summary>
        /// <param name="ds">Tabela com o relatório</param>
        public bool ExportarCSV(System.Data.DataTable dt, string caminho)
        {
            try
            {
                StreamWriter stream = new StreamWriter(caminho, false, Encoding.UTF8);
                StringBuilder linha = new StringBuilder();

                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    linha.Append(dt.Columns[i].ColumnName + ";");
                }
                stream.WriteLine(linha.ToString());

                foreach (DataRow row in dt.Rows)
                {
                    linha = new StringBuilder();

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        linha.Append(row[i].ToString().Trim() + ";");
                    }

                    stream.WriteLine(linha.ToString());
                }

                stream.Flush();
                stream.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }


        /// <summary>
        /// Exportar arquivo para .XLSx
        /// </summary>
        /// <param name="ds">Tabela com o relatório</param>
        public bool ExportarXLS(System.Data.DataTable dt, string caminho)// Retirar do FrmConsulta e incluir na Classe
        {
            try
            {
                int inHeaderLength = 0, inColumn = 0, inRow = 0;
                System.Reflection.Missing Default = System.Reflection.Missing.Value;
                //Create Excel File

                Application excelApp = new Application();
                Workbook excelWorkBook = excelApp.Workbooks.Add(1);

                //Create Excel WorkSheet
                Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count], 1, Default);
                excelWorkSheet.Name = "Relatório";//Name worksheet

                //Write Column Name
                for (int i = 0; i < dt.Columns.Count; i++)
                    excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = dt.Columns[i].ColumnName.ToUpper();

                //Write Rows
                for (int m = 0; m < dt.Rows.Count; m++)
                {
                    for (int n = 0; n < dt.Columns.Count; n++)
                    {
                        inColumn = n + 1;
                        inRow = inHeaderLength + 2 + m;
                        excelWorkSheet.Cells[inRow, inColumn] = dt.Rows[m].ItemArray[n].ToString();
                    }
                }
                //Altera o formato da celula
                excelWorkSheet.get_Range("D2").EntireColumn.NumberFormat = "DD/MM/YYYY";

                //Delete First Page
                excelApp.DisplayAlerts = false;
                Worksheet lastWorkSheet = (Worksheet)excelWorkBook.Worksheets[1];
                lastWorkSheet.Delete();
                excelApp.DisplayAlerts = true;

                excelWorkBook.SaveAs(caminho, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                excelWorkBook.Close();
                excelApp.Quit();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
