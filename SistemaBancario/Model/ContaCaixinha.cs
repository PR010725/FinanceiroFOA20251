

namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {

        public ContaCaixinha(decimal saldo) : base(saldo)
        {
        }
        public ContaCaixinha(Cliente cliente) : base(cliente)
        {
        }
        public override void Depositar(decimal valor)
        {
            if (valor < 1)
                throw new ArgumentOutOfRangeException("O valor do depósito deve ser maior ou igual a 1.");
            Saldo += valor + 1;
        }
        public override void Sacar(decimal valor)
        {
            if (valor < 1)
                throw new ArgumentOutOfRangeException("O valor do saque deve ser maior ou igual a 1.");
           
            base.Sacar(valor + 5);
        }

    }
}
