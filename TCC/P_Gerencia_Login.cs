using System;

class P_Gerencia_Login
{
    public void verificalogin()
    {
        Console.Write("Entre com o login: ");
        string login = Console.ReadLine();
        Console.Write("Entre com a senha: ");
        string senha = Console.ReadLine();

        P_Banco banco = new P_Banco();
        var RetornoBancoLogin = banco.AutenticaUsuario(login, senha);

        P_Menu menu = new P_Menu();

        if (RetornoBancoLogin == 0)
        {
            Console.WriteLine("Autenticado!");
            menu.inicio();
        }
        else

        if (RetornoBancoLogin == -1)
        {
            Console.WriteLine("Não autenticado!");
            Environment.Exit(1);
        }
    }

    public void alterasenha()
    {
        Console.WriteLine("Digite sua nova senha: ");
        string novasenha = Console.ReadLine();


        P_Banco banco = new P_Banco();
        bool autenticacao = banco.alterasenha(novasenha);

        if (autenticacao == true)
        {
            Console.WriteLine("Alteração Realizada! Faça login novamente! ");
            verificalogin();
        }
    }
}