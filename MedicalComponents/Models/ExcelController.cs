﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace MedicalComponents.Models
{
    class ExcelController
    {
        public void GenerateModelElementsExample(IEnumerable<Dictionary<string,string>> dic, string header = "Информация о мед оборудовании")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;


            

            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: _____________";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 22;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 20;

            workSheet.Cells[3, "A"] = "Наименование изделия";
            workSheet.Cells[3, "B"] = "Модель";
            //workSheet.Cells[3, "D"] = "Балансовая стоимость";
            //workSheet.Cells[3, "E"] = "Поставщик";

            int rowIdx = 4;
            foreach (var el in dic)
            {
                workSheet.Cells[rowIdx, "A"] = el["Наименование изделия"];
                workSheet.Cells[rowIdx, "B"] = el["Модель"];
                //workSheet.Cells[rowIdx, "D"] = el["Балансовая стоимость"];
                //workSheet.Cells[rowIdx, "E"] = el["Поставщик"];
                rowIdx++;
            }

            
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


        public void GeneratePMExample(IEnumerable<Dictionary<string,string>> dic, string header = "Информация о расходном материале")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;




            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: _____________";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 20;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 16;

            workSheet.Cells[3, "A"] = "Наименование расходного материала";
            workSheet.Cells[3, "B"] = "На складе: ";
            

            int rowIdx = 4;
            foreach (var el in dic)
            {
                workSheet.Cells[rowIdx, "A"] = el["Наименование расходного материала"];
                workSheet.Cells[rowIdx, "B"] = el["На складе: "];
                rowIdx++;
            }

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


        public void GenerateStandart(IEnumerable<Dictionary<string, string>> dic, string header = "Информация о расходном материале")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;




            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: ________________";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 22;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 20;

            workSheet.Cells[3, "A"] = "№ п/п";
            workSheet.Cells[3, "B"] = "Наименование модели";
            workSheet.Cells[3, "C"] = "Требуемое количество по стандарту";
            workSheet.Cells[3, "D"] = "Фактическое количество в отделении";
            workSheet.Cells[3, "E"] = "Необходимое дооснащение";
            workSheet.Cells[3, "F"] = "Отделение";


            int rowIdx = 4;
            foreach (var el in dic)
            {
                workSheet.Cells[rowIdx, "A"] = rowIdx - 3;
                workSheet.Cells[rowIdx, "B"] = el["Наименование модели"];
                workSheet.Cells[rowIdx, "C"] = el["Требуемое количество по стандарту"];
                workSheet.Cells[rowIdx, "D"] = el["Фактическое количество в отделении"];
                workSheet.Cells[rowIdx, "E"] = el["Необходимое дооснащение"];
                workSheet.Cells[rowIdx, "F"] = el["Отделение"];
                rowIdx++;
            }

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

        public void GeneratePLans(IEnumerable<Dictionary<string, string>> dic, string header = "Информация о расходном материале")
        {
            var app = new Excel.Application();

            app.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)app.ActiveSheet;




            workSheet.Cells[1, "A"] = header;
            workSheet.Cells[2, "A"] = "Наименование медицинской организации: ______";
            ((Excel.Range)workSheet.Cells[1, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[1, "A"]).Font.Size = 22;

            ((Excel.Range)workSheet.Cells[2, "A"]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Name = "Times New Roman";
            ((Excel.Range)workSheet.Cells[2, "A"]).Font.Size = 20;

            workSheet.Cells[3, "A"] = "№ п/п";
            workSheet.Cells[3, "B"] = "Наименование ЗИП/РМ";
            workSheet.Cells[3, "C"] = "Дата закупки";
            workSheet.Cells[3, "D"] = "Количество";
            


            int rowIdx = 4;
            foreach (var el in dic)
            {
                workSheet.Cells[rowIdx, "A"] = rowIdx - 3;
                workSheet.Cells[rowIdx, "B"] = el["Наименование ЗИП/РМ"];
                workSheet.Cells[rowIdx, "C"] = el["Дата закупки"];
                workSheet.Cells[rowIdx, "D"] = el["Количество"];
                rowIdx++;
            }

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
