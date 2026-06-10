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
    //Entidade: Música
    class DAOMusica
    {
        //Variáveis
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
        public string[] nome;
        public string[] letra;
        public DateTime[] dataLancamento;
        public int[] cantorCodigo;
        public int[] generoMusicalCodigo;

        public DAOMusica()
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
        //Cadastrar Música
        public void cadastrarMusica(string nome, string letra, DateTime dataLancamento, int cantorCodigo, int generoMusicalCodigo)
        {
            try
            {
                //Configurando o comando de inserção de dados no banco de dados...
                this.dados   = $"('', '{nome}', '{letra}', '{dataLancamento}', '{cantorCodigo}', '{generoMusicalCodigo}')";
                this.comando = $"insert into musica(codigo, nome, letra, dataLancamento, cantorCodigo, generoMusicalCodigo) values{this.dados}";
                
                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando...

                //Exibindo o resultado...
                MessageBox.Show($"Os dados da música foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show($"O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro...
                MessageBox.Show($"Erro! Algo falhou no cadastro da música!" + erro);
                MessageBox.Show($"Não foi possível cadastrar a música!");

            }//Fim do try_catch
        }//Fim do Método Cadastrar Música

        //Consultar Música
        //Consultar Código da Música
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
                    this.msg = $"\nCódigo:           {this.codigo[i]}" +
                               $"\nNome:             {this.nome[i]}" +
                               $"\nLetra:            {this.letra[i]}" +
                               $"\nCódigo do Cantor: {this.cantorCodigo[i]}" +
                               $"\nCódigo do Gênero: {this.generoMusicalCodigo[i]}";
                    return this.msg;
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Método Consultar Código da Música

        //Consultar Nome da Música
        public string consultarNome(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.nome[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Nome

        //Consultar Letra da Música
        public string consultarLetra(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.letra[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Letra da Música

        //Consultar Data de Lançamento da Música
        public string consultarDataLancamento(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return "" + this.dataLancamento[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Data de Lançamento da Música

        //Consultar Código do Cantor da Música
        public string consultarCantorCodigo(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return "" + this.cantorCodigo[i];
                }//Fim do if
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Código do Cantor da Música

        //Consultar Código do Gênero Musical da Música
        public string consultarGeneroMusicalCodigo(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return "" + this.generoMusicalCodigo[i];
                }//Fim do if
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Código do Gênero Musical da Música

        //Atualizar Música
        public string atualizarMusica(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"A música não foi encontrada. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update musica set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"Os dados da música foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados da música!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir Música
        public string excluirMusica(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"A música não foi encontrada. Não foi possível excluí-la!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from musica where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"A música deletada com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Erro! Não foi possível excluir a música!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Excluir


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela Música
            string query = "select * from musica";

            //Instanciando os valores...
            this.codigo              = new int[100];
            this.nome                = new string[100];
            this.letra               = new string[100];
            this.dataLancamento      = new DateTime[100];
            this.cantorCodigo        = new int[100];
            this.generoMusicalCodigo = new int[100];

            //Preenchendo os vetores com valores iniciais padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]              = 0;
                this.nome[i]                = "";
                this.letra[i]               = "";
                this.dataLancamento[i]      = DateTime.Now;
                this.cantorCodigo[i]        = 0;
                this.generoMusicalCodigo[i] = 0;
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
                this.codigo[i]              = Convert.ToInt32(leitura["codigo"]);
                this.nome[i]                = leitura["nome"] + "";
                this.letra[i]               = leitura["letra"] + "";
                this.dataLancamento[i]      = Convert.ToDateTime(leitura["dataLancamento"]);
                this.cantorCodigo[i]        = Convert.ToInt32(leitura["cantorCodigo"]);
                this.generoMusicalCodigo[i] = Convert.ToInt32(leitura["generoMusicalCodigo"]);

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade: Música
}//Fim do Projeto Entre Acordes