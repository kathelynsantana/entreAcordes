using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//Importando os comandos de conexão com o banco
using System.Windows.Forms;//Importando a estrutura de telas

//Projeto Entre Acordes
namespace EntreAcordes
{
    //Entidade: Gênero Musical
    class DAOGeneroMusical
    {
        public string dados;
        public string comando;
        public string campo;
        public string novoDado;
        public int i;
        public int contar;
        public string msg;

        //Vetores
        public MySqlConnection conexao;//Variável de conexão com o banco de dados
        public int[] codigo;
        public string[] descricao;

        //Conectando o Banco de Dados...
        public DAOGeneroMusical()
        {
            //Conexão com o banco de dados...
            string conexaoString = "server=localhost;database=entreAcordes;Uid=root;Password=;Convert Zero DateTime=True";
            this.conexao = new MySqlConnection(conexaoString);
            try
            {
                //Abrindo a conexão com o banco de dados...
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {erro}");
                this.conexao.Close();//Fechar a conexão com o Banco de Dados

            }//Fim do try_catch
        }//Fim da Conexão com o Banco de Dados


        //---------------------------------------------------------------------------------------------------
        //Métodos
        //Cadastrar Gênero Musical
        public void cadastrarGeneroMusical(string descricao)
        {
            try
            {
                //Configurando o comando de inserção de dados no banco de dados...
                this.dados   = $"('', '{descricao}')";
                this.comando = $"insert into generoMusical(codigo, descricao) values {this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando...

                //Exibindo o resultado...
                MessageBox.Show($"Os dados do gênero musical foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show($"O cadastro do gênero musical foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro...
                MessageBox.Show($"Erro! Algo falhou no cadastro do gênero musical!" + erro);
                MessageBox.Show($"Não foi possível cadastrar o gênero musical!");

            }//Fim do try_catch
        }//Fim do Cadastrar Gênero Musical

        //Consultar Gênero Musical
        //Consultar Código do Gênero Musical
        public string consultarCodigo(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();
            this.msg = "";

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    this.msg = $"\nCódigo:    {this.codigo[i]}" +
                               $"\nDescrição: {this.descricao[i]}";
                    return this.msg;
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Código do Gênero Musical

        //Consultar Descrição
        public string consultarDescricao(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.descricao[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Descrição

        //Atualizar Gênero Musical
        public string atualizarGeneroMusical(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O gênero musical não foi encontrado. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update generoMusical set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"Os dados do gênero musical foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados do gênero musical!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir Gênero Musical
        public string excluirGeneroMusical(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O gênero musical não foi encontrado. Não foi possível excluí-lo!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from generoMusical where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"O gênero musical deletado com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Erro! Não foi possível excluir o gênero musical!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Método Excluir Gênero Musical


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela Gênero Musical...
            string query = "select * from generoMusical";

            //Instanciando os valores...
            this.codigo    = new int[100];
            this.descricao = new string[100];

            //Preenchendo os vetores com valores iniciais padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]    = 0;
                this.descricao[i] = "";
            }//Fim do for

            //Executando o comando do SQL...
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //Leitura dos dados no banco de dados...
            MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco de dados e traz os dados

            //Zerando o contador...
            i = 0;
            this.contar = 0;

            //Leitura dos dados do banco de dados...
            while (leitura.Read())
            {
                //Fazendo a leitura dos dados...
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.descricao[i] = leitura["nome"] + "";

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Gênero Musical
}//Fim do Projeto Entre Acordes