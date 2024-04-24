namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            try
            {
                if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }

                else
                {
                    throw new Exception("Capacidade do hotel excedida.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar hóspedes: {ex.Message}");
            }
        
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;   

            if (DiasReservados >= 10)
            {
                Console.WriteLine("\n**Promoção baixa temporada, desconto de 10% aplicado com sucesso!**");
                decimal valorDesconto = valor*0.10M;
                Console.WriteLine($"Total desconto: R${valorDesconto}");
                valor = valor - valorDesconto;
                
            }
                return valor;
        }
    }
}