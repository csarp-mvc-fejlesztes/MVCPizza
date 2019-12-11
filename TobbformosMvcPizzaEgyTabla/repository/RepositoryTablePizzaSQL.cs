using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TobbbformosPizzaAlkalmazasEgyTabla.Model;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace TobbbformosPizzaAlkalmazasEgyTabla.Repository
{
    partial class RepositoryTablePizza
    {             
        public List<Pizza> getPizzasFromTable()
        {
            List<Pizza> pizzas = new List<Pizza>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Pizza.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["pnev"].ToString();
                    bool goodResult = false;
                    int id = -1;
                    goodResult =int.TryParse(dr["pazon"].ToString(),out id);
                    if (goodResult)
                    {
                        int price = -1;
                        goodResult = int.TryParse(dr["par"].ToString(), out price);
                        if (goodResult)
                        {
                            Pizza p = new Pizza(id, name, price);
                            pizzas.Add(p);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Pizzaadatok beolvasása az adatbázisból nem sikerült!");
            }
            return pizzas;
        }       
    }
}
