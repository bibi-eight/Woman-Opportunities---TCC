using System;
using System.Collections.Generic;

class P_Banco
{
    public static List<P_Oportunidade> ListaOportunidade = new List<P_Oportunidade>();
    public static List<P_Login> User = new List<P_Login>();

    public bool Cad_Oportunidade(P_Oportunidade oportunidade)
    {
        bool retorno = true;
        ListaOportunidade.Add(oportunidade);
        return retorno;
    }

    public void Cad_User1(P_Login user1) //user do login
    {
        User.Add(user1);
    }


    public int AutenticaUsuario(string login, string senha)
    {
        int autenticacao = -1;

        if (login == User[0].login && senha == User[0].senha)
        {
            autenticacao = 0;
        }

        return autenticacao;
    }

    public bool alterasenha(string novasenha)
    {
        User[0].senha = novasenha;
        return true;
    }

    public P_Oportunidade Busca_oportunidade(string nome)
    {
        P_Oportunidade retorno = new P_Oportunidade(" ", " ", "", " ");

        int indice = -1;

        for (int i = 0; i < ListaOportunidade.Count; i++)
        {
            if (ListaOportunidade[i].nome == nome)
            {
                indice = i;
                break;
            }
        }
        if (indice != -1)
        {
            retorno.nome = ListaOportunidade[indice].nome;
            retorno.endereco = ListaOportunidade[indice].endereco;
            retorno.contato = ListaOportunidade[indice].contato;
            retorno.descricao = ListaOportunidade[indice].descricao;
            retorno.cod_oportunidade = ListaOportunidade[indice].cod_oportunidade;
        }
        return retorno;
    }
    public bool Altera_oportunidade(P_Oportunidade oportunidade)
    {
        bool retorno = false;
        int indice = -1;

        for (int i = 0; i < ListaOportunidade.Count; i++)
        {
            if (ListaOportunidade[i].cod_oportunidade == oportunidade.cod_oportunidade)
            {
                indice = i;
                retorno = true;
                break;
            }
        }
        if (retorno == true)
        {
            ListaOportunidade[indice].nome = oportunidade.nome;
            ListaOportunidade[indice].contato = oportunidade.contato;
            ListaOportunidade[indice].endereco = oportunidade.endereco;
            ListaOportunidade[indice].descricao = oportunidade.descricao;
        }
        return retorno;
    }
    public bool Exclui_Oportunidade(P_Oportunidade Oportunidade)
    {
        bool retorno = false;
        int indice = -1;
        for (int i = 0; i < ListaOportunidade.Count; i++)
        {
            if (ListaOportunidade[i].nome == Oportunidade.nome)
            {
                indice = i;
                retorno = true;
                break;
            }
        }
        if (retorno == true)
            ListaOportunidade.RemoveAt(indice);
        return retorno;

    }
    //método busca


}