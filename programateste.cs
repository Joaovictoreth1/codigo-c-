int idade = 15;
if (args.Length > 1 || (args.Length == 1 && (!int.TryParse(args[0], out idade) || idade < 0)))
{
    Console.Error.WriteLine("Informe uma idade inteira não negativa.");
    return 1;
}

if (idade <= 11)
{
    Console.WriteLine("Criança");
}
else if (idade <= 17)
{
    Console.WriteLine("Adolescente");
}
else if (idade <= 59)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
}

return 0;
