using byteBank2._0.Contas;
using byteBank2._0.Titular;


ContaCorrente conta5 = new ContaCorrente(283, "1134-X");//ACESSANDO O METODO STATIC
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente.TotalDeContasCriadas = 100;

ContaCorrente conta6 = new ContaCorrente(238, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);  //ACESSANDO O METODO STATIC

ContaCorrente conta7 = new ContaCorrente(382, "4321-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);  //ACESSANDO O METODO STATIC




















//ContaCorrente conta4 = new ContaCorrente(18, "1010-X"); //PARAMETROS DO MÉTODO CONSTRUTOR
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();


//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);




















//ContaCorrente conta3 = new ContaCorrente();
//Cliente lucas = new Cliente();
//lucas.Cpf = "123456789";
//conta3.SetSaldo(-10);
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";

//Console.WriteLine(conta3.Conta);
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(lucas.Cpf);
//Console.WriteLine(conta3.GetSaldo());






















//Cliente clienteLucas = new Cliente();
//clienteLucas.nome = "Lucas Vieira";
//clienteLucas.cpf = "012345678";
//clienteLucas.profissao = "Analista";


//ContaCorrente contaDoLucas = new ContaCorrente();
//contaDoLucas.titular = clienteLucas;
//contaDoLucas.conta = "1010-X";
//contaDoLucas.numero_agencia = 15;
//contaDoLucas.saldo = 100;

//Console.WriteLine("Titular: " + contaDoLucas.titular.nome);
//Console.WriteLine("Cpf: " + contaDoLucas.titular.cpf);
//Console.WriteLine("Profissão: " + contaDoLucas.titular.profissao);
//Console.WriteLine("Numero de Conta: " + contaDoLucas.conta);
//Console.WriteLine("Saldo: " + contaDoLucas.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();     //REFERENCIA PARA CRIAR O TITULAR (CLIENTE)
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Desenvolvedor C#";
//conta2.titular.cpf = "123456789";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);




//using byteBank2._0;


//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.saldo = 100;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.numero_agencia = 15;

//Console.WriteLine("Nome: " + contaDoAndre.titular
//    + "\nSaldo: " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.saldo = 100;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.numero_agencia = 15;

//Console.WriteLine("Nome: " + contaDoAndre2.titular
//    + "\nSaldo: " + contaDoAndre2.saldo);

//Console.WriteLine(contaDoAndre == contaDoAndre2);


//contaDoAndre.Depositar(10);
//Console.WriteLine("Novo saldo do André: " + contaDoAndre.saldo);


//ContaCorrente contaDaMaira = new ContaCorrente();
//contaDaMaira.titular = "Maria Souza";
//contaDaMaira.numero_agencia = 17;
//contaDaMaira.conta = "1010-X";
//contaDaMaira.saldo = 350;

//Console.WriteLine("Saldo da conta da Maira = " + contaDaMaira.saldo);

//contaDoAndre.Transferir(50, contaDaMaira);

//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaira.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Lucas Vieira";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

Console.ReadKey();