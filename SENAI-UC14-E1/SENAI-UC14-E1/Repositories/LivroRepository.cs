using SENAI_UC14_E1.Contexts;
using SENAI_UC14_E1.Models;

namespace SENAI_UC14_E1.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
