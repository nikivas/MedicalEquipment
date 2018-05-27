using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace MedicalComponents.Models
{
    class ExcelController
    {
        public void GenerateModelElementsExample(IEnumerable<object> obj, string header = "Информация о мед оборудовании")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;


            

            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: ___ГБУЗ ОА АМОКБ___";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 22;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 20;

            workSheet.Cells[3, "A"] = "Наименование МО";
            workSheet.Cells[3, "B"] = "Наименование изделия";
            workSheet.Cells[3, "C"] = "Модель";
            workSheet.Cells[3, "D"] = "Программа закупки";
            workSheet.Cells[3, "E"] = "Балансовая стоимость";
            workSheet.Cells[3, "F"] = "Количство(?)";

            int rowIdx = 4;
            //TODO reports

            rowIdx += 2;
            workSheet.Cells[rowIdx, "C"] = "Руководитель: ";
            workSheet.Cells[rowIdx, "D"] = "______________";
            workSheet.Cells[rowIdx, "F"] = "______________";

            rowIdx++;
            workSheet.Cells[rowIdx, "D"] = "ФИО";
            workSheet.Cells[rowIdx, "F"] = "м.п.";




            rowIdx += 2;
            workSheet.Cells[rowIdx, "C"] = "Исполнитель: ";
            workSheet.Cells[rowIdx, "D"] = "______________";
            workSheet.Cells[rowIdx, "F"] = "______________";

            rowIdx++;
            workSheet.Cells[rowIdx, "D"] = "ФИО";
            workSheet.Cells[rowIdx, "F"] = "м.п.";


            //((Excel.CellFormat)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            //((Excel.CellFormat)workSheet.Cells[1, "A"]).Font.Size = 20;

            //((Excel.CellFormat)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            (workSheet.Range[workSheet.Cells[1, "A"], workSheet.Cells[1, "F"]]).Merge();
            (workSheet.Range[workSheet.Cells[2, "A"], workSheet.Cells[2, "F"]]).Merge();


            ((Excel.Range)(workSheet.Columns[1])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[2])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[3])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[4])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[5])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[6])).ColumnWidth = 35;

            app.Visible = true;
        }


        public void GeneratePMExample(IEnumerable<object> obj, string header = "Информация о расходном материале")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;




            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: ___ГБУЗ ОА АМОКБ___";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 22;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 20;

            workSheet.Cells[3, "A"] = "Наименование расходного материала";
            workSheet.Cells[3, "B"] = "На складе: ";
            workSheet.Cells[3, "C"] = "Модель";
            workSheet.Cells[3, "D"] = "Программа закупки";
            workSheet.Cells[3, "E"] = "Балансовая стоимость";
            workSheet.Cells[3, "F"] = "Количство(?)";

            int rowIdx = 4;
            //TODO reports

            rowIdx += 2;
            workSheet.Cells[rowIdx, "C"] = "Руководитель: ";
            workSheet.Cells[rowIdx, "D"] = "______________";
            workSheet.Cells[rowIdx, "F"] = "______________";

            rowIdx++;
            workSheet.Cells[rowIdx, "D"] = "ФИО";
            workSheet.Cells[rowIdx, "F"] = "м.п.";




            rowIdx += 2;
            workSheet.Cells[rowIdx, "C"] = "Исполнитель: ";
            workSheet.Cells[rowIdx, "D"] = "______________";
            workSheet.Cells[rowIdx, "F"] = "______________";

            rowIdx++;
            workSheet.Cells[rowIdx, "D"] = "ФИО";
            workSheet.Cells[rowIdx, "F"] = "м.п.";


            //((Excel.CellFormat)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            //((Excel.CellFormat)workSheet.Cells[1, "A"]).Font.Size = 20;

            //((Excel.CellFormat)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            (workSheet.Range[workSheet.Cells[1, "A"], workSheet.Cells[1, "F"]]).Merge();
            (workSheet.Range[workSheet.Cells[2, "A"], workSheet.Cells[2, "F"]]).Merge();


            ((Excel.Range)(workSheet.Columns[1])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[2])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[3])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[4])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[5])).ColumnWidth = 35;
            ((Excel.Range)(workSheet.Columns[6])).ColumnWidth = 35;

            app.Visible = true;
        }


    }
}
