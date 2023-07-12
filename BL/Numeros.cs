using ML;

namespace BL
{
    public class Numeros
    {
        public static ML.Result Suma(int numeroUno, int numeroDos)
        {
            ML.Result result = new ML.Result();
            try
            {
                result.Suma = numeroUno + numeroDos;
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