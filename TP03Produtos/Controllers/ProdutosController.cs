//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TP03Produtos.Data;
using TP03Produtos.Models;

namespace TP03Produtos.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosContext _context;

        public ProdutosController(ProdutosContext context)
        {
            _context = context;
        }

        // GET: /Produtos
        public async Task<IActionResult> Index()
        {
            List<Produto> produtos = await _context.Produtos
                .OrderBy(produto => produto.Nome)
                .ToListAsync();

            return View(produtos);
        }

        // GET: /Produtos/Details/1
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto? produto = await _context.Produtos
                .FirstOrDefaultAsync(item => item.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: /Produtos/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: /Produtos/Edit/1
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto? produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: /Produtos/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Produto? produtoBanco =
                    await _context.Produtos.FindAsync(id);

                if (produtoBanco == null)
                {
                    return NotFound();
                }

                produtoBanco.Nome = produto.Nome;
                produtoBanco.Descricao = produto.Descricao;
                produtoBanco.Preco = produto.Preco;
                produtoBanco.QuantidadeEstoque =
                    produto.QuantidadeEstoque;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: /Produtos/Delete/1
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto? produto = await _context.Produtos
                .FirstOrDefaultAsync(item => item.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: /Produtos/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Produto? produto = await _context.Produtos.FindAsync(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
