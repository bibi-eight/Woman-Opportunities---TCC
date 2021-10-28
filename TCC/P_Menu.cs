using System;
class P_Menu
{
    public void inicio()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção: ");
        Console.WriteLine("1) Cadastrar Oportunidade; ");
        Console.WriteLine("2) Editar Oportunidade; ");
        Console.WriteLine("3) Editar Usuário: ");
        Console.WriteLine("4) Sair; ");
        Console.Write("\r\n O que deseja fazer? ");

        switch (Console.ReadLine())
        {
            case "1":
                P_Cad_Oportunidade cad = new P_Cad_Oportunidade();
                cad.cadastro();
                break;
            case "2":
                P_Edita_Oportunidade edita = new P_Edita_Oportunidade();
                edita.busca();
                break;
            case "3":
                P_Edita_User edita2 = new P_Edita_User();
                edita2.busca();
                break;
            case "4":
                Environment.Exit(1);
                break;
        }
    }
}