# Classificação de idade em C#

Exercício de condicionais que classifica uma idade inteira não negativa. Sem argumento, usa o exemplo original, 15 anos.

Com o SDK .NET 10, execute `dotnet run` na raiz. Para testar outra idade, use, por exemplo, `dotnet run -- 60`.

| Entrada | Saída |
|---|---|
| Sem argumento | `Adolescente` |
| `11` | `Criança` |
| `12` a `17` | `Adolescente` |
| `18` a `59` | `Adulto` |
| `60` | `Idoso` |
| `-1` ou `abc` | `Informe uma idade inteira não negativa.` (código de saída 1) |
