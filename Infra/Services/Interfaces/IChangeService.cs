using Domain.Entities;
using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Services.Interfaces
{
    public interface IChangeService
    {
        IEnumerable<Change> ListarChanges();
        Change GetChange(int id);
        void CriarChange(ChangeViewModel cg);
        void UpdateChange(ChangeViewModel cg);
    }
}
