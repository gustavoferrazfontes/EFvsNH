using CineClick.Dominio.EF;
using CineClick.Dominio.EF.AgregadoDeProgramacao;
using CineClick.Infra.EF;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CineClick.Tests.EntityFramework.Tests
{
    public class EF_Programacao_Tests
    {
        private readonly RepositorioDeProgramacao _repProgramacao;  
        public EF_Programacao_Tests()
        {

            _repProgramacao = new RepositorioDeProgramacao();
        }

        [Fact(DisplayName = "cria uma nova programacao para uma programação")]
        public void adicionar_uma_nova_programacao()
        {
            
            var filmeId = Guid.Parse("E0A6679D-50CD-4190-8F84-E3B3BBE1416E");
            var salaId = Guid.Parse("4D7D7B13-90B6-4E9A-9693-701EF99AAE4D");
            var exibicao = new PeriodoDeExibicao(DateTime.Now, DateTime.Now.AddDays(20));
            var sessoes = new List<Sessao> { new Sessao(filmeId, salaId, DateTime.Now, true) };

            var programacao = new Programacao(exibicao, sessoes);

            _repProgramacao.Criar(programacao);
        }


        [Fact(DisplayName = "cria uma nova sessão para uma programação")]
        public void adicionar_uma_sessao_a_programacao()
        {
            var programacaoId = Guid.Parse("C1006F10-327D-45DB-A928-03301BD74825");
            var filmeId = Guid.Parse("E0A6679D-50CD-4190-8F84-E3B3BBE1416E");
            var salaId = Guid.Parse("4D7D7B13-90B6-4E9A-9693-701EF99AAE4D");

            var exibicao = new PeriodoDeExibicao(DateTime.Now, DateTime.Now.AddDays(20));
            
            var sessao = new Sessao(filmeId, salaId, DateTime.Now, true);


            var programacao = _repProgramacao.ObterPor(programacaoId);
            programacao.AdicionarSessao(sessao);

            _repProgramacao.Editar(programacao);

            _repProgramacao.ObterPor(programacaoId).Sessoes.Count().Should().Equals(programacao.Sessoes.Count());

        }



        [Fact(DisplayName = "Consulta uma programação")]
        public void _obter_programacao_por_id()
        {
            var programacaoId = Guid.Parse("c1006f10-327d-45db-a928-03301bd74825");
            var programacao = _repProgramacao.ObterPor(programacaoId);

            programacao.Should().NotBeNull();
            programacao.Sessoes.Should().NotBeNull();
        }

        [Fact(DisplayName = "remove uma sessão da programacão")]
        public void remover_sessao_da_programacao()
        {
            var programacaoId = Guid.Parse("275791FE-8577-4DF2-9C7F-48035FCD68D0");
            var programacao = _repProgramacao.ObterPor(programacaoId);

            var sessao = programacao.Sessoes.First();
            programacao.SessaoIndisponivel(sessao);
            _repProgramacao.Editar(programacao);

            _repProgramacao.ObterPor(programacaoId).Sessoes.Should().NotContain(sessao);

        }
    }
}
