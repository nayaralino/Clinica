using System;
using DTO;
using System.Data.SqlClient;
using System.Data;

// Data de criação - 12/02
// Data de revisão - 13/02



namespace DAL
{
    public class MedicoDAL
    {
        private ConexaoDAL conexao;

        public MedicoDAL(ConexaoDAL medDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = medDalCon;
        }

        public void Incluir(MedicoDTO medDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbMedico(med_nome, med_crmv, med_especialidade, med_logradouro, med_numero, med_complemento, med_bairro, med_cidade, med_estado)"
                    + "values (@med_nome, @med_crmv, @med_especialidade, @med_logradouro, @med_numero, @med_complemento, @med_bairro, @med_cidade, @med_estado); select @@identity; ";
                cmd.Parameters.AddWithValue("@med_nome", medDalCrud.Med_nome);
                cmd.Parameters.AddWithValue("@med_crmv", medDalCrud.Med_crmv);
                cmd.Parameters.AddWithValue("@med_especialidade", medDalCrud.Med_especialidade);
                cmd.Parameters.AddWithValue("@med_logradouro", medDalCrud.Med_logradouro);
                cmd.Parameters.AddWithValue("@med_numero", medDalCrud.Med_numero);
                cmd.Parameters.AddWithValue("@med_complemento", medDalCrud.Med_complemento);
                cmd.Parameters.AddWithValue("@med_bairro", medDalCrud.Med_bairro);
                cmd.Parameters.AddWithValue("@med_cidade", medDalCrud.Med_cidade);
                cmd.Parameters.AddWithValue("@med_estado", medDalCrud.Med_estado);

                conexao.Conectar();

                medDalCrud.Med_id = Convert.ToInt32(cmd.ExecuteScalar());

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

        public void Alterar(MedicoDTO medDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbMedico set med_nome = @med_nome, med_crmv = @med_crmv, med_logradouro = @med_logradouro, med_numero = @med_numero, med_complemento = @med_complemento, med_bairro = @med_bairro, med_cidade = @med_cidade, med_estado = @med_estado, med_especialidade = @med_especialidade  where med_id = @med_id;";
                cmd.Parameters.AddWithValue("@med_id", medDalCrud.Med_id);
                cmd.Parameters.AddWithValue("@med_nome", medDalCrud.Med_nome);
                cmd.Parameters.AddWithValue("@med_crmv", medDalCrud.Med_crmv);
                cmd.Parameters.AddWithValue("@med_especialidade", medDalCrud.Med_especialidade);
                cmd.Parameters.AddWithValue("@med_logradouro", medDalCrud.Med_logradouro);
                cmd.Parameters.AddWithValue("@med_numero", medDalCrud.Med_numero);
                cmd.Parameters.AddWithValue("@med_complemento", medDalCrud.Med_complemento);
                cmd.Parameters.AddWithValue("@med_bairro", medDalCrud.Med_bairro);
                cmd.Parameters.AddWithValue("@med_cidade", medDalCrud.Med_cidade);
                cmd.Parameters.AddWithValue("@med_estado", medDalCrud.Med_estado);

                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum

                medDalCrud.Med_id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Excluir(int med_id) //tipo + o campo do banco
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "delete from tbMedico where med_id = @med_id;";
                cmd.Parameters.AddWithValue("@med_id", med_id);
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

        public DataTable Pesquisar(String med_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select m.med_id, m.med_nome, m.med_crmv, espec.espec_descriçao, m.med_logradouro, m.med_numero, m.med_complemento, m.med_bairro, c.cid_descriçao, ee.est_descriçao from tbMedico AS m inner join tbCidade AS c on m.med_cidade = c.cid_id inner join tbEstado AS ee on m.med_estado = ee.est_id inner join tbEspecialidade AS espec on m.med_especialidade = espec.espec_id where m.med_nome like '%' + m.med_nome + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public MedicoDTO CarregaMedicoDTO(int med_id) //tipo + o campo do banco
        {
            try
            {
                MedicoDTO med = new MedicoDTO();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                // OBS aqui a consulta é basica, pq se n for ele n consegue atualizar os dados
                cmd.CommandText = "select * from tbMedico where med_id = @med_id;";
                cmd.Parameters.AddWithValue("@med_id", med_id);
                // add p test - se n tiver marcado não mostra na hora de alterar quais os dados anteriores, tanto faz
                cmd.Parameters.AddWithValue("@med_nome", med.Med_nome);
                cmd.Parameters.AddWithValue("@med_crmv", med.Med_crmv);
                cmd.Parameters.AddWithValue("@med_especialidade", med.Med_especialidade);
                cmd.Parameters.AddWithValue("@med_logradouro", med.Med_logradouro);
                cmd.Parameters.AddWithValue("@med_numero", med.Med_numero);
                cmd.Parameters.AddWithValue("@med_complemento", med.Med_complemento);
                cmd.Parameters.AddWithValue("@med_bairro", med.Med_bairro);
                cmd.Parameters.AddWithValue("@med_cidade", med.Med_cidade);
                cmd.Parameters.AddWithValue("@med_estado", med.Med_estado);

                conexao.Conectar();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    med.Med_id = Convert.ToInt32(registro["med_id"]);
                    med.Med_nome = Convert.ToString(registro["med_nome"]);

                    //IMPORTANTE !  se não tiver on ele só carrega o jack
                    med.Med_crmv = Convert.ToString(registro["med_crmv"]);
                    med.Med_logradouro = Convert.ToString(registro["med_logradouro"]);
                    med.Med_numero = Convert.ToString(registro["med_numero"]);
                    med.Med_complemento = Convert.ToString(registro["med_complemento"]);
                    med.Med_bairro = Convert.ToString(registro["med_bairro"]);
                    med.Med_cidade = Convert.ToInt32(registro["med_cidade"]);
                    med.Med_estado = Convert.ToInt32(registro["med_estado"]);
                    med.Med_especialidade = Convert.ToInt32(registro["med_especialidade"]);
                }
                return med;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();

            }


        }

    }//class

}//namespace
