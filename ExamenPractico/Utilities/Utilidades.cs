using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamenPractico.Utilities
{
    public static class Utilidades
    {
        private const string AesIV256 = @"gw8#gg&!F*dv1glX";
        private const string AesKey256 = @"a&H2pWLZpUdxWbHQeqNf!s2ie7e9d6@Z";
        public static int IdUsuario { get; private set; }
        public static bool ValidarTelefono(this string cadena) => ValidarRegex(@"^[0-9]{7,10}", cadena);
        public static bool ValidarTexto(this string cadena) => ValidarRegex(@"^[a-zA-z\s]+", cadena);
        public static bool ValidarEmail(this string cadena) => ValidarRegex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", cadena);
        public static bool ValidarContrasena(this string cadena) => ValidarRegex(@"^[a-zA-Z0-9]+", cadena);
        private static bool ValidarRegex(string pattern, string cadena)
        {
            try
            {
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(cadena);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
        public static SqlConnection GetConnection(string server, string DB) => ObjetoConexion.getconexion(server, DB);
        public static void SetUsuario(int id) => IdUsuario = id;
        public static int ToInt(this object objecto) => string.IsNullOrEmpty(objecto.ToString()) ? int.Parse(objecto.ToString()) : 0;
        public static DateTime ToDate(this object obj)
        {
            try
            {
                if (obj == null) return DateTime.Now;
                DateTime format;
                DateTime.TryParse(obj.ToString(), out format);
                return format;
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }
        public static string CifrarAES256(this string cadena)
        {
            try
            {
                var IVlength = AesIV256.Length;
                var KEYlength = AesKey256.Length;
                if (string.IsNullOrEmpty(cadena)) throw new ArgumentNullException(nameof(cadena));
                var KEY = Encoding.ASCII.GetBytes(AesKey256);
                var IV = Encoding.ASCII.GetBytes(AesIV256);
                var arrayCadena = Encoding.ASCII.GetBytes(cadena);
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.BlockSize = 128;
                    using (var encrypt = aes.CreateEncryptor(KEY, IV))
                    {
                        byte[] data = encrypt.TransformFinalBlock(arrayCadena, 0, arrayCadena.Length);
                        encrypt.Dispose();
                        return Convert.ToBase64String(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }
        public static string DecifrarAES256(this string cadena)
        {
            try
            {
                if (string.IsNullOrEmpty(cadena)) throw new ArgumentNullException(nameof(cadena));
                var KEY = Encoding.ASCII.GetBytes(AesKey256);
                var IV = Encoding.ASCII.GetBytes(AesIV256);
                var arrayCadena = Convert.FromBase64String(cadena);
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.BlockSize = 128;
                    using (var encrypt = aes.CreateDecryptor(KEY, IV))
                    {
                        byte[] data = encrypt.TransformFinalBlock(arrayCadena, 0, arrayCadena.Length);
                        encrypt.Dispose();
                        return Encoding.UTF8.GetString(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return string.Empty;
            }
        }
    }
}
