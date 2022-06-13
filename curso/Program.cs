using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

/*ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Marcos Teixeira";
conta1.conta = "110123-X";
conta1.numero_agencia = 123;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Renata Olga";
conta2.conta = "10123-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

double saldo = 100;*/

//conta1 = conta2;

//Console.WriteLine(conta1.saldo == saldo);
//Console.WriteLine("------------------------");

//Console.WriteLine("Saldo da Renata pré-saque: " + conta2.saldo);
//conta2.Sacar(50);
//bool saque = conta2.Sacar(50);
//Console.WriteLine("Saque realizado?"+ saque);
//Console.WriteLine("Saldo da Renata pós-saque: " + conta2.saldo);

//conta2.Depositar(60);
//Console.WriteLine("Saldo da Renata pós-deposito: " + conta2.saldo);

/*Console.WriteLine("Saldo da Renata pré-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do Marcos pré-transferência: " + conta1.saldo);
conta1.Transferir(50, conta2);
bool transferencia=conta1.Transferir(50, conta1);
Console.WriteLine("Transferencia efetuada? "+ transferencia);
Console.WriteLine("Saldo da Renata pos-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do Marcos pos-transferência: " + conta1.saldo);

conta2.ExibirDadosDaConta();*/

//Cliente cliente = new Cliente();

//cliente.nome = "Marcos Teixeira";
//cliente.titular_cpf = "854.6589.65.88";
//cliente.titular_profissao="Estagiario Dev";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "Marcos Teixeira";
conta3.titular.titular_cpf = "854855411-8";
conta3.titular.titular_profissao = "DEV";

conta3.conta = "87455144-y";
conta3.numero_agencia = 54;
conta3.nome_agencia = "Central";
//Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);
Console.WriteLine("Profissão: "+conta3.titular.titular_profissao);


Console.ReadKey();
