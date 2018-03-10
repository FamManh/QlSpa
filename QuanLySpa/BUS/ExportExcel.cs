using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.BUS
{
    public class ExportExcel
    {
        public void Export(DataTable dt, string sheetName, string title)
        {
            //Tao cac doi tuong exel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            // tao moi 1 excel workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)(oSheets.get_Item(1));
            oSheet.Name = sheetName;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;
            //rowHead.Interior.ColorIndex = 20;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tao phan dau

            // tao tieu de cot
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Nhân viên";
            cl1.ColumnWidth = 20;
            cl1.Font.Size = 16;


            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tua";
            cl2.ColumnWidth = 20;
            cl2.Font.Size = 16;


            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Thời Gian";
            cl3.ColumnWidth = 20;
            cl3.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tiền Cer";
            cl4.ColumnWidth = 20;
            cl4.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tiền Mặt";
            cl5.ColumnWidth = 20;
            cl5.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Tổng tiền";
            cl6.ColumnWidth = 20;
            cl6.Font.Size = 16;


            //Microsoft.Office.Interop.Excel.Range.rowHead = oSheet.get_Range("A3","")


            //tao mang doi tuong de luu toan bo du lieu
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            // chuye du lieu tu datatable vao mang doi tuong
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            // thiet lap vung dien du lieu
            int rowStart = 4;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int colStart = 1;
            int colEnd = dt.Columns.Count;

            // o bat dau dien du lieu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];

            // o ket thuc dien du lieu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];

            // lay ve vung dien du lieu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // dien du lieu vao vung da thie lap
            range.Value2 = arr;
            // 
        }

        public void ExportNgay(DataTable dt, string sheetName, string title)
        {
            //Tao cac doi tuong exel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            // tao moi 1 excel workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)(oSheets.get_Item(1));
            oSheet.Name = sheetName;


            // tao phan dau
           
            // tao tieu de cot
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "STT";
            cl1.ColumnWidth = 8;
            cl1.Font.Size = 16;


            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Ngày";
            cl2.ColumnWidth = 16;
            cl2.Font.Size = 16;


            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Nhân viên";
            cl3.ColumnWidth = 20;
            cl3.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Dịch vụ";
            cl4.ColumnWidth = 20;
            cl4.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Thời gian";
            cl5.ColumnWidth = 14;
            cl5.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Tiền Cer";
            cl6.ColumnWidth = 20;
            cl6.Font.Size = 16;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tiền Mặt";
            cl7.ColumnWidth = 20;
            cl7.Font.Size = 16;

            // thiet lap mau nen
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;
            //rowHead.Interior.ColorIndex = 20;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Microsoft.Office.Interop.Excel.Range.rowHead = oSheet.get_Range("A3","")


            //tao mang doi tuong de luu toan bo du lieu
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            // chuye du lieu tu datatable vao mang doi tuong
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            // thiet lap vung dien du lieu
            int rowStart = 4;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int colStart = 1;
            int colEnd = dt.Columns.Count;

            //Microsoft.Office.Interop.Excel.Range rowstartt = oSheet.get_Range("A"+rowStart, "G"+rowEnd);

            //rowstartt.Font.Bold = true;
            //rowstartt.Interior.ColorIndex = 35;
            // o bat dau dien du lieu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];

            // o ket thuc dien du lieu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];

            // lay ve vung dien du lieu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // dien du lieu vao vung da thie lap
            range.Value2 = arr;
            // 
        }
    }
}
