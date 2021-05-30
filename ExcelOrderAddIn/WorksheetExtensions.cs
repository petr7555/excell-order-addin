﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelOrderAddIn
{
    public static class WorksheetExtensions
    {

        public static int NCols(this Excel.Worksheet worksheet)
        {
            var n = 1;
            while (worksheet.Cells[1, n++].Value2 != null)
            {            }
            return n - 2;
        }

        // Excluding header
        public static int NRows(this Excel.Worksheet worksheet)
        {
            var n = 2;
            while (worksheet.Cells[n++, 1].Value2 != null)
            { }
            return n - 3;
        }

        public static IList<string> GetColumnNames(this Excel.Worksheet worksheet)
        {
            var i = 1;
            object column;
            var result = new List<string>();
            while ((column = worksheet.Cells[1, i++].Value2) != null)
            {
                result.Add(column.ToString());
            }
            return result;
        }
    }
}
