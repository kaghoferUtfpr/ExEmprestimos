namespace ExEmprestimos.Entidades
{
    internal class Contrato
    {
        public int Number { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public List<Parcela> Parcelas { get; set; }


    }
}
