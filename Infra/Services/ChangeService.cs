using Domain.Entities;
using Infra.Contexts;
using Infra.Repositories;
using Infra.Repositories.Interface;
using Infra.Services.Interfaces;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infra.Services
{
    public class ChangeService : IChangeService
    {
        private readonly IChangeRepository _repository;

        public ChangeService()
        {
            _repository = new ChangeRepository(new VisualTicketContext());
        }

        public IEnumerable<Change> ListarChanges()
        {
            return _repository.Select();
        }

        public Change GetChange(int id)
        {
            return _repository.Select(id);
        }

        public void UpdateChange(ChangeViewModel cg)
        {
            Change p = new Change
            {
                Descricao = cg.Descricao,
                Titulo = cg.Titulo,
                Id = cg.Id,
                AreasImpactadas = cg.AreasImpactadas,
                DiaFim = cg.DiaFim,
                DiaInicio = cg.DiaInicio,
                LocalMudanca = cg.LocalMudanca,
                PodeTerRollback = cg.PodeTerRollback,
                PrioridadeId = cg.PrioridadeId,
                FuncionarioId = cg.FuncionarioId
            };
            _repository.Update(p);
        }

        public void CriarChange(ChangeViewModel cg)
        {
            Change c = new Change
            {
                Descricao = cg.Descricao,
                FuncionarioId = cg.FuncionarioId,
                Titulo = cg.Titulo,
                Email = cg.Email,
                Username = cg.Username,
                AreasImpactadas = cg.AreasImpactadas,
                DiaFim = cg.DiaFim,
                DiaInicio = cg.DiaInicio,
                LocalMudanca = cg.LocalMudanca,
                PodeTerRollback = cg.PodeTerRollback,
                PrioridadeId = cg.PrioridadeId
            };

            _repository.Insert(c);

        }

    }
}