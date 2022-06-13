using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");



//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "Marcos Teixeira";
//conta3.titular.titular_cpf = "854855411-8";
//conta3.titular.titular_profissao = "DEV";

//conta3.conta = "87455144-y";
//conta3.numero_agencia = 54;
//conta3.nome_agencia = "Central";

//Console.WriteLine(conta3.titular.nome);
//Console.WriteLine("Profissão: "+conta3.titular.titular_profissao);

ContaCorrente conta4 = new ContaCorrente();

conta4.Saldo=-150;
Console.WriteLine("Saldo: "+ conta4.Saldo);


Console.ReadKey();
