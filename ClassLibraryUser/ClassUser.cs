using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace ClassLibraryUser
{
    public class ClassUser
    {
        //Propriedades
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        private ConnClass _conn = new ConnClass();


        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password) 
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;

        }


        //Metodos // CRUD Read = SelecT

        public DataTable Entrar (string email,string password)//C#

        {
            //Database dt = new DataTable(); ele reserva espaço no banco  && e AND
            var dt = new DataTable(); // só ultiliza espaço quando chamar a função // similar o VACHAR do BD // variavel temporario 
            string sql = "SELECT * FROM Usuario WHERE email=@Email AND senha=@Password"; //igual ao BD // SQL


            try 
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using(SqlCommand cmd = new SqlCommand(sql,cn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                }

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message); // vai mostrar o erro no console
            
            }
            return dt; //tabela de dados preenchida

        }
        //public string Entrar(string email, string password)
        //{
        //  if (email == "teste@gmail.com" && password == "teste123") // utilizar para teste antes de incluir o banco de dados
        //  {
        //      return "Login feito com sucesso.";
        // }
        //  return " E-mail e/ou senha invalidos."; 
        //}

        public string Registrar( string name, string email, string password) 
        {

            return "";

        }
    }
}
