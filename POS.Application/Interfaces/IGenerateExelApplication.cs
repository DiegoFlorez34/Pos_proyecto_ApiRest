

namespace POS.Application.Interfaces
{
    public interface IGenerateExelApplication
    {
        byte[] GenerateToExel<T>(IEnumerable<T> data, List<(string ColumnName, string PropertyName)> clumns);



    }
}
