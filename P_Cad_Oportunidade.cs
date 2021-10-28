using System;
using System.Collections.Generic;

class P_Cad_Oportunidade
{
    public void cadastro()
    {
        string nome = "";
        string endereco = " ";
        string contato = " ";
        string descricao = " ";


        Console.WriteLine("Digite o nome da oportunidade: ");
        nome = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Digite o endereço: ");
        endereco = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Digite o contato: ");
        contato = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Digite a descrição dessa oportunidade: ");
        descricao = Console.ReadLine();




        ValidaDados validar = new ValidaDados();
        if (validar.VerificaLetraEspaco(nome) && validar.Numero(contato) && validar.VerificaLetraNumero(endereco))
        {
            P_Oportunidade novoOportunidade = new P_Oportunidade(nome, endereco, contato, descricao);

            P_Banco BD = new P_Banco();
            BD.Cad_Oportunidade(novoOportunidade);

            Console.Clear();
            Console.WriteLine("Cadastro de oportunidade realizado com sucesso!");
            Console.ReadKey();
            P_Menu Menu = new P_Menu();
            Menu.inicio();

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Há dados incorretos, por favor tente novamente. ");
            Console.ReadKey();
            P_Menu Menu = new P_Menu();
            Menu.inicio();
        }
    }

    public void Mostra()
    {
        for (int i = 0; i < P_Banco.ListaOportunidade.Count; i++)
        {
            Console.WriteLine(i + " - ");
            Console.WriteLine("Nome: " + P_Banco.ListaOportunidade[i].nome);
            Console.WriteLine("Endereco: " + P_Banco.ListaOportunidade[i].endereco);
            Console.WriteLine("Contato: " + P_Banco.ListaOportunidade[i].contato);
            Console.WriteLine("Descricao: " + P_Banco.ListaOportunidade[i].descricao);

        }
        Console.ReadKey();
        P_Menu menu = new P_Menu();
        menu.inicio();
    }
}
