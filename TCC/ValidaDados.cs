using System;
using System.Linq;
class ValidaDados
{
    public bool Numero(string texto)
    {
        bool retorno = true;
        char[] c = texto.ToCharArray();

        for (int i = 0; i < c.Count(); i++)
        {
            if (!char.IsDigit(c[i]))
            {
                retorno = false;
                break;
            }

        }
        return retorno;
    }

    public bool VerificaLetraEspaco(string item)
    {
        return true;
    }

    public bool VerificaLetraNumero(string item)
    {
        return true;
    }
}