/*
  Aula 05 -  Programação Estruturada 
  Renata Gardenia  - 08/04/2025 
*/ 
// EX1
Console.WriteLine("Informe o valor do produto 1: ");
double P1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do produto 2: ");
double P2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do produto 3: ");
double P3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do produto 4: ");
double P4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor do produto 5: ");
double P5 = Convert.ToDouble(Console.ReadLine());

double SOMA = P1 + P2 + P3 + P4 + P5;
Console.WriteLine("O valor da soma dos produtos é " + SOMA);

//EX2
int idade, anos, meses, dias;
Console.WriteLine("Informe a sua idade em dias: ");
idade = Convert.ToInt32(Console.ReadLine());

anos = idade / 365;
meses = (idade % 365) / 30;
dias = (idade % 365) % 30;
Console.WriteLine("Você tem " + anos + " anos e " + meses + " meses e " + dias + " dias de idade.");

//EX3
int Fahrenheit, Celsius;
Console.WriteLine("Informe o valor da temperatura em Fahrenheit: ");
Fahrenheit = Convert.ToInt32(Console.ReadLine());
Celsius = (5 * (Fahrenheit - 32)) / 9;
Console.WriteLine("O valor da temperatura em graus celsius é " + Celsius);

//EX4
int N1, N2, Quociente, Resto;
Console.WriteLine("Informe o valor 1:");
N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor 2:");
N2 = Convert.ToInt32(Console.ReadLine());
Quociente = N1 / N2;
Resto = N1 - (Quociente * N2);
Console.WriteLine("O quociente é " + Quociente + " e o resto é " + Resto);

//EX5
int aux, v1, v2;
Console.WriteLine("Valor 1: ");
v1 = int.Parse(Console.ReadLine());
Console.WriteLine("Valor 2: ");
v2 = int.Parse(Console.ReadLine());

aux = v1;
v1 = v2;
v2 = aux;

Console.WriteLine("O  valor 1 é {0} e valor 2 é {1}", v1, v2);
//EX6
double x, y, resultado;
Console.Write("Primeiro número: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: ");
y = Convert.ToInt32(Console.ReadLine());

resultado = Math.Pow(x, y);

Console.WriteLine("O resultado de {0} elevado a {1} é  {2}", x, y, resultado);
