using System;
class P_User
{
    public int cod_user { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }

    public P_User(string nome_, string cpf_)
    {
        nome = nome_;
        cpf = cpf_;
        cod_user = P_Banco.ListaUser.Count + 1;
    }
}