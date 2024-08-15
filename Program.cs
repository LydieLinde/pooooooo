// Questão 1 

// // Escreva um programa em C# que declare variáveis dos tipos int, float, string e bool. Atribua valores a essas variáveis e imprima-os no console.


// int inteiro = 5;
// double NaoInteiro = 6.0;
// float DecimaisMenores = 1.0f;
// string texto = "lydia é linda";
// bool f = false;


// Console.WriteLine($"{inteiro}");
// Console.WriteLine($"{NaoInteiro}");
// Console.WriteLine($"{DecimaisMenores}");
// Console.WriteLine($"{texto}");
// Console.WriteLine($"{f}");


// Questão 2

// Console.WriteLine("Digite um numero");
//     int i = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite outro numero");
//     int ii = int.Parse(Console.ReadLine());


//     int soma = i + ii;
//     Console.WriteLine($"A soma dos numeros é {soma}");


//     int subtracao = i - ii;
//     Console.WriteLine($"A subtração dos numeros é {subtracao}");


//     int multiplicacao = i * ii;
//     Console.WriteLine($"A multiplicação dos numeros é {multiplicacao}");




//     int divisao = i / ii;
//     Console.WriteLine($"A divisão dos numeros é {divisao}");
   
//     int resto = i % ii;
//     Console.WriteLine($"O resto da divisão dos numeros é {resto}");
   


// Questão 3
// Console.WriteLine("Digite seu nome:");
//      string nome = (Console.ReadLine());


//   Console.WriteLine("Digite sua idade:");
//   int idade = int.Parse(Console.ReadLine());


//     Console.WriteLine($"Olá, {nome}, você tem {idade} anos");


// Questão 4

// Console.WriteLine("Digite um número:");
//      int numero = int.Parse(Console.ReadLine());


//     if (numero > 0){
       
//       Console.WriteLine($"O número {numero} é positivo");
     
//     }


//     else if (numero < 0){


//       Console.WriteLine($"O número {0} é negativo");
     
//     }
   
//     else {
//       Console.WriteLine($"O numero {numero} é Zero");
//     }






// Questão 5 
//  // Loop para exibir os números de 1 a 10
//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine(i);
//     }




// Questão 6
// Console.WriteLine ("Digite sua idade: ");
//     int idade = int.Parse(Console.ReadLine());


//     if (idade >=  18){
//       Console.WriteLine("você é maior de idade");
//       Console.WriteLine("Você está apto a votar e a dirigir.");
     
//     }


//     else if (idade < 18){
//       Console.WriteLine("Você é menor de idade");
//       Console.WriteLine("Você não está apto a votar e nem dirigir.");
   
//     }


// Questão 7
// // Função que calcula a média de três notas
//     static float CalcularMedia(float nota1, float nota2, float nota3)
//     {


//     //calcular media das tres notas
//       float media = (nota1 + nota2 + nota3) / 3;
//       return media;


//     }


//     static void Main()
//     {
//       // Solicita ao usuário que insira as três notas
//       Console.WriteLine("Digite a primeira nota:");
//       float nota1 = float.Parse(Console.ReadLine());


//       Console.WriteLine("Digite a segunda nota:");
//       float nota2 = float.Parse(Console.ReadLine());


//       Console.WriteLine("Digite a terceira nota:");
//       float nota3 = float.Parse(Console.ReadLine());


//       // Chama a função CalcularMedia e armazena o resultado
//       float media = CalcularMedia(nota1, nota2, nota3);


//        // Exibe o resultado no console
//       Console.WriteLine($"A média das notas é:{media:F2} ");


//     }



// Questão 8
// // Escreva um programa que leia três números e determine o maior e o menor deles. Exiba o resultado no console.


//     // solicita ao usuário a inserir tres numeros
//     Console.WriteLine("Digite o primeiro número: ");
//     int n1 = int.Parse(Console.ReadLine());


//     Console.WriteLine("Digite o segundo número:");
//     int n2 = int.Parse(Console.ReadLine());


//     Console.WriteLine("Digite o terceiro número:");
//     int n3 = int.Parse(Console.ReadLine());


//     //determina o número maior
//     int maior = n1;


//     if (n2 > maior){
//       maior = n2;
//     }


//     if (n3 > maior){
//       maior = n3;
//     }


//     //determina o número menor
//     int menor = n1;


//     if (n2 < menor){
//       menor = n2;
//     }


//     if (n3 < menor){
//       menor = n3;
//     }


//     //exibe o número maior e o menor
//     Console.WriteLine($"O numero maior é {maior} e o número menor é {menor}");

// Questão 9
// int soma = 0;
//     int numero;


//     // Usando while para solicitar números até que o usuário digite 0
//     while (true)
//     {
//         Console.WriteLine("Digite um número (ou 0 para somar e sair):");
//         numero = int.Parse(Console.ReadLine());


//         if (numero == 0)
//         {
//             break; // Sai do loop quando o usuário digita 0
//         }


//         soma += numero;
//     }


//     // Exibe a soma de todos os números digitados
//     Console.WriteLine($"A soma de todos os números digitados é: {soma}");





// Questão 10
// // solicita o valor em reais ao usuario
//     Console.WriteLine("Digite o valor em reais");
//     double reais = double.Parse(Console.ReadLine());


//   // solicita o valor em dolares ao usuario;
//     Console.WriteLine("Digite taxa de câmbio");
//     double taxa = double.Parse(Console.ReadLine());


//   // conversão
//     double convertido = reais / taxa;


//     Console.WriteLine($"Valor convertido: {convertido}");
// questão 11
// Console.WriteLine("digite um numero inteiro");
   
//     int n = int.Parse(Console.ReadLine());


//     if (n < 0){
//       Console.WriteLine("nao é possivel calcular o um fatorial de um numero negativo");
     
//     }


//     else{
//       int resultado = CalcularFatorial(n);
//       Console.WriteLine($"o fatorial de {n} é o {resultado}");
     
//       }
   
//     static int CalcularFatorial(int n){
//       if (n == 0 || n == 1){
//         return 1;
       
//       }


//       else{
//         return n * CalcularFatorial(n - 1);
//       }
//     }
 
// Questão 12
// Console.WriteLine($"Digite um numero.");
// int n = int.Parse(Console.ReadLine());


// while(n <= 0 )
// {
//     Console.WriteLine($"Digite um numero positivo");
//     n = int.Parse(Console.ReadLine());
// }


// int a = 0;
// int b = 1;
// Console.WriteLine($"Sequencia de fibonacci ate {n}:");


// while(a <= n)
// {
//     Console.WriteLine(a);
//     int aux = a;
//     a = b;
//     b = aux + b;
// }

// Questão 13

