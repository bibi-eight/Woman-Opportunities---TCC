using System;

class P_Edita_User
{

    public void busca()
    {

        Console.WriteLine("Digite o cpf do usuario para busca: ");
        string cpf = Console.ReadLine();
        P_Banco banco = new P_Banco();
        P_User User = banco.Busca_User();

        if (User.cpf != " ")
        {
            Console.WriteLine("Nome: " + User.nome);
            Console.WriteLine("CPF: " + User.cpf);
            Console.WriteLine("Código: " + User.cod_user);

            Console.WriteLine("Deseja Alterar(A),  Excluir(E) ou outra tecla para o Menu");
            string resposta = Console.ReadLine();
            if (resposta == "A")
                altera(User);
            else
            if (resposta == "E")
                exclui(User);
            else
            {
                P_Menu menu = new P_Menu();
                menu.inicio();
            }
        }

        else
        {
            Console.WriteLine("CPF não encontrado! ");
            Console.ReadKey();
            P_Menu menu = new P_Menu();
            menu.inicio();
        }
    }

    public void altera(P_User user)
    {
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1) Editar o nome; ");
        Console.WriteLine("2) Editar o CPF:");
        Console.WriteLine("3) Não editar nada ");
        Console.Write("\r\nQual a sua opção?: ");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Digite o novo nome: ");
                user.nome = Console.ReadLine();
                break;
            case "2":
                Console.WriteLine("Digite o novo cpf: ");
                user.cpf = Console.ReadLine();
                break;
            case "3":
                Environment.Exit(1);
                break;
        }

        P_Banco banco = new P_Banco();
        bool retorno = banco.Altera_User(user);
        if (retorno == true)
            Console.WriteLine("ALteração realizada com sucesso!");
        else
            Console.WriteLine("Problemas para alterar o cadastro!");

        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }

    public void exclui(P_User user)
    {
        Console.WriteLine("Deseja Excluir o usuário? s/n");
        string resposta = Console.ReadLine();
        if (resposta == "s")
        {
            P_Banco banco = new P_Banco();
            bool retorno = banco.Exclui_User(user);
            if (retorno == true)
                Console.WriteLine("Exclusão realizada com sucesso!");
            else
                Console.WriteLine("Problemas para Excluir o usuário!");
        }

        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }
}
