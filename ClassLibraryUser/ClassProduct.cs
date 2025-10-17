using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser
{
    public class ProductClass
    {
        //Propriedades
        private int id_Product { get; set; }

        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private bool Status { get; set; }


        private ConnClass _conn = new ConnClass();

        //Construtor
        public ProductClass(int _id, string _name, string _description, double _price, bool _status)
        {
            this.id_Product = _id;
            this.Name = _name;
            this.Description = _description;
            this.Price = _price;
            this.Status = _status;

        }

        //Métodos CRUD Read = Select -> Pesquisar
        public DataTable ProductSearch(string name, string description)
        {
            //DataTable dt = new DataTable();
            var dt = new DataTable();//var similar VARCHAR variável temporário
            string sql = "SELECT * FROM Product WHERE Name LIKE @Name OR Description LIKE @Description;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", $"%{name}%");
                        cmd.Parameters.AddWithValue("@Description", "%" + description + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            return dt;//tabela de dados
        }


        //Function to Admin
        public bool Registrar()
        {

            string sql = "INSERT INTO Product (name, description, price, status) VALUES (@Name, @Description, @Price, @Status)";
            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status", this.Status);

                        //execução da instrução de transação de dados (DML) 
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }

        }

        public bool Atualizar()
        {
            string sql = "UPDATE Product SET nome=@Name,description=@Description,price=@Price,status=@Status WHERE id_Product=@Id_Product;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id_Product", this.id_Product);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status", this.Status);

                        //execução da instrução de transação de dados (DML) 
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }
        }
        public bool Remover()
        {
            string sql = "DELETE FROM Product WHERE id_Product=@IdProduct;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdProduct", this.id_Product);

                        //execução da instrução de transação de dados (DML) 
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;
            }
        }
    }
}
