using bytebank.Contas;
using bytebank.Titular;
using System;
/*   
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.saldo);

if (contaDoAndre.Sacar(300) == true)
{ 
Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
}
else
{
Console.WriteLine("Saldo insuficiente para saque");
} 

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = "Pedro Silva";
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.conta); */

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "00000000000";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular " + conta.titular.nome);
//Console.WriteLine("CPF " + conta.titular.cpf);
//Console.WriteLine("Profissão " + conta.titular.profissao);
//Console.WriteLine("N° Conta " + conta.conta);
//Console.WriteLine("Saldo " + conta.saldo);
//Console.WriteLine("N° Agência " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "1234567890";
//conta2.titular.profissao = "tester";
//conta2.conta = "9090-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome); 

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011=H";
//conta3.SetSaldo(1000);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283,"123-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284,"321-Y");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(764, "456-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta8 = new ContaCorrente(143, "573-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);