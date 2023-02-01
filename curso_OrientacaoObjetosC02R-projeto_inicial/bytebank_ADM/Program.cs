using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("12345678900", 2000);
//pedro.Nome = "Pedro Silva";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("00987654321");
//roberta.Nome= "Roberta Pereira";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salario do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salario da Roberta: " + roberta.Salario);
#endregion
// CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12345678");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("9876543");
    paula.Nome = "Paula Souza";

    Auxiliar higor = new Auxiliar("34567890");
    higor.Nome = "Higor Pereira";

    GerenteDeContas camila = new GerenteDeContas("56789123");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(higor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("897345");
    ingrid.Nome = "Ingrid Raquel";
    ingrid.Senha = "123";

    GerenteDeContas ana = new GerenteDeContas("5678123");
    ana.Nome = "Ana Clara";
    ana.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ana, "000");
    sistema.Logar(caio, "999");
}