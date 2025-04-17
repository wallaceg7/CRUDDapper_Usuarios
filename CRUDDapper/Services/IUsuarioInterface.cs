using CRUDDapper.Dto;
using CRUDDapper.Models;

namespace CRUDDapper.Services
{
    public interface IUsuarioInterface
    {
        // Tipo de retorno + nome do método + parametros de entrada caso receba
        Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios();
        Task<ResponseModel<UsuarioListarDto>> BuscarUsuarioPorId(int usuarioId);
        Task<ResponseModel<List<UsuarioListarDto>>> CriarUsuario(UsuarioCriarDto usuario);
    }
}
