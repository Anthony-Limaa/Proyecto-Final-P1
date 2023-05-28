using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_P1
{
    internal class VehiculoDB 
    {
        public readonly string cadenaconexion = "Data Source=C:\\tmp\\VehiculoDB.db";
        private readonly SQLiteConnection conexion;

        public VehiculoDB()
        {
            conexion = new SQLiteConnection(cadenaconexion);
        }

        public void creartablavehiculo()
        {

            try
            {
                conexion.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Vehiculos (id INTEGER PRIMARY KEY AUTOINCREMENT, marca VARCHAR(20),
                modelo VARCHAR(20), color VARCHAR(20), anio INTEGER, placa VARCHAR(20),
                tipo VARCHAR(20))";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("Tabla Vehiculos creada correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la tabla Vehiculos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void insertarvehiculos(IVehiculo carro)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO Vehiculos (marca, modelo, color, anio, placa, tipo) VALUES (@marca, @modelo, @color, @anio, @placa, @tipo)";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.Parameters.AddWithValue("@marca", carro.marca);
                command.Parameters.AddWithValue("@modelo", carro.modelo);
                command.Parameters.AddWithValue("@color", carro.color);
                command.Parameters.AddWithValue("@anio", carro.anio);
                command.Parameters.AddWithValue("@placa", carro.placa);
                command.Parameters.AddWithValue("@tipo", carro.tipo);
                command.ExecuteNonQuery();
                Console.WriteLine("Vehiculo insertado correctamente.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Vehiculo: " + ex.Message);

            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminartablavehiculo()
        {
            try
            {
                conexion.Open();
                string sql = "DROP TABLE IF EXISTS Vehiculos";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("Tabla Vehiculos eliminada correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la tabla Vehiculos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
