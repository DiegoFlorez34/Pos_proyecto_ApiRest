using POS.Infraestructure.Commons.Bases.Response;

namespace POS.Application.Interfaces
{
    public interface IGenerateExelApplication
    {
        byte[] GenerateToExel<T>(BaseEntityResponse<T> data, List<(string ColumnName, string PropertyName)> clumns);



    }
}
