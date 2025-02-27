namespace HelloWord


{
    class Program
    {
        static void Main()
        {
            ////digtar nome do usuario e armazenar
            //System.Console.WriteLine("Digite seu nome: "); // so exibi na tela
            //string? nome = System.Console.ReadLine(); // guarda o nome do usuario
            ////mostrar o nome do usuario e mensagem de boas vindas
            //System.Console.WriteLine("Olá, " + nome + " Seja bem vindo!");

            ////concatenar nome e sobrenome
            //System.Console.WriteLine("Digite seu nome: ");
            //string? nome = System.Console.ReadLine();
            //System.Console.WriteLine("Digite seu sobrenome: ");
            //string? sobrenome = System.Console.ReadLine();
            //System.Console.WriteLine("Olá, " + nome + " " + sobrenome + " Seja bem vindo!"); // Concatenar usa o + para juntar as strings

            //double n1 = 10, n2 = 20;
            //double soma = n1 + n2;
            //double sub = n1 - n2;
            //double mult = n1 * n2;
            //double div = n1 / n2;
            //double media = (n1 + n2) / 2;

            //System.Console.WriteLine("Resultados: " + "\nsoma: " + soma + "\nsub : " + sub + "\nmult : " + mult + "\ndiv : " + div + "\nmedia : " + media);


            ////digite a placa do seu veiculo
            //System.Console.WriteLine("Digite a placa do seu veiculo: ");
            //string? placa = System.Console.ReadLine();

            //if (placa.Length == 7)
            //{
            //    string letras = placa.Substring(0, 3); 
            //    string numeros = placa.Substring(3, 4); 
            //    if (letras == letras.ToUpper() || letras == letras.ToLower())
            //    {
            //        if (numeros == numeros.ToUpper() || numeros == numeros.ToLower())
            //        {
            //            System.Console.WriteLine("Placa válida!");
            //        }
            //        else
            //        {
            //            System.Console.WriteLine("Placa inválida!");
            //        }
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Placa inválida!");
            //    }
            //}
            //else
            //{
            //    System.Console.WriteLine("Placa inválida!");
            //}

            System.Console.WriteLine("Data atual: " + System.DateTime.Now);
            System.Console.WriteLine("Data atual: " + System.DateTime.Now.ToString("dd/MM/yyyy"));
            ////System.Console.WriteLine("Data atual: " + System.DateTime.Now.ToString("HH:mm:ss"));
            ////System.Console.WriteLine("Data atual: " + System.DateTime.Now.ToString("dd/MMMM/yyyy"));
            ////System.Console.WriteLine("Data atual: " + System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

        }
    }
}