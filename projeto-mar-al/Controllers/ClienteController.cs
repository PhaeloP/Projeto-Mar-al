using Microsoft.AspNetCore.Mvc;
using projeto_mar_al.APPLICATION;
//TODO: troca a rota para api/cliente sem S
[ApiController]
[Route("api/clientes")] 
public class ClienteController : ControllerBase
{
    private readonly ObterClientes _obterClientes;

    public ClienteController(ObterClientes obterClientes)
    {
        _obterClientes = obterClientes;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var cliente = _obterClientes.Executar(id);

        if (cliente == null)
            return NotFound();

        return Ok(cliente);
    }
}
