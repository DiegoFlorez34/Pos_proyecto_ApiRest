using POS.Application.Interfaces;
using POS.Infraestructure.Commons.Bases.Response;
using POS.Infraestructure.FileExel;
using POS.Utilities.Static;

namespace POS.Application.Services
{
    public class GenerateExelApplication : IGenerateExelApplication
    {
        private readonly IGenerateExel _generateExel;
        public GenerateExelApplication(IGenerateExel generateExel)
        {
            _generateExel = generateExel;
        }

        byte[] IGenerateExelApplication.GenerateToExel<T>(BaseEntityResponse<T> data, List<(string ColumnName, string PropertyName)> columns)
        {
            var exelColumns = ExelColumnNames.GetColumns(columns);
            var memoryStreamExel = _generateExel.GenerateToExel(data,exelColumns);
            var filesBytes = memoryStreamExel.ToArray();
            return filesBytes;
        }
    }
}
