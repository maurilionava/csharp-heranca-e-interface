using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;

GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

Funcionario johnDoe = new Funcionario("John Doe", "12332112332", 1000);
Diretor maryDoe = new Diretor("Mary doe", "97878998778", 2000);

gerenciadorDeBonificacao.Registrar(johnDoe);
gerenciadorDeBonificacao.Registrar(maryDoe);

Console.WriteLine("Total de bonificação $ {0}", gerenciadorDeBonificacao.TotalBonificacao.ToString("0.00"));