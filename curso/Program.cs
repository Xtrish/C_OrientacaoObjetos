using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "110123-X";
conta1.numero_agencia = 123;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Titular :"+conta1.titular);
Console.WriteLine("Conta :" + conta1.conta);
Console.WriteLine("Número Agência :" + conta1.numero_agencia);
Console.WriteLine("Nome Agência :" + conta1.nome_agencia);
Console.WriteLine("Saldo: "+conta1.saldo);