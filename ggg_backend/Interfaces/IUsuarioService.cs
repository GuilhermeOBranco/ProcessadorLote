using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ggg_backend.Models;

namespace ggg_backend.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetAllUsuario();
        Task<Usuario> GetUsuarioById(int Id);
        Task<Usuario> Create(Usuario usuario);
        Task<Usuario> Update(Usuario usuario);
        Task<Usuario> Delete(int usuarioId);
    }
}