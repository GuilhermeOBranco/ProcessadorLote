using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ggg_backend.Context;
using ggg_backend.Interfaces;
using ggg_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ggg_backend.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly MemmoryDatabaseContext _dbset;
        public SolicitacaoService(MemmoryDatabaseContext context)
        {
            _dbset = context;   
        }
        public async Task<Solicitacao> Create(Solicitacao solicitacao)
        {
            await _dbset.Solicitacao.AddAsync(solicitacao);
            _dbset.SaveChanges();
            return solicitacao;
        }

        public Task<Solicitacao> Delete(int solicitacaoId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Solicitacao>> GetAllSolicitacao()
        {
           return await _dbset.Solicitacao.Where( x=> x.Id != 0).ToListAsync();        
        }

        public Task<Solicitacao> GetSolicitacaoById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Solicitacao> Update(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }
    }
}