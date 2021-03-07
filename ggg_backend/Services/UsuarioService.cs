using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ggg_backend.Context;
using ggg_backend.Interfaces;
using ggg_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ggg_backend.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly MemmoryDatabaseContext _dbset;

        public UsuarioService(MemmoryDatabaseContext context)
        {
            _dbset = context;
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
            try
            {
                await _dbset.Usuario.AddAsync(usuario);
                await _dbset.SaveChangesAsync();
                return usuario;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Usuario> Delete(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> GetAllUsuario()
        {
            try
            {
                return await _dbset.Usuario.ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Usuario> GetUsuarioById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}