/*for(int i = 1; i <= 10; i++){
Console.WriteLine(i);
}
*/
/*for(int i = 10; i >= 1; i--){
Console.WriteLine(i);
}
*/

/*int cont = 0;
for(int i = 1; i <= 5; i++){
Console.WriteLine("Me diga um número!");
int num = int.Parse(Console.ReadLine()!);
if(num % 2 == 0){
  cont++;
} else{
  Console.WriteLine("Seu número é impar!");
}
Console.WriteLine($"Seus números pares até agora são: {cont}");
}*/

/*
int tabuada = 5;
  Console.WriteLine("Vamos olhar a tabuada do 5, me diga um número de 1-10!");

for(int i = 1; i <= 10; i++){
  Console.WriteLine("Seu número vezes 5 é: " + i * tabuada);
}
*/

/*Console.WriteLine("De qual número você quer saber a tabuada hoje?");
int tabuada = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= 10; i++){
  Console.WriteLine($"{i} * {tabuada} = {i*tabuada}");
}*/

/*int soma = 0;
Console.WriteLine("Vamos calcular a soma dos números pares!");
int num = int.Parse(Console.ReadLine()!);
for(int i = 2; i <= num; i += 2){
  soma += i;
}
Console.WriteLine($"Sua soma de números de 1 a {num} é: {soma}");
*/


/*double num, fatorial = 1;
Console.WriteLine("Me diga um número pra eu calcular!");
num = Convert.ToDouble(Console.ReadLine()!);
for(double i = num; i >=1; i--){
  fatorial *= i;
  Console.WriteLine($"{fatorial} * {i}");
}

Console.WriteLine($"O fatorial de {num} é {fatorial}");
*/



int menor = 0;
Console.WriteLine("Quantos números você vai inserir?");
int qnt = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= qnt; i++){
  Console.WriteLine("Digite um número!");
int num = int.Parse(Console.ReadLine()!);

  if(i == 1 ){
    menor = num;
  } else if (num < menor){
    menor = num;
  }
}

Console.WriteLine($"Seu menor número foi {menor}");


/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */