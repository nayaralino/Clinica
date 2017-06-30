using System;
using DTO;
using System.Data.SqlClient;
using System.Data;

// Data de revisão 11/02
// Funcionando OK



namespace DAL
{
    public class AnimalDAL
    {

        private ConexaoDAL conexao;

        public AnimalDAL(ConexaoDAL aniDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = aniDalCon;
        }

        public void Incluir(AnimalDTO aniDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbAnimal(ani_nome, ani_sexo, ani_especie, ani_raça, ani_peso, ani_idade, ani_cliente, ani_cadastro, ani_status) values (@ani_nome, @ani_sexo, @ani_especie, @ani_raça, @ani_peso, @ani_idade, @ani_cliente, @ani_cadastro, @ani_status); select @@identity; ";
                cmd.Parameters.AddWithValue("@ani_nome", aniDalCrud.Ani_nome);
                cmd.Parameters.AddWithValue("@ani_sexo", aniDalCrud.Ani_sexo);
                cmd.Parameters.AddWithValue("@ani_especie", aniDalCrud.Ani_especie);
                cmd.Parameters.AddWithValue("@ani_raça", aniDalCrud.Ani_raça);
                cmd.Parameters.AddWithValue("@ani_peso", aniDalCrud.Ani_peso);
                cmd.Parameters.AddWithValue("@ani_idade", aniDalCrud.Ani_idade);
                cmd.Parameters.AddWithValue("@ani_cliente", aniDalCrud.Ani_cliente);
                cmd.Parameters.AddWithValue("@ani_cadastro", aniDalCrud.Ani_cadastro);
                cmd.Parameters.AddWithValue("@ani_status", aniDalCrud.Ani_status);


                conexao.Conectar();

                aniDalCrud.Ani_id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }


        }//incluir

        public void Alterar(AnimalDTO aniDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbAnimal set ani_nome = @ani_nome, ani_sexo = @ani_sexo, ani_especie = @ani_especie, ani_raça = @ani_raça, ani_peso = @ani_peso, ani_idade = @ani_idade, ani_cliente = @ani_cliente, ani_cadastro = @ani_cadastro, ani_status = @ani_status where ani_id = @ani_id;";

                cmd.Parameters.AddWithValue("@ani_id", aniDalCrud.Ani_id);
                cmd.Parameters.AddWithValue("@ani_nome", aniDalCrud.Ani_nome);
                cmd.Parameters.AddWithValue("@ani_sexo", aniDalCrud.Ani_sexo);
                cmd.Parameters.AddWithValue("@ani_especie", aniDalCrud.Ani_especie);
                cmd.Parameters.AddWithValue("@ani_raça", aniDalCrud.Ani_raça);
                cmd.Parameters.AddWithValue("@ani_peso", aniDalCrud.Ani_peso);
                cmd.Parameters.AddWithValue("@ani_idade", aniDalCrud.Ani_idade);
                cmd.Parameters.AddWithValue("@ani_cliente", aniDalCrud.Ani_cliente);
                cmd.Parameters.AddWithValue("@ani_cadastro", aniDalCrud.Ani_cadastro);
                cmd.Parameters.AddWithValue("@ani_status", aniDalCrud.Ani_status);

                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

        }//alterar

        public void Excluir(int ani_id) //tipo + o campo do banco
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "delete from tbAnimal where ani_id = @ani_id;";
                cmd.Parameters.AddWithValue("@ani_id", ani_id);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }//excluir

        public DataTable PesquisarNomeAnimal(String ani_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ani.ani_id, c.cli_nome, ani.ani_nome, s.sex_descriçao, r.raç_especie, r.raç_descriçao, st.sta_descriçao, ani.ani_cadastro from tbAnimal AS ani inner join tbSexo As s on ani.ani_sexo = s.sex_id inner join tbEspecie AS e on ani.ani_especie = e.esp_id inner join tbRaça As r on ani.ani_raça = r.raç_id inner join tbCliente As c on ani.ani_cliente = c.cli_id inner join tbSTAnimal AS st on ani.ani_status = st.sta_id where ani.ani_nome like '%" + ani_nome + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarTodosAnimal() //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ani.ani_id, c.cli_nome, ani.ani_nome, s.sex_descriçao, e.esp_descriçao, r.raç_descriçao, st.sta_descriçao, ani.ani_cadastro from tbAnimal AS ani inner join tbSexo As s on ani.ani_sexo = s.sex_id inner join tbEspecie AS e on ani.ani_especie = e.esp_id inner join tbRaça As r on ani.ani_raça = r.raç_id inner join tbCliente As c on ani.ani_cliente = c.cli_id inner join tbSTAnimal AS st on ani.ani_status = st.sta_id", conexao.StringConexao);
             da.Fill(tabela);
            return tabela;
        }//pesquisar

      
        public AnimalDTO CarregaAnimalDTO(int ani_id) //tipo + o campo do banco
        {
            try
            {
                AnimalDTO ani = new AnimalDTO();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                // OBS aqui a consulta é basica, pq se n for ele n consegue atualizar os dados
                cmd.CommandText = "select * from tbAnimal where ani_id = @ani_id;";
                cmd.Parameters.AddWithValue("@ani_id", ani_id);
                // add p test - se n tiver marcado não mostra na hora de alterar quais os dados anteriores, tanto faz
                cmd.Parameters.AddWithValue("@ani_nome", ani.Ani_nome);
                cmd.Parameters.AddWithValue("@ani_sexo", ani.Ani_sexo);
                cmd.Parameters.AddWithValue("@ani_especie", ani.Ani_especie);
                cmd.Parameters.AddWithValue("@ani_raça", ani.Ani_raça);
                cmd.Parameters.AddWithValue("@ani_peso", ani.Ani_peso);
                cmd.Parameters.AddWithValue("@ani_idade", ani.Ani_idade);
                cmd.Parameters.AddWithValue("@ani_cliente", ani.Ani_cliente);
                cmd.Parameters.AddWithValue("@ani_cadastro", ani.Ani_cadastro);
                cmd.Parameters.AddWithValue("@ani_status", ani.Ani_status);


                conexao.Conectar();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    ani.Ani_id = Convert.ToInt32(registro["ani_id"]);
                    ani.Ani_nome = Convert.ToString(registro["ani_nome"]);
                    ani.Ani_sexo = Convert.ToInt32(registro["ani_sexo"]);
                    ani.Ani_especie = Convert.ToInt32(registro["ani_especie"]);
                    ani.Ani_raça = Convert.ToInt32(registro["ani_raça"]);
                    ani.Ani_peso = Convert.ToString(registro["ani_peso"]);
                    ani.Ani_idade = Convert.ToString(registro["ani_idade"]);
                    ani.Ani_cliente = Convert.ToInt32(registro["ani_cliente"]);
                    ani.Ani_cadastro = Convert.ToDateTime(registro["ani_cadastro"]);
                    ani.Ani_status = Convert.ToInt32(registro["ani_status"]);
                    
                }
                return ani;
            }          
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
                
            }          
       
        }//carrega
        
    }//class

}//namespace