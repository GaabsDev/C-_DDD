using Infra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualTicket.Entities;

namespace Infra.Services.Interfaces
{
    public interface IChamadoService
    {
        IEnumerable<Chamado> ListarChamados();
        Chamado GetChamado(int id);
        void UpdateChamado(ChamadoViewModel chamado);
        void CriarChamado(ChamadoViewModel chamado);
    }
}
