using System;
using Livros;

namespace Estante
{
    public class CadastroLivroEmMemoria
    {
        private List<Livro> _lstLivro;

        public CadastroLivroEmMemoria()
        {
            _lstLivro = new List<Livro>();
        }
        public void AdicionarLivro(Livro livro)
        {
            _lstLivro.Add(livro);
        }
       
        public IEnumerable<Livro> BuscaLivro(String termoBuscado)
        {
            return _lstLivro.Where(s => s.Nome.Contains(termoBuscado));
        }
    }
}