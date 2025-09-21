using POS.Utilities.Static;

namespace POS.Infraestructure.FileExel
{
    public interface IGenerateExel
    {
        MemoryStream GenerateToExel<T>(IEnumerable<T> data, List<TableColumn> columns);



    }
}
