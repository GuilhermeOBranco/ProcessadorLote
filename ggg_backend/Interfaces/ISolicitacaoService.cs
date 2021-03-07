using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ggg_backend.Models;

namespace ggg_backend.Interfaces
{
    public interface ISolicitacaoService
    {
        Task<List<Solicitacao>> GetAllSolicitacao();
        Task<Solicitacao> GetSolicitacaoById(int Id);
        Task<Solicitacao> Create(Solicitacao solicitacao);
        Task<Solicitacao> Update(Solicitacao solicitacao);
        Task<Solicitacao> Delete(int solicitacaoId);
    }
}