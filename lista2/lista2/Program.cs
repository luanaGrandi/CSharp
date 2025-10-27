using System.Drawing;

void ExibirMenu()
{
    Console.WriteLine("Escolha qual exercicio você deseja ver: ");

    Console.WriteLine(@"
        [1] Exercicio 01
        [2] Exercicio 02
        [3] Exercicio 03
        [4] Exercicio 04
        [5] Exercicio 05
        [6] Exercicio 06
        [7] Exercicio 07
      
    ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: Exercicio1(); break;
        case 2: Exercicio2(); break;
        case 3: Exercicio3(); ; break;
        case 4: Exercicio4(); ; break;
        case 5: Exercicio5(); break;
        case 6: Exercicio6(); ; break;
        case 7: Exercicio7(); break;
        default: Console.WriteLine("Opção invalida"); break;
    }
}

void Exercicio1()
{
    Console.Clear();
    Console.WriteLine("Exercicio 01");
    Console.WriteLine("peça ao usuario sua idade e mostre sua categoria:");

    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 0 && idade <= 14){
        Console.WriteLine("Clasificação: Criança");
    }
    else if (idade >= 15 && idade <= 17){
        Console.WriteLine("Clasificação: Adolescente");
    }
    else if (idade >= 18 && idade <= 30)
    {
        Console.WriteLine("Clasificação: Adulto Jovem");
    }
    else if (idade >= 30)
    {
        Console.WriteLine("Clasificação: Adulto");
    }
}

void Exercicio2()
{
    Console.Clear();
    Console.WriteLine("Exercicio 02");
    Console.WriteLine("peça ao usuario o valor unitario e a quantidade de cada produto: ");

    Console.WriteLine("Digite o valor do produto: ");
    double valorProdt = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual a quantidade que você deseja?");
    int quantidade = int.Parse(Console.ReadLine());

    double total = valorProdt * quantidade;
    if (quantidade <= 12)
    {
        Console.WriteLine($"O valor da sua compra é: {total}");
    }
    else
    {
        double totaldesconto = total * 0.9;
        Console.WriteLine($"O valor da sua compra com 10% de desconto é: {totaldesconto}");
    }
}

void Exercicio3()
{
    Console.Clear();
    Console.WriteLine("Exercicio 03");
    Console.WriteLine("peça ao usuario quantidade de gols de 2 times e veja se deu empate ");

    Console.WriteLine("Digite quantos gols o santos fez: ");
    int golSantos = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantos gols o palmeiras fez: ");
    int golPalmeiras = int.Parse(Console.ReadLine());

    if (golSantos == golPalmeiras)
    {
        Console.WriteLine($"O jogo ficou EMPATADO! \n Santos {golSantos} X Palmeiras {golPalmeiras}");
    }
    else if (golSantos > golPalmeiras)
    {
        Console.WriteLine($"Santos {golSantos} X Palmeiras {golPalmeiras} \nSantou venceu!!!!");
    }
    else {
        Console.WriteLine($"Palmeiras {golPalmeiras} X Santos {golSantos}  \nPalmeiras venceu!!!!");
    }
}

void Exercicio4()
{
    Console.Clear();
    Console.WriteLine("Exercicio 04");
    Console.WriteLine("peça ao usuario onde ele deseja passar suas ferias: ");

    Console.WriteLine("Qual o seu destino: \n1-Maceió \n2-Porto de galinhas");
    int escolha = int.Parse(Console.ReadLine());

    double valorViagem = 1500.0;

    if (escolha == 1)
    {
        Console.WriteLine("Deseja de almoço/janta incluso: \n1-sim \n2-não");
        int incluso = int.Parse(Console.ReadLine());

        if (incluso == 1)
        {
            double TudoIncluso = valorViagem * 2;
            Console.WriteLine($"O valor da sua Viagem para Maceió, com alomoço e janta incluso é: {TudoIncluso}");
        }
        else
        {
            double naoIncluso = valorViagem + (valorViagem * 0.85);
            Console.WriteLine($"O valor da sua Viagem para Maceió, sem alomoço e janta é: {naoIncluso} ");
        }
    }
    else if (escolha == 2)
    {
        Console.WriteLine("Deseja de almoço/janta incluso: \n1-sim \n2-não");
        int incluso = int.Parse(Console.ReadLine());

        if (incluso == 1)
        {
            double TudoIncluso = valorViagem + (valorViagem * 0.60);
            Console.WriteLine($"O valor da sua Viagem para Porto de galinhas, com alomoço e janta incluso é: {TudoIncluso}");
        }
        else
        {
            double naoIncluso = valorViagem + (valorViagem * 0.45);
            Console.WriteLine($"O valor da sua Viagem para Porto de galinhas, sem alomoço e janta é: {naoIncluso} ");
        }
    }
}

void Exercicio5()
{
    Console.Clear();
    Console.WriteLine("Exercicio 05");
    Console.WriteLine("Algoritimo para ler quantidade ataul em estoque");

    Console.Write("Digite a quantidade atual em estoque: ");
    double qtdAtual = double.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade máxima em estoque: ");
    double qtdMax = double.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade mínima em estoque: ");
    double qtdMin = double.Parse(Console.ReadLine());

    // Cálculo da quantidade média
    double qtdMedia = (qtdMax + qtdMin) / 2;

    // Exibe a quantidade média
    Console.WriteLine($"\nQuantidade média: {qtdMedia}");

    // Verifica se deve efetuar a compra
    if (qtdAtual >= qtdMedia)
    {
        Console.WriteLine("Não efetuar compra");
    }
    else
    {
        Console.WriteLine("Efetuar compra");
    }
}

void Exercicio6()
{
    Console.Clear();
    Console.WriteLine("Exercicio 06");
    Console.WriteLine("Gerar numero da sorte!");

    // sorteador de numeros aleatorios
    Random random = new Random();

    int numeroDaSorte = random.Next(1, 101);

    Console.Write("Tente adivinhar qual numero da sorte irá sair de 01 á 100:");
    int palpite = int.Parse(Console.ReadLine());
   
    if (palpite == numeroDaSorte)
    {
        Console.WriteLine("Você acertouuuuuuuuuuuuuuuuuuuuuuuuuu");
    }
    else
    {
        Console.WriteLine($"Você errouuuuu, que peninha! \no numero da sorte era: {numeroDaSorte}.");
    }
}

void Exercicio7()
{
    Console.Clear();
    Console.WriteLine("Exercicio 07");
    Console.WriteLine("Perguntas e respostas");

    Console.WriteLine("Você deseja responder a pergunta 1 ou 2: ");
    int escolha = int.Parse(Console.ReadLine());

    string respostaUsuario;
    string respostaCorreta;

    if (escolha == 1)
    {
        Console.WriteLine("\nPergunta 1:");
        Console.WriteLine("Qual é a idade da Luana? ");
        Console.WriteLine("a) 16");
        Console.WriteLine("b) 18");
        Console.WriteLine("c) 17");

        respostaCorreta = "c";
    }
    else if (escolha == 2)
    {
        Console.WriteLine("\nPergunta 2:");
        Console.WriteLine("Qual a cor preferida da Luana? ");
        Console.WriteLine("a) Rosa");
        Console.WriteLine("b) Verde-Agua");
        Console.WriteLine("c) Roxo");

        respostaCorreta = "b";
    }
    else
    {
        Console.WriteLine("\nOpção inválida!");
        return;
    }

    Console.Write("\nDigite a letra da sua resposta: ");
    respostaUsuario = Console.ReadLine();

   
    respostaUsuario = respostaUsuario.ToLower();

    
    if (respostaUsuario == respostaCorreta)
    {
        Console.WriteLine("\n Ebaaaa! você acertou, pode retirar seu bônus na Shostners and Shostners!");
    }
    else
    {
        Console.WriteLine("\nVish, você errou, mas tente novamente numa próxima!");
    }

}

ExibirMenu();