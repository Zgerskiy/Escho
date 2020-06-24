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
    class RouteReporter
    {
        public Task Report(RouteDataTable routeTable)
        {
            return Task.Run(() => BuildReport(routeTable));
        }

        private void BuildReport(RouteDataTable routeTable)
        {
            int currentExcelRow;

            Excel.Application application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;//Количество листов в книге
            application.Workbooks.Add(Type.Missing);//Добавление новой книги

            PrintHeader(application);

            PrintBody(application, routeTable, out currentExcelRow);

            FormatTable(application, currentExcelRow);

            application.Visible = true;//Отображение приложения
        }

        private void FormatTable(Application application, int currentExcelRow)
        {
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlThin;
            (application.Range[$"A1:H{currentExcelRow}"] as Excel.Range).Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;

            (application.Columns["A:H"] as Excel.Range).AutoFit();

            application.Range[$"A1:H1"].Style = "акцент1";
            application.Range[$"A1:H1"].Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;

            application.Range[$"A2:H{currentExcelRow}"].Style = "40% — акцент1";
        }

        private void PrintBody(Application application, RouteDataTable routeTable, out int currentExcelRow)
        {
            currentExcelRow = 2;

            foreach(RouteRow row in routeTable.Rows)
            {
                PrintRoute(application,ref currentExcelRow, row);
            }
        }

        private void PrintRoute(Application application, ref int currentExcelRow, RouteRow row)
        {
            SetCellValue(application.Range[$"A{currentExcelRow}"], row.Route_name);
            CenteredCellValue(application.Range[$"A{currentExcelRow}"]);

            SetCellValue(application.Range[$"B{currentExcelRow}"], row.Route_date.ToShortDateString());
            CenteredCellValue(application.Range[$"B{currentExcelRow}"]);

            SetCellValue(application.Range[$"C{currentExcelRow}"], row.FullCar);
            CenteredCellValue(application.Range[$"C{currentExcelRow}"]);

            SetCellValue(application.Range[$"D{currentExcelRow}"], row.Car_type_name);
            CenteredCellValue(application.Range[$"D{currentExcelRow}"]);

            SetCellValue(application.Range[$"E{currentExcelRow}"], row.Route_distance.ToString()); 
            CenteredCellValue(application.Range[$"E{currentExcelRow}"]);

            
            Route_structViewTableAdapter route_StructTA = new Route_structViewTableAdapter();
            Route_structViewDataTable routeStructTable  = route_StructTA.GetDataByRoute(row.Id_route);

            foreach(Route_structViewRow structRow in routeStructTable.Rows)
            {
                PrintRouteStruct(application, ref currentExcelRow, structRow);
            }           
        }

        private void PrintRouteStruct(Application application, ref int currentExcelRow, Route_structViewRow structRow)
        {
            SetCellValue(application.Range[$"F{currentExcelRow}"], structRow.Number.ToString());
            CenteredCellValue(application.Range[$"F{currentExcelRow}"]);

            SetCellValue(application.Range[$"G{currentExcelRow}"], structRow.Shop_name);
            CenteredCellValue(application.Range[$"G{currentExcelRow}"]);

            SetCellValue(application.Range[$"H{currentExcelRow}"], structRow.Address);
            CenteredCellValue(application.Range[$"H{currentExcelRow}"]);
            currentExcelRow++;
        }

        private void PrintHeader(Excel.Application application)
        {
           
            SetCellValue(application.Range["A1"], "Маршрут");
            CenteredCellValue(application.Range["A1"]);

            SetCellValue(application.Range["B1"], "Дата");
            CenteredCellValue(application.Range["B1"]);

            SetCellValue(application.Range["C1"], "Автомобиль");
            CenteredCellValue(application.Range["C1"]);

            SetCellValue(application.Range["D1"], "Тип автомобиля");
            CenteredCellValue(application.Range["D1"]);

            SetCellValue(application.Range["E1"], "Длинна маршрута (км)");
            CenteredCellValue(application.Range["E1"]);

            SetCellValue(application.Range["F1"], "№ п/п");
            CenteredCellValue(application.Range["F1"]);

            SetCellValue(application.Range["G1"], "Название магазина");
            CenteredCellValue(application.Range["G1"]);

            SetCellValue(application.Range["H1"], "Адрес");
            CenteredCellValue(application.Range["H1"]);

        }

        private void CenteredCellValue(Range range)
        {
            range.HorizontalAlignment = Excel.Constants.xlCenter;
            range.Range["A1"].VerticalAlignment = Excel.Constants.xlCenter;
        }

        private void SetCellValue(Range range, string value)
        {
           range.Value2 = value;
        }
    }
}
