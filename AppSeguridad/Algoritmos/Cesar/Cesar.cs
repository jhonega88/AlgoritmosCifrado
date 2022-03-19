using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeguridad.Algoritmos.Cesar
{
    public static class Cesar
    {
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
        public static string cifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        public static string descifrar(string mensaje, int desplazamiento)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                for (int i = 0; i < mensaje.Length; i++)
                {
                    int posCaracter = getPosABC(mensaje[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += mensaje[i];
                    }
                }

            }
            return cifrado;
        }

        static int getPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }


    }
}

