// See https://aka.ms/new-console-template for more information
Console.WriteLine("O objeto está se movendo (S/N)?");
char resposta = char.Parse(Console.ReadLine().ToUpper());

if (resposta == 'S')
{
    Console.WriteLine("Deveria? (S/N)");
    resposta = char.Parse(Console.ReadLine().ToUpper());
    if (resposta == 'S')
    {
        Console.WriteLine("Ótimo!");
    }
    else
    {
        Console.WriteLine("Use Silver Tape");
    }
}
else
{
    Console.WriteLine("Deveria? (S/N)");
    resposta = char.Parse(Console.ReadLine().ToUpper());
    if (resposta == 'S')
    {
        Console.WriteLine("Use WD-40");
    }
    else
    {
        Console.WriteLine("Ótimo!");
    }
}