using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
           
          
            ML.Result result = new ML.Result();
            ML.vacio vacio = new ML.vacio();
            result.Objects = new List<object>();
            
            try
            {
                usuario.NombreCompleto = (usuario.NombreCompleto == "") ? vacio.Mensaje += "Ingresa el nombre" : usuario.NombreCompleto;
                usuario.FechaNacimiento = (usuario.FechaNacimiento == "") ? vacio.Mensaje += "Ingresa la fecha de nacimiento " : usuario.FechaNacimiento;
                usuario.CorreoElectronico = (usuario.CorreoElectronico == "") ? vacio.Mensaje += "Ingresa el correoelectronico  " : usuario.CorreoElectronico;

                if (vacio.Mensaje == null)
                {
                    result.Objects.Add(usuario);
                }
                else
                {
                    result.ErrorMessage = vacio.Mensaje;
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
