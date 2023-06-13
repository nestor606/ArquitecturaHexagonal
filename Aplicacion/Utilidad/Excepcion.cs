using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Utilidad
{
    public class Excepcion
    {
        public Exception Error(Exception ex, string _Mensaje) {

            string StrMensaje = _Mensaje;

			try
			{

			}
			catch (ArgumentException)
			{
				StrMensaje = StrMensaje + ", Valores Nulos";
			}
			catch (DirectoryNotFoundException)
			{
				StrMensaje = StrMensaje + ", El Directorio no es Valido";
			}
			catch (FormatException)
			{
				StrMensaje = StrMensaje + ", El Formato no es Valido";
			}
			catch (TimeoutException)
			{
				StrMensaje = StrMensaje + ", El Intervalo de Tiempo Asignado a una Operacioon ha Expirido";
			}
			catch (AuthenticationException)
			{
				StrMensaje = StrMensaje + ", Es Necesario Autenticarte ";
			}
			catch(ValidationException) {
				StrMensaje = StrMensaje + ", Error de Validacion";
			}
			StrMensaje = StrMensaje + ", Detalle del Error: " + ex.Message;

			throw new Exception(StrMensaje);
        }
    }
}
