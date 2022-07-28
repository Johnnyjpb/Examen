using ExamenPractico.Models;
using ExamenPractico.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPractico.Controllers
{
    public class ContactoController
    {
        protected Mutex mutex { get; set; }
        protected static ContactoController _instance;
        public static ContactoController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContactoController();
                return _instance;
            }
        }
        public ContactoController()
        {
            mutex = new Mutex();
        }
        public async Task GuardarContacto(Contacto contacto)
        {
            await Task.Yield();
            try
            {
                if (!contacto.Nombre.ValidarTexto() || !contacto.Telefono.ValidarTelefono()) throw new Exception("Verificar Datos");
                using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
                {
                    conn.Open();
                    mutex.WaitOne();
                    if (await ExisteContacto(contacto.IdConctacto))
                    {
                        using (var command = new SqlCommand("UPDATE IAContacto WITH(ROWLOCK) SET Nombre = @Nombre, Telefono = @Telefono WHERE IdConctacto = @IdConctacto", conn))
                        {
                            command.CommandType = System.Data.CommandType.Text;
                            command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                            command.Parameters.AddWithValue("@Nombre", contacto.Nombre.ToUpper());
                            command.Parameters.AddWithValue("@IdConctacto", contacto.IdConctacto);
                            var resultado = command.ExecuteNonQuery();
                            if (resultado == 1)
                            {
                                MessageBox.Show($"El usuario {contacto.Nombre} se actualizo correctamente", "Exito !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        using (var command = new SqlCommand("INSERT INTO IAContacto (Telefono, Nombre, IdUsuario) VALUES(@Telefono, @Nombre, @IdUsuario)", conn))
                        {
                            command.CommandType = System.Data.CommandType.Text;
                            command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                            command.Parameters.AddWithValue("@Nombre", contacto.Nombre.ToUpper());
                            command.Parameters.AddWithValue("@IdUsuario", Utilities.Utilidades.IdUsuario);
                            var resultado = command.ExecuteNonQuery();
                            if (resultado == 1)
                            {
                                MessageBox.Show($"El usuario {contacto.Nombre} se guardo correctamente", "Exito !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task EliminarContacto(int idContacto)
        {
            await Task.Yield();
            try
            {
                if (idContacto < 1) throw new Exception("No has seleccionado ningun contacto");
                using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
                {
                    conn.Open();
                    mutex.WaitOne();
                    using (var command = new SqlCommand("DELETE FROM IAContacto WITH(ROWLOCK) WHERE IdConctacto = @IdConctacto", conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@IdConctacto", idContacto);
                        var resultado = command.ExecuteNonQuery();
                        if (resultado == 1)
                        {
                            MessageBox.Show($"Se Elimino Correctamente", "Exito !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<Contacto> ObteneContacto(int idContacto)
        {
            await Task.Yield();
            try
            {
                var contacto = new Contacto();
                using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
                {
                    conn.Open();
                    mutex.WaitOne();
                    using (var command = new SqlCommand(@"SELECT * FROM IAContacto WITH(NOLOCK) WHERE IdConctacto = @IdConctacto", conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@IdConctacto", idContacto);
                        var dt = command.ExecuteReader();
                        if (!dt.HasRows) return null;
                        while (dt.Read())
                        {
                            contacto = new Contacto();
                            contacto.IdConctacto = dt["IdConctacto"].ToInt();
                            contacto.Nombre = dt["Nombre"].ToString().ToUpper();
                            contacto.Telefono = dt["Telefono"].ToString();
                            contacto.FechaRegistro = dt["FechaRegistro"].ToDate();
                        }
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                    return contacto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public IEnumerable<Contacto> ObtenerContactos()
        {
            using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
            {
                conn.Open();
                mutex.WaitOne();
                using (var command = new SqlCommand("SELECT * FROM IAContacto WITH(NOLOCK) WHERE IdUsuario = @IdUsuario", conn))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@IdUsuario", Utilities.Utilidades.IdUsuario);
                    var resultado = command.ExecuteReader();
                    if (!resultado.HasRows) yield break;
                    while (resultado.Read())
                    {
                        var contacto = new Contacto()
                        {
                            FechaRegistro = DateTime.Parse(resultado["FechaRegistro"].ToString()),
                            IdConctacto = int.Parse(resultado["IdConctacto"].ToString()),
                            Nombre = resultado["Nombre"].ToString(),
                            Telefono = resultado["Telefono"].ToString()
                        };
                        yield return contacto;
                    }
                }
                conn.Close();
                GC.SuppressFinalize(conn);
                mutex.ReleaseMutex();
            }
        }
        public async Task<bool> ExisteContacto(int id)
        {
            try
            {
                await Task.Yield();
                bool existe = false;
                using (var conn = Utilities.Utilidades.GetConnection("PROSERVER", "INTELISISTMP"))
                {
                    conn.Open();
                    mutex.WaitOne();
                    using (var command = new SqlCommand("SELECT * FROM IAContacto WITH(NOLOCK) WHERE IdConctacto = @IdConctacto", conn))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.AddWithValue("@IdConctacto", id);
                        var resultado = command.ExecuteReader();
                        existe = resultado.HasRows;
                    }
                    conn.Close();
                    GC.SuppressFinalize(conn);
                    mutex.ReleaseMutex();
                }
                return existe;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
