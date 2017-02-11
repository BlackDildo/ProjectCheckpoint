using ProjectCheckpoint.Models;
using System;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Reports
{
    public class ExcelReport
    {
        public void Create(IQueryable<Student> entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            InternalCreate(entity);
        }

        private void InternalCreate(IQueryable<Student> entity)
        {
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells[1, 1] = "ABC";
            workSheet.Cells[1, 2] = "CDE";

            int row = 1;
            
            foreach (var student in entity)
            {
                row++;
                //workSheet.Cells[row, a] = student
            }

            excelApp.Visible = true;
        }
    }
}
