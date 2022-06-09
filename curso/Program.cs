using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 123;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André Silva";
conta2.conta = "10123-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;


conta1 = conta2;

Console.WriteLine(conta1==conta2);
Console.WriteLine("------------------------");

ContaCorrente conta3 = new ContaCorrente();

Console.WriteLine("Titular :" + conta1.titular);
Console.WriteLine("Conta :" + conta1.conta);
Console.WriteLine("Número Agência :" + conta1.numero_agencia);
Console.WriteLine("Nome Agência :" + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("-------------------------------------");
Console.WriteLine("Titular :" + conta3.titular);
Console.WriteLine("Conta :" + conta3.conta);
Console.WriteLine("Número Agência :" + conta3.numero_agencia);
Console.WriteLine("Nome Agência :" + conta3.nome_agencia);
Console.WriteLine("Saldo: " + conta3.saldo);
Console.WriteLine("Verificador "+conta3.verificador);

Console.WriteLine("--------------------------------------------------");

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.nome_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

Console.ReadKey();

