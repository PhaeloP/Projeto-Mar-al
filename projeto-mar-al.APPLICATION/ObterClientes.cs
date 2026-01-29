using projeto_mar_al.DOMAIN.Interfaces;
using projeto_mar_al.DOMAIN.Entidades;


namespace projeto_mar_al.APPLICATION;

public class ObterClientes
{
    private readonly IClienteRepository _repository;

    public ObterClientes(IClienteRepository repository)
    {
        _repository = repository;
    }

    public Cliente? Executar(string id)
    {
        return _repository.SelectDadosDoCliente(id);
    }
}
