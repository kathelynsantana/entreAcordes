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
    //Entidade: Inscrito
    class DAOInscrito
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
        public DateTime[] dataNascimento;
        public string[] telefone;
        public string[] email;
        public string[] senha;

        //Conectando o Banco de Dados...
        public DAOInscrito()
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
        //Cadastrar Inscrito
        public void cadastrarInscrito(string nome, DateTime dataNascimento, string telefone, string email, string senha)
        {
            try
            {
                //Configurando o comando de inserção de dados no banco de dados...
                this.dados   = $"('', '{nome}', '{dataNascimento}', '{telefone}', '{email}', '{senha}')";
                this.comando = $"insert into inscrito(codigo, nome, dataNascimento, telefone, email, senha) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando...

                //Exibindo o resultado...
                MessageBox.Show($"Os dados do inscrito foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show($"O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro...
                MessageBox.Show($"Erro! Algo falhou no cadastro do inscrito!" + erro);
                MessageBox.Show($"Não foi possível cadastrar o inscrito!");

            }//Fim do try_catch
        }//Fim do Cadastrar Inscrito

        //Consultar Inscrito
        //Consultar o Código do Inscrito
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
                    this.msg = $"\nCódigo:             {this.codigo[i]}"         +
                               $"\nNome:               {this.nome[i]}"           +
                               $"\nData de Nascimento: {this.dataNascimento[i]}" +
                               $"\nTelefone:           {this.telefone[i]}"       +
                               $"\nE-mail:             {this.email[i]}"          +
                               $"\nSenha:              {this.senha[i]}";
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

        //Consultar Telefone
        public string consultarTelefone(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return "" + this.telefone[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Telefone

        //Consultar E-mail
        public string consultarEmail(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (int i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.email[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar E-mail

        //Consultar Senha
        public string consultarSenha(int codigo)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (int i = 0; i < this.contar; i++)
            {
                //Verificando o código...
                if (this.codigo[i] == codigo)
                {
                    return this.senha[i];
                }//Fim do if              
            }//Fim do for

            //Se o código não for encontrado...
            return "O código informado não existe!";
        }//Fim do Consultar Senha

        //Login
        public void loginInscrito(string email, string senha)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                //Verificando se o e-mail e senha são válidos...
                if ((this.email[i] == email) && (this.senha[i] == senha))
                {
                    //Se o e-mail e a senha forem válidos...
                    MessageBox.Show("Login realizado com sucesso!");
                    MessageBox.Show("Bem-vindo(a)!");
                    return;//Encerrando o processo de login

                }//Fim do if
            }//Fim do for

            //Se o e-mail e/ou a senha não forem válidos...
            MessageBox.Show("E-mail ou senha incorretos!");

        }//Fim do Login

        //Atualizar Inscrito
        public string atualizarInscrito(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O inscrito não foi encontrado. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update inscrito set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"Os dados do inscrito foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados do inscrito!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir Inscrito
        public string excluirInscrito(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O inscrito não foi encontrado. Não foi possível excluí-lo!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from inscrito where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando

                //Exibindo o resultado...
                return $"O inscrito deletado com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Erro! Não foi possível excluir o inscrito!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Excluir


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela Inscrito...
            string query = "select * from inscrito";

            //Instanciando os valores...
            this.codigo         = new int[100];
            this.nome           = new string[100];
            this.dataNascimento = new DateTime[100];
            this.telefone       = new string[100];
            this.email          = new string[100];
            this.senha          = new string[100];

            //Preenchendo os vetores com valores iniciais padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]         = 0;
                this.nome[i]           = "";
                this.dataNascimento[i] = new DateTime();
                this.telefone[i]       = "";
                this.email[i]          = "";
                this.senha[i]          = "";
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
                this.dataNascimento[i] = Convert.ToDateTime(leitura["dataNascimento"]);
                this.telefone[i]       = leitura["telefone"] + "";
                this.email[i]          = leitura["email"] + "";
                this.senha[i]          = leitura["senha"] + "";

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Inscrito
}//Fim do Projeto Entre Acordes