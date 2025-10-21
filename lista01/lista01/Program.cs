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
        case 3: Exercicio3(); break;
        case 4: Console.WriteLine("Voce escolheu a opção" + opcaoEscolhida); break;
        case 0: Console.WriteLine("Voce escolheu a opção" + opcaoEscolhida); break;
        default: Console.WriteLine("Opção invalida"); break;
    }


}

void Exercicio1()
{
    Console.Clear();
    Console.WriteLine("Exercicio 01");
    Console.WriteLine("Futura vaga na Bosch");

    Console.WriteLine("\nDigite seu nome: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite seu sobrenome: ");
    string sobrenome = Console.ReadLine()!;

    Console.WriteLine("Digite sua data de nascimento: ");
    string dataNasc = Console.ReadLine()!;

    Console.WriteLine("Digite sua pretenção salarial ");
    float salario = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Escreva seu grau de instituição: \n1) ensino médio \n2)ensino técnico \n3)ensino superior \n: ");
    string ensino = Console.ReadLine()!;

    Console.WriteLine("Digite o cargo que pretende: ");
    string cargo = Console.ReadLine()!;

    Console.WriteLine("Você possui CNH (sim/nao):  ");
    string cnh = Console.ReadLine()!;

    exibirInfo();

    void exibirInfo()
    {
        Console.WriteLine("\n--------------------------------------------------------------------");
        Console.WriteLine("Informações do cadastro");
        Console.WriteLine($"nome: {nome} \nSobrenome: {sobrenome} \nData de nascimento: {dataNasc} \nPretenção salarial: {salario}" +
            $"\nGrau de instituição: {ensino} \nCargo que pretende: {cargo} \nPossui CNH?: {cnh} ");
    }


}

void Exercicio2()
{
    Console.Clear();
    Console.WriteLine("Exercicio 02");
    Console.WriteLine("Receba 2 numeros inteiros");

    Console.WriteLine("Digite um numero inteiro: ");
    int num1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite um numero inteiro: ");
    int num2 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("\nResultados:");

    int soma = num1 + num2;
    Console.WriteLine($"\nSoma: {num1} + {num2} = {soma} ");

    int sub = num1 - num2;
    Console.WriteLine($"\nSoma: {num1} - {num2} = {sub} ");

    int mult = num2 * num1;
    Console.WriteLine($"\nSoma: {num1} * {num2} = {mult} ");

    double elevado = Math.Pow(num1, num2); 
    Console.WriteLine($"\nSoma: {num1} elevado {num2} = {elevado} ");

    //desafio 01
    if (num2 != 0)
    {
        int divisao = num1 / num2;
        Console.WriteLine($"\nSoma: {num1} / {num2} = {divisao} ");

        int resto = num1 % num2;
        Console.WriteLine($"\nSoma: {num1} % {num2} = {resto} ");
    }
    else
    {
        Console.WriteLine("A divisão não poderá ser realizada!");
    }

    



}

void Exercicio3()
{
    Console.Clear();
    Console.WriteLine("Exercicio 03");
    Console.WriteLine("Calculando o valor de uma mercadoria");

    Console.WriteLine("Informe o valor da compra: ");
    double valorCompra = double.Parse(Console.ReadLine());

    double representante = valorCompra * 0.2;
    Console.WriteLine($"valor da venda + 20% do representante: {representante}");

    double imposto = valorCompra * 0.3;
    Console.WriteLine($"valor da venda + 30% do imposto: {imposto}");

    double valorFinal = representante + imposto + valorCompra;
    Console.WriteLine($"Valor total da compra: {valorFinal}");
}

ExibirMenu();