using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosasDeAccess
{
    public partial class Form1 : Form
    {
        IDbConnection ConexionBd;
        List<Anime> Animes = new List<Anime>();
        List<Temporada> Temporadas = new List<Temporada>();
        List<Pelicula> Peliculas = new List<Pelicula>();
        List<String> Access = new List<string>();
        List<String> Mysql = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Proyecto Final - copia.mdb";
                ConexionBd = new OleDbConnection(cadenaConexion);
                ConexionBd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnime_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Sentencia", "Sentencia");
            dataGridView1.Columns.Add("Status", "Status");
            IDbCommand comandoAcc = ConexionBd.CreateCommand();
            comandoAcc.CommandText = "Select Distinct * from Anime";
            IDataReader lector = comandoAcc.ExecuteReader();
            while (lector.Read())
            {
                Anime anime = new Anime(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), Int32.Parse(lector.GetValue(4).ToString()), Int32.Parse(lector.GetValue(5).ToString()));
                Animes.Add(anime);
            }
            foreach (Anime animex in Animes)
            {
                String sql = "INSERT INTO Anime (Nombre, Genero, Ruta, Imagen, Temporadas, Capitulos) VALUES ( '" + animex.getNombre() + "', '" + animex.getGenero() + "', '" + animex.getRuta() + "', '" + animex.getImagen() + "', '" + animex.getTemporadas() + "', '" + animex.getCapitulos() + "')";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                    comandoSql.ExecuteNonQuery();
                    dataGridView1.Rows.Add(sql, "OK");
                }
                catch (MySqlException ex)
                {
                    dataGridView1.Rows.Add(ex.Message, "No Ok");
                }
                finally
                {
                    conexionBD.Close();
                }
            }

        }

        private void BtnTemporada_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Sentencia", "Sentencia");
            dataGridView1.Columns.Add("Status", "Status");
            IDbCommand comandoAcc = ConexionBd.CreateCommand();
            comandoAcc.CommandText = "Select * from Temporada";
            IDataReader lector = comandoAcc.ExecuteReader();
            while (lector.Read())
            {
                Temporada temporada = new Temporada(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), Int32.Parse(lector.GetValue(2).ToString()), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), Int32.Parse(lector.GetValue(6).ToString()));
                Temporadas.Add(temporada);
            }
            LblTemporada.Text = "OK";
            lector.Close();
            foreach (Temporada temporadax in Temporadas)
            {
                String sql = "INSERT INTO Temporada (Id, Nombre, Capitulos, Ruta, Op, Anime, Posicion) VALUES ( '" + temporadax.getId() + "', '" + temporadax.getNombre() + "', '" + temporadax.getCapitulos() + "', '" + temporadax.getRuta() + "', '" + temporadax.getOp() + "', '" + temporadax.getAnime() + "', '" + temporadax.getPosicion() + "')";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                    comandoSql.ExecuteNonQuery();
                    dataGridView1.Rows.Add(sql, "OK");
                } catch (MySqlException ex)
                {
                    dataGridView1.Rows.Add(ex.Message, "No Ok");
                } finally
                {
                    conexionBD.Close();
                }
            }
        }

        private void BtnPelicula_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Sentencia", "Sentencia");
            dataGridView1.Columns.Add("Status", "Status");
            IDbCommand comandoAcc = ConexionBd.CreateCommand();
            comandoAcc.CommandText = "Select Distinct * from Pelicula";
            IDataReader lector = comandoAcc.ExecuteReader();
            while (lector.Read())
            {
                Pelicula pelicula = new Pelicula(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), Int32.Parse(lector.GetValue(2).ToString()), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), Int32.Parse(lector.GetValue(5).ToString()));
                Peliculas.Add(pelicula);
            }
            LblPelicula.Text = "OK";
            lector.Close();
            foreach (Pelicula peliculax in Peliculas)
            {
                
                String sql = "INSERT INTO Pelicula (Id, Nombre, Duracion, Ruta, Anime, Posicion) VALUES ( '" + peliculax.getId() + "', '" + peliculax.getNombre() + "', '" + peliculax.getDuracion() + "', '" + peliculax.getRuta() + "', '" + peliculax.getAnime() + "', '" + peliculax.getPosicion() + "')";
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                    comandoSql.ExecuteNonQuery();
                    dataGridView1.Rows.Add(sql, "OK");
                }
                catch (MySqlException ex)
                {
                    dataGridView1.Rows.Add(ex.Message, "No Ok");
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> rutas = new List<string>();
            dataGridView1.Columns.Add("Url", "Url");
            dataGridView1.Columns.Add("Status", "Status");
            String sql = "SELECT Nombre FROM Anime";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                reader = comandoSql.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        rutas.Add("http://flo.no-ip.info/Anime/" + reader.GetValue(0).ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                dataGridView1.Rows.Add(ex.Message, "No Ok");
            }
            finally
            {
                conexionBD.Close();
            }
            foreach (String ruta in rutas)
            {
                String sql2 = "UPDATE Anime SET Ruta = '"+ ruta +"' WHERE(Nombre LIKE '"+ ruta.Substring(28) +"')";
                MySqlConnection conexionBD2 = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comadoSQL = new MySqlCommand(sql2, conexionBD);
                    comadoSQL.ExecuteNonQuery();
                    dataGridView1.Rows.Add(ruta, "Ok");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ruta, ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> rutas = new List<string>();
            dataGridView1.Columns.Add("Url", "Url");
            dataGridView1.Columns.Add("Status", "Status");
            String sql = "SELECT Nombre, Temporadas FROM Anime";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.GetInt32(1);i++)
                        {
                            int BadGyal = i + 1;
                            rutas.Add("http://flo.no-ip.info/Anime/" + reader.GetValue(0).ToString() + "/" + reader.GetValue(0).ToString() + " Temporada " + BadGyal);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                dataGridView1.Rows.Add(ex.Message, "No Ok");
            }
            finally
            {
                conexionBD.Close();
            }
            foreach (String ruta in rutas)
            {
                String sql2 = "UPDATE Temporada SET Ruta = '" + ruta + "' WHERE(Id LIKE '" + contarBarras(ruta) + "')";
                MySqlConnection conexionBD2 = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comadoSQL = new MySqlCommand(sql2, conexionBD);
                    comadoSQL.ExecuteNonQuery();
                    dataGridView1.Rows.Add(ruta, "Ok");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ruta, ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        private String contarBarras(String ruta)
        {
            int i = 0;
            int barras = 0;
            while (barras < 5)
            {
                char caracter = ruta[i];
                if (caracter.Equals('/'))
                {
                    barras++;
                }
                i++;
            }
            return ruta.Substring(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            String sql = "SELECT Id, Anime FROM Temporada";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comadoSQL = new MySqlCommand(sql, conexionBD);
                reader = comadoSQL.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String cadena = reader.GetString(0);
                        if (cadena.Substring(0, cadena.Length - 12) != reader.GetString(1))
                        {
                            dataGridView1.Rows.Add(cadena);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            List<String> rutas = new List<string>();
            dataGridView1.Columns.Add("Url", "Url");
            dataGridView1.Columns.Add("Status", "Status");
            String sql = "SELECT Id FROM Pelicula";
            MySqlDataReader reader = null;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comandoSql = new MySqlCommand(sql, conexionBD);
                reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rutas.Add("http://flo.no-ip.info/Anime/Peliculas/" + reader.GetValue(0).ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                dataGridView1.Rows.Add(ex.Message, "No Ok");
            }
            finally
            {
                conexionBD.Close();
            }
            foreach (String ruta in rutas)
            {
                String sql2 = "UPDATE Pelicula SET Ruta = '" + ruta+ ".mp4" + "' WHERE(Id LIKE '" + ruta.Substring(38) + "')";
                MySqlConnection conexionBD2 = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comadoSQL = new MySqlCommand(sql2, conexionBD);
                    comadoSQL.ExecuteNonQuery();
                    dataGridView1.Rows.Add(ruta, "Ok");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ruta, ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
    }
}
