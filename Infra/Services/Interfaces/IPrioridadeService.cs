using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTicket.Entities;

namespace Infra.Services.Interfaces
{
    public interface IPrioridadeService
    {
        IEnumerable<Prioridade> ListarPrioridades();
    }
}
