using Domain.Entities;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Services.Interfaces
{
    public interface IProblemService
    {
        IEnumerable<Problem> ListarProblems();
        Problem GetProblem(int id);
        void CriarProblem(ProblemViewModel problem);
        void UpdateProblem(ProblemViewModel problem);
    }
}
