using ClosedXML.Excel;
using POS.Infraestructure.Commons.Bases.Response;
using POS.Utilities.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infraestructure.FileExel
{
    public class GenerateExel : IGenerateExel
    {
        public MemoryStream GenerateToExel<T>(BaseEntityResponse<T> data, List<TableColumn> columns)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Listado");
            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Cell(1,i+1).Value= columns[i].Label;
            }
            var rowindex = 2;
            foreach (var item in data.Items!)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    var propertyValue = typeof(T).GetProperty(columns[i].PropertyName!)?
                        .GetValue(item)?.ToString();
                    worksheet.Cell(rowindex, i + 1).Value = propertyValue;
                }
                rowindex++;
            }
            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }
    }
}
