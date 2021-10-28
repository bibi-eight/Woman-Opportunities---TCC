using System;

namespace Woman_Opportunities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vinda ao Woman Opportunities");
            Console.WriteLine("Escolha como prosseguir: "); Console.WriteLine("");
            Console.WriteLine("1) Entrar com Login ");
            Console.WriteLine("2) Realizar cadastro ");
            Console.WriteLine("3) Sair; "); Console.WriteLine("");
            Console.Write("\r\n O que deseja fazer? ");

            switch (Console.ReadLine())
            {
                case "1":
                    P_Login P_Login = new P_Login();
                    carrega1();

                    P_Gerencia_Login gerencia = new P_Gerencia_Login();
                    gerencia.verificalogin();

                    P_Menu menu = new P_Menu();
                    menu.inicio();
                    break;
                case "2":
                    P_Cad_User cad = new P_Cad_User();
                    cad.cadastro();


                    break;
                case "3":
                    Environment.Exit(1);
                    break;
            }

        }
        public static void carrega1()
        {
            P_Login user = new P_Login();
            P_Banco banco = new P_Banco();
            banco.Cad_User1(user);
        }

        public static void carregaUser()
        {
            string[] nome = { "Ana", "Francisco", "Eduardo", "Viviane", "André" };
            string[] CPF = { "1234", "5678", "2468", "1357", "9988" };

        }
    }
}
