using System;

class P_Oportunidade
{
    public int cod_oportunidade { get; set; }
    public string nome { get; set; }
    public string endereco { get; set; }
    public string contato { get; set; }
    public string descricao { get; set; }

    public P_Oportunidade(string nome_, string endereco_, string contato_, string descricao_)
    {
        nome = nome_;
        endereco = endereco_;
        contato = contato_;
        descricao = descricao_;
        cod_oportunidade = P_Banco.ListaOportunidade.Count + 1;
    }
}