using projeto_mar_al.DOMAIN;
using projeto_mar_al.DOMAIN.Entidades;



namespace projeto_mar_al.DOMAIN.Interfaces
{
    public interface IClienteRepository
    {
        Cliente? SelectDadosDoCliente(string id);
    }
}
