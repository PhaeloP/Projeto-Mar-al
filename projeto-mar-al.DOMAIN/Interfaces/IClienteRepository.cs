using projeto_mar_al.DOMAIN.Entidadedes;

namespace projeto_mar_al.DOMAIN.Interfaces
{
    public interface IClienteRepository
    {
        Cliente? SelectDadosDoCliente(string id);
    }
}
