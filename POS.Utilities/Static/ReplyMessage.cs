using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Utilities.Static
{
    public class ReplyMessage
    {
        public const string MESSAGE_QUERY = "Consulta Exitosa";
        public const string MESSAGE_QUERY_EMPTY = "No se encontraron registros";
        public const string MESSAGE_SAVE = "Se registro correctamente";
        public const string MESSAGE_UPDATE = "Se actualizo correctamente";
        public const string MESSAGE_DELETE = "Se elimino correctamente";
        public const string MESSAGE_EXIST = "El registro ya existe";
        public const string MESSAGE_ACTIVATE = "El registro ha sido activado";
        public const string MESSAGE_TOKEN = "Token generado correctamente";
        public const string MESSAGE_TOKEN_ERROR = "El usuario y/o contraseña es incorrecta, rectifica";
        public const string MESSAGE_VALIDATE = "Errores de validacion";
        public const string MESSAGE_FAILED = "Operacion Fallida";
        public const string MESSAGE_EXCEPTION = "HUBO UN ERROR INESPERADO PLS COMUNICARSE CON EL ADMIN";
        public const string MESSAGE_GOOGLE_ERROR = "Su cuenta no se encuentra registrada en el sistema";
        public const string MESSAGE_AUTH_TYPE_GOOGLE = "Porfavor ingrese con la opcion de google";
        public const string MESSAGE_AUTH_TYPE = "Su cuenta no se encuentra registrada en el sistema";
    }
}
