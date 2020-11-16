using Infra.Contexts;
using Infra.Repositories;
using Infra.Repositories.Interface;
using Infra.Services.Interfaces;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisualTicket.Entities;

namespace Infra.Services
{
    public class ChamadoService : IChamadoService
    {
        private readonly IChamadoRepository _repository;

        public ChamadoService()
        {
            _repository = new ChamadoRepository(new VisualTicketContext());
        }

        public IEnumerable<Chamado> ListarChamados()
        {
            return _repository.Select();
        }

        public Chamado GetChamado(int id)
        {
            return _repository.Select(id);
        }

        public void UpdateChamado(ChamadoViewModel chamado)
        {
            Chamado c = new Chamado
            {
                Descricao = chamado.Descricao,
                PrecisaAprovacao = chamado.PrecisaAprovacao,
                FuncionarioId = chamado.FuncionarioId,
                PrioridadeId = chamado.PrioridadeId,
                SeveridadeId = chamado.SeveridadeId,
                SistemaId = chamado.SistemaId,
                Titulo = chamado.Titulo,
                Id = chamado.Id
            };
            _repository.Update(c);
        }

        public void CriarChamado(ChamadoViewModel chamado)
        {
            Chamado c = new Chamado
            {
                Descricao = chamado.Descricao,
                PrecisaAprovacao = chamado.PrecisaAprovacao,
                FuncionarioId = chamado.FuncionarioId,
                PrioridadeId = chamado.PrioridadeId,
                SeveridadeId = chamado.SeveridadeId,
                SistemaId = chamado.SistemaId,
                Titulo = chamado.Titulo
            };

            _repository.Insert(c);

        }
    }
}