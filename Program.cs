Console.WriteLine("Digite seu nome!");
Console.ReadLine();
Console.WriteLine("Agora Digite Sua Idade!");
int a = int.Parse(Console.ReadLine());

if (a >=18)
{
    Console.WriteLine("Você é um adulto!");
}

else if (a <= 17 && a >=13)
{
    Console.WriteLine("Você é um Adolecente!");
}

else
{
    Console.WriteLine("Você é uma criança");
}
Console.WriteLine("Agora coloca dois numero aletorio ai");

int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.WriteLine(c+b);

