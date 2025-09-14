namespace POS.Utilities.Static
{
    public class ExelColumnNames
    {
        public static List<TableColumn> GetColumns(IEnumerable<(string ColumnName, string PropertyName)> columnsProperties)
        {
            var columns = new List<TableColumn>();
            foreach (var (ColumnName,PropertyName) in columnsProperties)
            {
                var column = new TableColumn()
                {
                    Label= ColumnName,
                    PropertyName=PropertyName
                };
                columns.Add(column);
            }
            return columns;
        }
        #region ColumnsCategories
        public static List<(string ColumnName, string PropertyName)> GetColumnsCategories()
        {
            var columnsProperties = new List<(string ColumnName, string PropertyName)>
            {
                ("Nombre","Name"),
                ("Descripcion", "Description"),
                ("Fecha de creacion","AuditCreateDate"),
                ("Estado","StateCategory")
            };
            return columnsProperties;
        }
        #endregion
        #region ColumnsProviders
        public static List<(string ColumnName, string PropertyName)> GetColumnsProviders()
        {
            var columnsProperties = new List<(string ColumnName, string PropertyName)>
            {
                ("Nombre","Name"),
                ("Email", "Email"),
                ("Tipo De Documento", "DocumentType"),
                ("Numero De Documento", "DocumentNumber"),
                ("Direccion", "Address"),
                ("Telefono", "Phone"),
                ("Fecha de creacion","AuditCreateDate"),
                ("Estado","StateProvider")
            };
            return columnsProperties;
        }
        #endregion 
    }
}
