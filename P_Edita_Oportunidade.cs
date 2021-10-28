using System;

class P_Edita_Oportunidade
{

    public void busca()
    {

        Console.WriteLine("Digite o nome da oportunidade para busca: ");
        string nome = Console.ReadLine();
        P_Banco banco = new P_Banco();
        P_Oportunidade oportunidade = banco.Busca_oportunidade(nome);

        if (oportunidade.nome != " ")
        {
            Console.WriteLine("Nome: " + oportunidade.nome);
            Console.WriteLine("Endereco: " + oportunidade.endereco);
            Console.WriteLine("Contato: " + oportunidade.contato);
            Console.WriteLine("Descrição: " + oportunidade.descricao);
            Console.WriteLine("Código: " + oportunidade.cod_oportunidade);

            Console.WriteLine("Deseja Alterar(A),  Excluir(E) ou outra tecla para o Menu");
            string resposta = Console.ReadLine();
            if (resposta == "A")
                altera(oportunidade);
            else
            if (resposta == "E")
                exclui(oportunidade);
            else
            {
                P_Menu menu = new P_Menu();
                menu.inicio();
            }
        }

        else
        {
            Console.WriteLine("Nome não encontrado! ");
            Console.ReadKey();
            P_Menu menu = new P_Menu();
            menu.inicio();
        }
    }

    public void altera(P_Oportunidade oportunidade)
    {
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1) Editar o nome; ");
        Console.WriteLine("2) Editar o endereço; ");
        Console.WriteLine("3) Editar o contato; ");
        Console.WriteLine("4) Editar a descrição; ");
        Console.WriteLine("5) Não editar; ");
        Console.Write("\r\nQual a sua opção?: ");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Digite o novo nome: ");
                oportunidade.nome = Console.ReadLine();
                break;
            case "2":
                Console.WriteLine("Digite o novo endereço: ");
                oportunidade.endereco = Console.ReadLine();
                break;
            case "3":
                Console.WriteLine("Digite o novo contato: ");
                oportunidade.contato = Console.ReadLine();
                break;
            case "4":
                Console.WriteLine("Digite a nova descrição: ");
                oportunidade.descricao = Console.ReadLine();
                break;
            case "5":
                Environment.Exit(1);
                break;
        }

        P_Banco banco = new P_Banco();
        bool retorno = banco.Altera_oportunidade(oportunidade);
        if (retorno == true)
            Console.WriteLine("ALteração realizada com sucesso!");
        else
            Console.WriteLine("Problemas para alterar o cadastro!");

        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }

    public void exclui(P_Oportunidade oportunidade)
    {
        Console.WriteLine("Deseja Excluir a oportunidade? s/n");
        string resposta = Console.ReadLine();
        if (resposta == "s")
        {
            P_Banco banco = new P_Banco();
            bool retorno = banco.Exclui_Oportunidade(oportunidade);
            if (retorno == true)
                Console.WriteLine("Exclusão realizada com sucesso!");
            else
                Console.WriteLine("Problemas para Excluir o cadastro!");
        }

        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }
}