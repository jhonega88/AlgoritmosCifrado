using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppSeguridad.Algoritmos.MonoAlfabetico
{
    public class MonoAlfabetico
    {
        static string _abc = "abcdefghijklmnñopqrstuvwxyz";
        public static string cifrar(string mensaje, string clave)
        {
            var lTraspuesta = generarAlfabeto(clave);
            var listAbc = _abc.ToCharArray().ToList();

            var textoClaro = mensaje.ToCharArray();
            string cifrado = "";
            for (int i = 0; i < textoClaro.Length; i++)
            {
                var buscar = textoClaro[i].ToString();
                if (!String.IsNullOrWhiteSpace(buscar))
                {
                    int a = listAbc.FindIndex(0, listAbc.Count, buscar.StartsWith);
                    var letra = lTraspuesta[a];
                    cifrado = cifrado + letra;
                }
                else
                    cifrado = cifrado + buscar;
            }

            return cifrado;
        }

        public static string Descifrar(string mensaje, string clave)
        {
            var lTraspuesta = generarAlfabeto(clave);
            var listAbc = _abc.ToCharArray().ToList();

            var textoCifrado = mensaje.ToCharArray();
            string Descifrado = "";
            for (int i = 0; i < textoCifrado.Length; i++)
            {
                var buscar = textoCifrado[i].ToString();
                if (!String.IsNullOrWhiteSpace(buscar))
                {
                    int a = lTraspuesta.FindIndex(0, lTraspuesta.Count, buscar.StartsWith);
                    var letra = listAbc[a];
                    Descifrado = Descifrado + letra;
                }
                else
                    Descifrado = Descifrado + buscar;
            }

            return Descifrado;
        }

        public static string eliminaRepetidos(string _str)
        {
            var list = _str.ToCharArray().ToList().Distinct().ToList();
            _str = "";
            foreach (var item in list)
                _str = _str + item;

            return _str.Trim();
        }

        public static List<string> generarAlfabeto(string clave)
        {
            clave = clave.Trim();
            //Eliminar duplicados de la clave
            clave = eliminaRepetidos(clave);

            var listMsj = clave.ToCharArray().ToList();
            var listAbc = _abc.ToCharArray().ToList();
            var resList = listMsj.Union(listAbc, new CompararListas());

            int count = clave.Length;

            double largo = clave.Length;
            double alto = Math.Ceiling(Convert.ToDouble((27 / largo)));

            string[,] texto = new string[(int)alto, (int)largo];

            int i = 0;
            int j = 0;
            foreach (var item in resList)
            {
                if (j < largo)
                {
                    texto[i, j] = item.ToString();
                    j++;
                }
                else
                {
                    i++;
                    j = 0;
                    texto[i, j] = item.ToString();
                    j++;
                }
            }
            List<string> listTraspuesta = new List<string>();
            for (i = 0; i < largo; i++)
            {
                for (j = 0; j < alto; j++)
                {
                    if (texto[j, i] != null)
                        listTraspuesta.Add(texto[j, i].ToString());
                    else
                        break;
                }
            }

            return listTraspuesta;
        }

    }

    public class CompararListas : IEqualityComparer<char>
    {
        public bool Equals(char item1, char item2)
        {
            return item1 == item2;
        }

        public int GetHashCode(char item)
        {
            //int hCode = item.Length;
            return item.GetHashCode();
        }
    }
}
