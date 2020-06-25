using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraPrinting;
using Microsoft.Office.Interop.Excel;
using Route.MilkWorkDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Route.MilkWorkDataSet;
using Excel = Microsoft.Office.Interop.Excel;

namespace Route.Helpers
{
    class ShopRequestReporter
    {
        public Task Report(ShopRequestViewDataTable shopRequestTable)
        {
            return Task.Run(() => BuildReport(shopRequestTable));
        }

        private void BuildReport(ShopRequestViewDataTable shopRequestTable)
        {
            int currentExcelRow;

            Excel.Application application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;//Количество листов в книге
            application.Workbooks.Add(Type.Missing);//Добавление новой книги

            PrintHeader(application);

            PrintBody(application, shopRequestTable, out currentExcelRow);

            FormatTable(application, currentExcelRow);

            application.Visible = true;//Отображение приложения
        }

        private void FormatTable(Application application, int currentExcelRow)
        {
           
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:G{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:F{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Columns["A:G"] as Excel.Range).AutoFit();

            application.Range[$"A1:G1"].Style = "акцент1";
            application.Range[$"A1:G1"].Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;

            application.Range[$"A2:G{currentExcelRow}"].Style = "40% — акцент1";
        }

        private void PrintBody(Application application, ShopRequestViewDataTable shopRequestTable, out int currentExcelRow)
        {
            currentExcelRow = 2;

            foreach(ShopRequestViewRow row in shopRequestTable.Rows)
            {
                PrintShopRequest(application,ref currentExcelRow, row);
            }
        }

        private void PrintShopRequest(Application application, ref int currentExcelRow, ShopRequestViewRow row)
        {
            SetCellValue(application.Range[$"A{currentExcelRow}"], row.Shop_name);
            CenteredCellValue(application.Range[$"A{currentExcelRow}"]);

            SetCellValue(application.Range[$"B{currentExcelRow}"], row.Address);
            CenteredCellValue(application.Range[$"B{currentExcelRow}"]);

            SetCellValue(application.Range[$"C{currentExcelRow}"], row.Date_of_request.ToShortDateString());
            CenteredCellValue(application.Range[$"C{currentExcelRow}"]);

            RequestStructViewTableAdapter requestStructTA = new RequestStructViewTableAdapter();
            RequestStructViewDataTable requestStructDT = requestStructTA.GetDataByShopRequest(row.Id_shop_request);

            foreach(RequestStructViewRow structRow in requestStructDT.Rows)
            {
                PrintShopRequestStruct(application, ref currentExcelRow, structRow);
            }           
        }

        private void PrintShopRequestStruct(Application application, ref int currentExcelRow, RequestStructViewRow structRow)
        {
            SetCellValue(application.Range[$"D{currentExcelRow}"], structRow.Product_name);
            CenteredCellValue(application.Range[$"D{currentExcelRow}"]);

            SetCellValue(application.Range[$"E{currentExcelRow}"], structRow.Product_type_name);
            CenteredCellValue(application.Range[$"E{currentExcelRow}"]);

            SetCellValue(application.Range[$"F{currentExcelRow}"], structRow.Product_count.ToString()); ;
            CenteredCellValue(application.Range[$"F{currentExcelRow}"]);

            SetCellValue(application.Range[$"G{currentExcelRow}"], structRow.Unit_name);
            CenteredCellValue(application.Range[$"G{currentExcelRow}"]);
           
            currentExcelRow++;
        }

        private void PrintHeader(Excel.Application application)
        {
           
            SetCellValue(application.Range["A1"], "Магазин");
            CenteredCellValue(application.Range["A1"]);

            SetCellValue(application.Range["B1"], "Адрес");
            CenteredCellValue(application.Range["B1"]);

            SetCellValue(application.Range["C1"], "Дата заявки");
            CenteredCellValue(application.Range["C1"]);


            SetCellValue(application.Range["D1"], "Продукт");
            CenteredCellValue(application.Range["D1"]);

            SetCellValue(application.Range["E1"], "Тип");
            CenteredCellValue(application.Range["E1"]);

            SetCellValue(application.Range["F1"], "Количество");
            CenteredCellValue(application.Range["F1"]);

            SetCellValue(application.Range["G1"], "Ед. Изм.");
            CenteredCellValue(application.Range["G1"]);
        }

        private void CenteredCellValue(Range range)
        {
            range.HorizontalAlignment = Excel.Constants.xlCenter;
            range.VerticalAlignment = Excel.Constants.xlCenter;
        }

        private void SetCellValue(Range range, string value)
        {
           range.Value2 = value;
        }
    }
}
