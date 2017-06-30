using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 17/02
// Data de modificação 17/02


namespace DAL
{
    public class AtendimentoDAL
    {
        private ConexaoDAL conexao;

        public AtendimentoDAL(ConexaoDAL ateDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = ateDalCon;
        }

        public void Incluir(AtendimentoDTO ateDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbAtendimento(ate_animal, ate_cliente, ate_medico, ate_tipo, ate_data, ate_hora, ate_anamnese, ate_tratamento) values (@ate_animal, @ate_cliente, @ate_medico, @ate_tipo, @ate_data, @ate_hora, @ate_anamnese, @ate_tratamento); select @@identity; ";
                cmd.Parameters.AddWithValue("@ate_animal", ateDalCrud.Ate_animal);
                cmd.Parameters.AddWithValue("@ate_cliente", ateDalCrud.Ate_cliente);
                cmd.Parameters.AddWithValue("@ate_medico", ateDalCrud.Ate_medico);
                cmd.Parameters.AddWithValue("@ate_tipo", ateDalCrud.Ate_tipo);
                cmd.Parameters.AddWithValue("@ate_data", ateDalCrud.Ate_data);
                cmd.Parameters.AddWithValue("@ate_hora", ateDalCrud.Ate_hora);
                cmd.Parameters.AddWithValue("@ate_anamnese", ateDalCrud.Ate_anamnese);
                cmd.Parameters.AddWithValue("@ate_tratamento", ateDalCrud.Ate_tratamento);
                   
                conexao.Conectar();

                ateDalCrud.Ate_id = Convert.ToInt32(cmd.ExecuteScalar());
                
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

        public void Alterar(AtendimentoDTO ateDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbAtendimento set ate_animal = @ate_animal, ate_cliente = @ate_cliente, ate_medico = @ate_medico, ate_tipo = @ate_tipo, ate_data = @ate_data, ate_hora = @ate_hora, ate_anamnese = @ate_anamnese, ate_tratamento = @ate_tratamento where ate_id = @ate_id;";
                cmd.Parameters.AddWithValue("@ate_id", ateDalCrud.Ate_id);
                cmd.Parameters.AddWithValue("@ate_animal", ateDalCrud.Ate_animal);
                cmd.Parameters.AddWithValue("@ate_cliente", ateDalCrud.Ate_cliente);
                cmd.Parameters.AddWithValue("@ate_medico", ateDalCrud.Ate_medico);
                cmd.Parameters.AddWithValue("@ate_tipo", ateDalCrud.Ate_tipo);
                cmd.Parameters.AddWithValue("@ate_data", ateDalCrud.Ate_data);
                cmd.Parameters.AddWithValue("@ate_hora", ateDalCrud.Ate_hora);
                cmd.Parameters.AddWithValue("@ate_anamnese", ateDalCrud.Ate_anamnese);
                cmd.Parameters.AddWithValue("@ate_tratamento", ateDalCrud.Ate_tratamento);
            
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

        public void Excluir(int ate_id) //tipo + o campo do banco
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "delete from tbAtendimento where ate_id = @ate_id;";
                cmd.Parameters.AddWithValue("@ate_id", ate_id);
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

        public DataTable PesquisarNomeAnimalAtendimento(String ani_nome) //tipo + o campo do banco // 
        {
            DataTable tabela = new DataTable();
            //       SqlDataAdapter da = new SqlDataAdapter("select at.ate_id, an.ani_nome, cl.cli_nome, m.med_nome, at.ate_anamnese, at.ate_tratamento, at.ate_data, at.ate_hora, ex.exa_exame, v.vac_vacina from tbAtendimento AS at inner join tbAnimal AS an  on an.ani_id = at.ate_animal inner join tbCliente AS cl  on cl.cli_id = at.ate_animal inner join tbMedico AS m on m.med_id = at.ate_medico inner join tbExame AS ex on ex.exa_id = at.ate_exame inner join tbVacina AS v on v.vac_id = at.ate_vacina where ani_nome like '%" + ani_nome + "%' ", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select at.ate_id, an.ani_nome, cl.cli_nome, m.med_nome, at.ate_anamnese, at.ate_tratamento, at.ate_data, at.ate_hora from tbAtendimento AS at inner join tbAnimal AS an  on an.ani_id = at.ate_animal inner join tbCliente AS cl  on cl.cli_id = at.ate_animal inner join tbMedico AS m on m.med_id = at.ate_medico where ani_nome like '%" + ani_nome + "%' ", conexao.StringConexao);
            
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarNomeCliente(String cli_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select at.ate_id, an.ani_nome, cl.cli_nome, m.med_nome, at.ate_anamnese, at.ate_tratamento, at.ate_data, at.ate_hora where cli_nome like '%" + cli_nome + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarTodosAtendimentos() //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select at.ate_id, at.ate_data, at.ate_hora, an.ani_nome, cl.cli_nome, m.med_nome, at.ate_anamnese, at.ate_tratamento  from tbAtendimento AS at inner join tbAnimal AS an  on an.ani_id = at.ate_animal inner join tbCliente AS cl  on cl.cli_id = at.ate_animal inner join tbMedico AS m  on m.med_id = at.ate_medico", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        // teste
        public DataTable PesquisarAnimaldoAtendimento(String ate_animal) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" select ate.ate_id, ani.ani_id, ani.ani_nome, s.sexo_nome, es.esp_nome, r.raça_nome, p.peso_valor, i.idade_valor from tbAnimal as ani inner join tbAtendimento as ate on ani.ani_id = ate.ate_id inner join tbSexo as s on ani.sexo_id = s.sexo_id inner join tbEspecie as es on ani.esp_id = es.esp_id inner join tbRaça as r on ani.raça_id = r.raça_id inner join tbPeso as p on ani.peso_id = p.peso_id inner join tbIdade as i on ani.idade_id = i.idade_id where ate_animal = ani_id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public AtendimentoDTO CarregaAtendimentoDTO(int ate_id) //tipo + o campo do banco
        {
            try
            {
                AtendimentoDTO ate = new AtendimentoDTO();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                // OBS aqui a consulta é basica, pq se n for ele n consegue atualizar os dados
                cmd.CommandText = "select * from tbAtendimento where ate_id = @ate_id;";
                cmd.Parameters.AddWithValue("@ate_id", ate_id);
                cmd.Parameters.AddWithValue("@ate_animal", ate.Ate_animal);
                cmd.Parameters.AddWithValue("@ate_cliente", ate.Ate_cliente);
                cmd.Parameters.AddWithValue("@ate_medico", ate.Ate_medico);
                cmd.Parameters.AddWithValue("@ate_tipo", ate.Ate_tipo);
                cmd.Parameters.AddWithValue("@ate_data", ate.Ate_data);
                cmd.Parameters.AddWithValue("@ate_hora", ate.Ate_hora);
                cmd.Parameters.AddWithValue("@ate_anamnese", ate.Ate_anamnese);
                cmd.Parameters.AddWithValue("@ate_tratamento", ate.Ate_tratamento);
             
                conexao.Conectar();

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    ate.Ate_id = Convert.ToInt32(registro["ate_id"]);
                    ate.Ate_animal = Convert.ToInt32(registro["ate_animal"]);
                    ate.Ate_cliente = Convert.ToInt32(registro["ate_cliente"]);
                    ate.Ate_medico = Convert.ToInt32(registro["ate_medico"]);
                    ate.Ate_tipo = Convert.ToInt32(registro["ate_tipo"]);
                    ate.Ate_data = Convert.ToString(registro["ate_data"]);
                    ate.Ate_hora = Convert.ToString(registro["ate_hora"]);
                    ate.Ate_anamnese = Convert.ToString(registro["ate_anamnese"]);
                    ate.Ate_tratamento = Convert.ToString(registro["ate_tratamento"]);
                    
                }
                return ate;
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

