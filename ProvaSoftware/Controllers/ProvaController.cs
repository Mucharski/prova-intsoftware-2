using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaSoftware.Data;

namespace ProvaSoftware.Controllers;

[ApiController]
[Route("[controller]")]
public class ProvaController : ControllerBase
{
    private readonly Context _context;

    public ProvaController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("Listar")]
    public async Task<IActionResult> List()
    {
        return Ok(await _context.FolhaPagamento.ToListAsync());
    }
    
    [HttpGet]
    [Route("Total")]
    public async Task<IActionResult> Total()
    {
        var folhas = await _context.FolhaPagamento.ToListAsync();
        var total = folhas.Sum(x => x.Liquido);
        return Ok($"O total das folhas de pagamento é de: {total}");
    }
    
    [HttpGet]
    [Route("Media")]
    public async Task<IActionResult> Media()
    {
        var folhas = await _context.FolhaPagamento.ToListAsync();
        var total = folhas.Sum(x => x.Liquido);
        var media = total / folhas.Count;
        
        return Ok($"A média das folhas de pagamento é de: {media}");
    }
}