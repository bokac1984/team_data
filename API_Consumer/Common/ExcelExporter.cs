using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.Common
{
    public class ExcelExporter
    {
        public ExcelExporter()
        {

        }

        public void CreateExcel<T>(HashSet<T> data) where T : class
        {

        }

        protected void CreateExcelPackage(string fileName, Action<ExcelPackage> creator)
        {
            string filePath = "test.xlsx";

            using (var excelPackage = new ExcelPackage())
            {
                creator(excelPackage);
                File.WriteAllBytes(filePath, excelPackage.GetAsByteArray());
            }
        }

        protected void AddHeader(ExcelWorksheet sheet, params string[] headerTexts)
        {
            if (MyIsNullOrEmpty(headerTexts))
            {
                return;
            }

            for (var i = 0; i < headerTexts.Length; i++)
            {
                AddHeader(sheet, i + 1, headerTexts[i]);
            }
        }

        protected void AddHeader(ExcelWorksheet sheet, int columnIndex, string headerText)
        {
            sheet.Cells[1, columnIndex].Value = headerText;
            sheet.Cells[1, columnIndex].Style.Font.Bold = true;
        }

        //protected void AddObjects<T>(ExcelWorksheet sheet, int startRowIndex, IList<T> items, params Func<T, object>[] propertySelectors)
        //{
        //    if (MyIsNullOrEmpty(items) || MyIsNullOrEmpty(propertySelectors))
        //    {
        //        return;
        //    }

        //    for (var i = 0; i < items.Count; i++)
        //    {
        //        for (var j = 0; j < propertySelectors.Length; j++)
        //        {
        //            sheet.Cells[i + startRowIndex, j + 1].Value = propertySelectors[j](items[i]);
        //        }
        //    }
        //}

        static bool MyIsNullOrEmpty(string[] myStringArray)
        {
            return myStringArray == null || myStringArray.Length < 1;
        }
    }
}
