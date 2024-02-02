namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal precoLavaRapido = 0;
        private string respostaLavaRapido;

        private decimal horas = 0;
        private HashSet<string> veiculos = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public Estacionamento(decimal precoInicial, decimal precoPorHora, decimal precoLavaRapido)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.precoLavaRapido = precoLavaRapido;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Veículo já cadastrado!");
                return;
            }

            Console.Write("Deseja adicionar serviço de lava-rápido? (S/N): ");
            respostaLavaRapido = Console.ReadLine().ToUpper();
                       
            if(respostaLavaRapido == "S") 
            {
                placa += "ComLavaRapido";
            }

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Veiculo já cadastrado!");
                return;
            }

            veiculos.Add(placa);

            

            decimal valorTotal = precoInicial + precoPorHora * horas + (respostaLavaRapido == "S" ? precoLavaRapido : 0);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas + (respostaLavaRapido == "S" ? precoLavaRapido : 0);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
