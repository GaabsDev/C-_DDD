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
    public class ProblemService : IProblemService
    {
        private readonly IProblemRepository _repository;

        public ProblemService()
        {
            _repository = new ProblemRepository(new VisualTicketContext());
        }

        public IEnumerable<Problem> ListarProblems()
        {
            return _repository.Select();
        }

        public Problem GetProblem(int id)
        {
            return _repository.Select(id);
        }

        public void UpdateProblem(ProblemViewModel problem)
        {
            Problem p = new Problem
            {
                Descricao = problem.Descricao,
                Causa = problem.Causa,
                FuncionarioId = problem.FuncionarioId,
                Titulo = problem.Titulo,
                Id = problem.Id,
                Impactos = problem.Impactos,
                NumChamado1 = problem.NumChamado1,
                NumChamado2 = problem.NumChamado2,
                Email = problem.Email,
                Username = problem.Username
            };
            _repository.Update(p);
        }

        public void CriarProblem(ProblemViewModel problem)
        {
            Problem p = new Problem
            {
                Descricao = problem.Descricao,
                Causa = problem.Causa,
                FuncionarioId = problem.FuncionarioId,
                Titulo = problem.Titulo,
                Impactos = problem.Impactos,
                NumChamado1 = problem.NumChamado1,
                NumChamado2 = problem.NumChamado2,
                Email = problem.Email,
                Username = problem.Username
            };

            _repository.Insert(p);

        }
    }
}