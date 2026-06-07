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
    //Entidade: Cantor
    class DAOCantor
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
        public string[] genero;
        public DateTime[] dataNascimento;

        //Conectando o Banco de Dados...
        public DAOCantor()
        {
            //Conexão com o banco de dados...
            string conexaoString = "server=localhost;database=entreAcordes;Uid=root;Password=;Convert Zero DateTime=True";
            this.conexao = new MySqlConnection(conexaoString);
            try
            {
                //Abrindo a conexão com o banco de dados...
                this.conexao.Open();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {erro}");
                this.conexao.Close();//Fechar a conexão com o Banco de Dados

            }//Fim do try_catch
        }//Fim da Conexão com o Banco de Dados


        //---------------------------------------------------------------------------------------------------
        //Métodos
        //Cadastrar Cantor
        public void cadastrarCantor(string nome, string genero, DateTime dataNascimento)
        {
            try
            {
                //Configurando o comando de inserção de dados no banco de dados...
                this.dados   = $"('', '{nome}','{genero}','{dataNascimento}')";
                this.comando = $"insert into cantor(codigo, nome, genero, dataNascimento) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando...

                //Exibindo o resultado...
                MessageBox.Show($"Os dados do cantor foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show($"O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro...
                MessageBox.Show($"Erro! Algo falhou no cadastro do cantor!" + erro);
                MessageBox.Show($"Não foi possível cadastrar o cantor!");

            }//Fim do try_catch
        }//Fim do Cadastrar Cantor

        //Consultar Cantor
        //Consultar o Código do Cantor
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
                    this.msg = $"\nCódigo:             {this.codigo[i]}"  +
                               $"\nNome:               {this.nome[i]}"    +
                               $"\nGênero:             {this.genero[i]}"  +
                               $"\nData de Nascimento: {this.dataNascimento[i]}";
                    return this.msg;
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar o Código do Inscrito

        //Consultar Nome
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

        //Consultar Gênero
        public string consultarGenero(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();
            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.genero[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Gênero

        //Consultar Data de Nascimento
        public string consultarDataNascimento(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return "" + this.dataNascimento[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Data de Nascimento

        //Atualizar Cantor
        public string atualizarCantor(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O cantor não foi encontrado. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update cantor set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"Os dados do cantor foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados do cantor!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir Cantor
        public string excluirCantor(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O cantor não foi encontrado. Não foi possível excluí-lo!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from cantor where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"O cantor deletado com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Erro! Não foi possível excluir o cantor!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Excluir Cantor


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela Cantor...
            string query = "select * from cantor";

            //Instanciando os valores...
            this.codigo         = new int[100];
            this.nome           = new string[100];
            this.genero         = new string[100];
            this.dataNascimento = new DateTime[100];

            //Preenchendo os vetores com valores iniciais padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]         = 0;
                this.nome[i]           = "";
                this.genero[i]         = "";
                this.dataNascimento[i] = new DateTime();
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
                this.codigo[i]         = Convert.ToInt32(leitura["codigo"]);
                this.nome[i]           = leitura["nome"] + "";
                this.genero[i]         = leitura["genero"] + "";
                this.dataNascimento[i] = Convert.ToDateTime(leitura["dataNascimento"]);

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Cantor
}//Fim do Projeto Entre Acordes