using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "12345-Y";
conta1.codigo_agencia = 123;
conta1.nome_agencia = "Agência Rua dos Bancos";
conta1.saldo = 123.96;

Console.WriteLine($"Títular da conta: {conta1.titular}");
Console.WriteLine($"Número da conta: {conta1.conta}");
Console.WriteLine($"Agência: {conta1.codigo_agencia} - {conta1.nome_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta1.saldo)}");


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Silva";
//conta2.conta = "625433-Y";
//conta2.codigo_agencia = 321;
//conta2.nome_agencia = "Agência Rua 25 de Março";
//conta2.saldo = 5156.9;

//Console.WriteLine($"Títular da conta: {conta2.titular}");
//Console.WriteLine($"Número da conta: {conta2.conta}");
//Console.WriteLine($"Agência: {conta2.codigo_agencia} - {conta2.nome_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta2.saldo)}");

//if (conta2.saldo >= 100)
//{
//    conta2.saldo -= 100;
//}

Console.WriteLine(conta1.saldo);
bool resultadoSaque = conta1.Sacar(500);
Console.WriteLine(conta1.saldo);
Console.WriteLine(resultadoSaque);

Console.ReadKey();