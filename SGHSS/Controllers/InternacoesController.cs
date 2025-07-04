using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGHSS.Context;
using Shared.Models;

namespace SGHSS.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InternacoesController : ControllerBase
	{
		private readonly AppDbContext _context;

		public InternacoesController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Internacoes
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Internacao>>> GetInternacoes()
		{
			return await _context.Internacoes
				.Include(i => i.Paciente)
				.ToListAsync();
		}

		// GET: api/Internacoes/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Internacao>> GetInternacao(int id)
		{
			var internacao = await _context.Internacoes
				.Include(i => i.Paciente)
				.FirstOrDefaultAsync(i => i.InternacaoId == id);

			if (internacao == null)
				return NotFound();

			return internacao;
		}

		// POST: api/Internacoes
		[HttpPost]
		public async Task<ActionResult<Internacao>> PostInternacao(Internacao internacao)
		{
			_context.Internacoes.Add(internacao);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetInternacao), new { id = internacao.InternacaoId }, internacao);
		}

		// PUT: api/Internacoes/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutInternacao(int id, Internacao internacao)
		{
			if (id != internacao.InternacaoId)
				return BadRequest();

			_context.Entry(internacao).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!InternacaoExists(id))
					return NotFound();
				else
					throw;
			}

			return NoContent();
		}

		// DELETE: api/Internacoes/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteInternacao(int id)
		{
			var internacao = await _context.Internacoes.FindAsync(id);
			if (internacao == null)
				return NotFound();

			_context.Internacoes.Remove(internacao);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool InternacaoExists(int id)
		{
			return _context.Internacoes.Any(i => i.InternacaoId == id);
		}
	}
}
