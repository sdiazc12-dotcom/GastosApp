using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace GastosApp
{
    public class Program
    {
        private static string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=GastosDB;Integrated Security=True;TrustServerCertificate=True;";
        public static void Main(string[] args)
        {
            List<Gasto> gastos = LeerGastos();

            if (gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados");
                return;
            }

            decimal totalGastado = 0;

            Console.WriteLine("=== LISTA DE GASTOS ===");
            Console.WriteLine($"{"ID",-3} {"Descripción",-25} {"Monto",10}  {"Categoría"}");
            Console.WriteLine(new string('-', 55));

            foreach (Gasto g in gastos)
            {
                Console.WriteLine(g);
                totalGastado += g.Monto;
            }

            Console.WriteLine(new string('-', 55));
            Console.WriteLine($"TOTAL GASTADO: Q {totalGastado:N2}");
        }

        private static List<Gasto> LeerGastos()
        {
            var lista = new List<Gasto>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT Id, Descripcion, Monto, Categoria FROM Gastos";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Gasto
                            {
                                Id = reader.GetInt32(0),
                                Descripcion = reader.GetString(1),
                                Monto = reader.GetDecimal(2),
                                Categoria = reader.GetString(3)
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}