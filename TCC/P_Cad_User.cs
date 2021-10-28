using System;
using System.Collections.Generic;

class P_Cad_User
{
    public void cadastro()
    {
        string nome = "";
        string CPF = " ";
        string senha = " ";

        Console.WriteLine("Digite o nome do usuário: ");
        nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Digite o cpf do usuário: ");
        CPF = Console.ReadLine();
        Console.WriteLine("");
        senha = Console.ReadLine();

        ValidaDados validar = new ValidaDados();
        if (validar.VerificaLetraEspaco(nome) && validar.Numero(CPF))
        {
            P_User novoUser = new P_User(nome, CPF);

            P_Banco BD = new P_Banco();
            BD.Cad_User(novoUser);

            Console.Clear();
            Console.WriteLine("Cadastro de usuário realizado com sucesso!");
            Console.ReadKey();
            P_Menu Menu = new P_Menu();
            Menu.inicio();

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Há dados incorretos! Por favor, tente novamente. ");
            Console.ReadKey();
            P_Menu Menu = new P_Menu();
            Menu.inicio();
        }
    }

    public void Mostra()
    {
        for (int i = 0; i < P_Banco.ListaUser.Count; i++)
        {
            Console.WriteLine(i + " - ");
            Console.WriteLine("Nome: " + P_Banco.ListaUser[i].nome);
            Console.WriteLine("CPF: " + P_Banco.ListaUser[i].cpf);
        }
        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }
    
}
