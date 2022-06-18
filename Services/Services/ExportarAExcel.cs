//using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace Services.Services
{
    /// <summary>
    /// Esta clase la hice el 25 de mayo, el cumple de la patria del 2022
    /// </summary>
    public class ExportarAExcel
    {
        /// <summary>
        /// hay que setearle el nombre de la grid una vez que se instancia, y el nombre 
        /// del archivo por default que le querramos dar
        /// Tiene el método guardar una vez que se setean estos atributos
        /// </summary>
        public DataGridView grdParam { get; set; }
        public String NombredeArchivoDefault { get; set; }

        /// <summary>
        /// Guarda la grilla en el excel
        /// </summary>
        public void guardar()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.ActiveSheet;

            // Cabeceras
            for (int i = 1; i < grdParam.Columns.Count + 2; i++)
            {
                if (i > 1 && i < grdParam.Columns.Count+1)
                {
                    worksheet.Cells[1, i] = grdParam.Columns[i - 1].HeaderText;
                }
            }

            // Valores
            for (int i = 0; i < grdParam.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grdParam.Columns.Count; j++)
                {
                    if (j > 0 && j < grdParam.Columns.Count )
                    {
                        worksheet.Cells[i + 2, j + 1] = grdParam.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = NombredeArchivoDefault;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }

}
            
