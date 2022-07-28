using ExamenPractico.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamenPractico.Controllers
{
    public class UsuarioController
    {
        protected Mutex mutex { get; set; }
        protected static UsuarioController _instance;
        public static UsuarioController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioController();
                return _instance;
            }
        }
        public UsuarioController()
        {
            mutex = new Mutex();
        }
        public async Task<bool> RegistrarUsuario(Usuario _user)
        {
            await Task.Yield();
            using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
            {
                conn.Open();
                try
                {
                    mutex.WaitOne();
                    using (var command = new SqlCommand("INSERT INTO IAUsuario (Nickname, Correo, Contrasena) VALUES(@Nickname, @Correo, @Contrasena)", conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@Nickname", _user.Nickname);
                        command.Parameters.AddWithValue("@Correo", _user.Correo);
                        command.Parameters.AddWithValue("@Contrasena", _user.Contrasena);
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return false;
                }
            }
        }
        public async Task LogIn(Usuario _user)
        {
            await Task.Yield();
            try
            {
                using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
                {
                    mutex.WaitOne();
                    conn.Open();
                    using (var command = new SqlCommand("SELECT * FROM IAUsuario WITH(FORCESEEK) WHERE Correo = @Correo AND Contrasena = @Password", conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@Correo", _user.Correo);
                        command.Parameters.AddWithValue("@Password", _user.Contrasena);
                        var dt = command.ExecuteReader();
                        if (!dt.HasRows) throw new Exception("Sin Registros");
                        while (dt.Read())
                        {
                            Utilities.Utilidades.SetUsuario(int.Parse(dt["IdUsuario"].ToString()));
                        }
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
