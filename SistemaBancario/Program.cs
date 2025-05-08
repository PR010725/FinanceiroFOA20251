// See https://aka.ms/new-console-template for more information

using SistemaBancario.Model;

Cliente cliente1 = new Cliente("Maria", "123456789000");
Conta conta1 = new Conta(cliente1);

Console.WriteLine($"A conta de número {conta1.Numero} pertence ao cliente {conta1.Titular.Nome}");

ContaEspecial conta 2 = new ContaEspecial(1000, 500);
Conta conta3 = new ContaEspecial(2000, 1000);

conta3.Depositar(500);
conta3.Sacar(1000);
