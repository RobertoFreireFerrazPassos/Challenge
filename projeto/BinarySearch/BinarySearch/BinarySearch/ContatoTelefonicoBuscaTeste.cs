using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace BinarySearch
{
    public class ContatoTelefonicoBuscaTeste
    {
        private readonly ITestOutputHelper output;

        public ContatoTelefonicoBuscaTeste(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Must_Find_Value_In_Order_List()
        {
            var lista = ObterListaContatoTelefonico();

            foreach (var contato in lista)
            {
                var telefoneEncontrado = lista.BuscaTelefone(contato.Nome);

                output.WriteLine("Contato: {0} - {1}", contato.Nome, telefoneEncontrado);

                telefoneEncontrado.Should().Be(contato.Telefone);
            }            
        }

        private List<ContatoTelefonico> ObterListaContatoTelefonico()
        {
            return new List<ContatoTelefonico>()
            {
                new ContatoTelefonico() { Telefone = "(67) 2021-1651", Nome = "Alexia Fogaça" },
                new ContatoTelefonico() { Telefone = "(94) 3320-6821", Nome = "Carlos Eduardo Melo" },
                new ContatoTelefonico() { Telefone = "(12) 3545-3475", Nome = "Davi Lucca Barros" },
                new ContatoTelefonico() { Telefone = "(82) 2976-5565", Nome = "Elisa Sales" },
                new ContatoTelefonico() { Telefone = "(61) 3383-5715", Nome = "Enrico Freitas" },
                new ContatoTelefonico() { Telefone = "(93) 2202-4361", Nome = "Francisco Moreira" },
                new ContatoTelefonico() { Telefone = "(27) 3286-3639", Nome = "Gustavo Henrique Monteiro" },
                new ContatoTelefonico() { Telefone = "(88) 3978-2835", Nome = "Lara Freitas" },
                new ContatoTelefonico() { Telefone = "(83) 3527-8568", Nome = "Luiz Miguel Aragão" },
                new ContatoTelefonico() { Telefone = "(61) 3772-3313", Nome = "Marcos Vinicius Barbosa" },
                new ContatoTelefonico() { Telefone = "(35) 2732-3573", Nome = "Maria Luiza Correia" },
                new ContatoTelefonico() { Telefone = "(35) 2732-3573", Nome = "Maria Vitória da Costa" },
                new ContatoTelefonico() { Telefone = "(92) 2530-1632", Nome = "Matheus Aragão" },
                new ContatoTelefonico() { Telefone = "(61) 2415-4419", Nome = "Miguel Costela" },
                new ContatoTelefonico() { Telefone = "(92) 2038-2764", Nome = "Murilo Novaes" },
                new ContatoTelefonico() { Telefone = "(69) 3548-5128", Nome = "Pedro Miguel Farias" },
                new ContatoTelefonico() { Telefone = "(62) 2430-6468", Nome = "Pietra Araújo" },
                new ContatoTelefonico() { Telefone = "(47) 2401-1933", Nome = "Pietra Cardoso" },
                new ContatoTelefonico() { Telefone = "(85) 2828-8267", Nome = "Sr.André Teixeira" },
                new ContatoTelefonico() { Telefone = "(66) 3619-4722", Nome = "Sr.João Miguel Jesus" },
                new ContatoTelefonico() { Telefone = "(89) 2652-8233", Nome = "Sr.Nathan Cardoso" }
            };
        }
    }
}