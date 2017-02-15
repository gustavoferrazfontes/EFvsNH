using CineClick.Dominio.EF;
using CineClick.Dominio.NHibernate.AgregadoDeProgramacao;
using CineClick.Infra.NHibernate;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CineClick.Tests.NHibernate.Tests
{
    public class NH_Pogramacao_Tests
    {
        //TODO: verificar se o ID for igual, o NH realiza update do obj desatachado da sessao.

        private readonly RepositorioDeProgramacao _repProgramacao;
        public NH_Pogramacao_Tests()
        {
            _repProgramacao = new RepositorioDeProgramacao();
        }

        [Fact(DisplayName = "cria uma nova programacao para uma programação")]
        public void adicionar_uma_nova_programacao()
        {

            var filmeId = Guid.Parse("E0A6679D-50CD-4190-8F84-E3B3BBE1416E");
            var salaId = Guid.Parse("49DD717A-604D-4A3B-80BA-87604D1D8664");
            var exibicao = new PeriodoDeExibicao(DateTime.Now, DateTime.Now.AddDays(20));

            var sessoes = new List<Sessao> { new Sessao(salaId, filmeId, DateTime.Now, true) };

            var programacao = new Programacao(exibicao, sessoes);

            _repProgramacao.Salvar(programacao);
        }


        [Fact(DisplayName = "cria uma nova sessão para uma programação")]
        public void adicionar_uma_sessao_a_programacao()
        {
            var programacaoId = Guid.Parse("C1006F10-327D-45DB-A928-03301BD74825");
            var filmeId = Guid.Parse("E0A6679D-50CD-4190-8F84-E3B3BBE1416E");
            var salaId = Guid.Parse("49DD717A-604D-4A3B-80BA-87604D1D8664");

            var sessao = new Sessao(salaId, filmeId, DateTime.Now, true);


            var programacao = _repProgramacao.ObterPor(programacaoId);
            programacao.AdicionarSessao(sessao);

            _repProgramacao.Editar(programacao);

            _repProgramacao.ObterPor(programacaoId).Sessoes.Count().Should().BeGreaterOrEqualTo(2);

        }

        [Fact(DisplayName = "Consulta uma programação")]
        public void _obter_programacao_por_id()
        {
            var programacaoId = Guid.Parse("c1006f10-327d-45db-a928-03301bd74825");
            var programacao = _repProgramacao.ObterPor(programacaoId);

            programacao.Should().NotBeNull();
            programacao.Sessoes.Should().NotBeNull();
            programacao.Sessoes.Count().Should().BeGreaterOrEqualTo(0);
        }

        [Fact(DisplayName = "remove uma sessão da programacão")]
        public void remover_sessao_da_programacao()
        {
            var programacaoId = Guid.Parse("c1006f10-327d-45db-a928-03301bd74825");
            var programacao = _repProgramacao.ObterPor(programacaoId);

            var sessao = programacao.Sessoes.First();
            programacao.SessaoIndisponivel(sessao);
            _repProgramacao.Editar(programacao);

            _repProgramacao.ObterPor(programacaoId).Sessoes.Should().NotContain(sessao);

        }

    }
}
