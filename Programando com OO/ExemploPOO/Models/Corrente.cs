namespace ExemploPOO.Models
{
    internal class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo += valor;
        }
    }
}
