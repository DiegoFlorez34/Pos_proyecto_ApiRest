
using POS.Infraestructure.Commons.Bases.Response;
using POS.Utilities.Static;

namespace POS.Infraestructure.FileExel
{
    public interface IGenerateExel
    {
        MemoryStream GenerateToExel<T>(BaseEntityResponse<T> data, List<TableColumn> columns);



    }
}
