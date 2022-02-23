using bytebank;

Console.WriteLine("Bem vindo ao seu banco,  Bytebank ");

ContaCorrente conta1 = new ContaCorrente("012596-X",789,"Agencia Central",188,"André Silva");
conta1.Sacar(30);
conta1.Depositar(60);
Console.WriteLine($"Saldo => {conta1.Saldo}");

ContaCorrente conta2 = new ContaCorrente("5248616-X", 963, "Agencia Marataízes", 100, "Barbará Menezes");
conta1.Sacar(96);
conta1.Depositar(135);
Console.WriteLine($"Saldo => {conta2.Saldo}");

//Transferir
conta1.Transferir(37, conta2);
Console.WriteLine($"Saldo => {conta1.Saldo}");
Console.WriteLine($"Saldo => {conta2.Saldo}");

Console.ReadKey();