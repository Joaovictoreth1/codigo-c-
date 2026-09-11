int idade = 15; //até 11 criança, 12 ao 17 adolescente, 18 ao 59 adulto e 60 em diante idosoif(idade <= 11)
{
    Console.WriteLine("Criança");
}else if (idade >= 12 && idade <= 17)
{
    Console.WriteLine("Adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
}
