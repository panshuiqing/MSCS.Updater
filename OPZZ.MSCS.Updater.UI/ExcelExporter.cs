using System.Collections.Generic;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace OPZZ.MSCS.Updater.UI
{
    internal class ExcelExporter
    {
        public static void Export(IEnumerable<SvnPathInfo> files, string outputFile)
        {
            InitializeWorkbook();
            
            ISheet sheet1 = hssfworkbook.GetSheet("修改日志");

            int rowIndex = 0;
            foreach (SvnPathInfo file in files)
            {
                IRow row = sheet1.GetRow(rowIndex + 2);
                if (row == null)
                {
                    row = sheet1.CreateRow(rowIndex + 2);
                }
                
                CreateCell(row, 1).SetCellValue(rowIndex + 1);
                CreateCell(row, 2).SetCellValue(file.Group);
                CreateCell(row, 3).SetCellValue(file.ResolvePath);
                CreateCell(row, 4).SetCellValue(file.Author);
                CreateCell(row, 5).SetCellValue(file.ModifyTime.ToString("yyyy/MM/dd HH:mm"));
                CreateCell(row, 6).SetCellValue(file.Remark);
                rowIndex++;
            }

            WriteToFile(outputFile);
        }

        private static ICell CreateCell(IRow row, int column)
        {
            ICell cell = row.GetCell(column);
            if (cell == null)
            {
                cell = row.CreateCell(column);
            }
            cell.CellStyle.BorderLeft = BorderStyle.Thin;
            cell.CellStyle.BorderRight = BorderStyle.Thin;
            cell.CellStyle.BorderTop = BorderStyle.Thin;
            cell.CellStyle.BorderBottom = BorderStyle.Thin;
            return cell;
        }

        static XSSFWorkbook hssfworkbook;

        static void WriteToFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }

        static void InitializeWorkbook()
        {
            Stream stream = typeof(ExcelExporter).Assembly.GetManifestResourceStream("OPZZ.MSCS.Updater.UI.SvnLog.xlsx");
            hssfworkbook = new XSSFWorkbook(stream);
        }
    }
}
