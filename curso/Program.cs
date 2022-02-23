using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta = new ContaCorrente();
conta.titular = "André Silva";
conta.conta = "12345-Y";
conta.agencia = "Agência Rua dos Bancos";
conta.saldo = 123.96;

//Console.WriteLine($"Títular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");


ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André Silva";
conta2.conta = "12345-Y";
conta2.agencia = "Agência Rua dos Bancos";
conta2.saldo = 123.96;

//Console.WriteLine($"Títular da conta: {conta2.titular}");
//Console.WriteLine($"Número da conta: {conta2.conta}");
//Console.WriteLine($"Agência: {conta2.agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

Console.WriteLine(">>> Tipo por valor");
double saldo2 = 123.96;
double saldo3 = conta2.saldo;
Console.WriteLine(saldo2== conta2.saldo);
Console.WriteLine(saldo2 == saldo3);

Console.WriteLine(">>> Tipo por referência");
Console.WriteLine(conta == conta2);

Console.WriteLine(conta.Equals(conta2));
Console.ReadKey();
