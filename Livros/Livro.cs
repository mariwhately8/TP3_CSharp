using System.Data;

namespace Livros
{
    public class Livro
    {
        private String _nome;
        private int _numeroPaginas;
        private bool _ehNovo;
        private DateTime _dataPublicacao;
        private double _preco;

        public Livro(String nome, int numeroPaginas, String ehNovoStr, DateTime dataPublicacao, double preco)
        {
            _nome = nome;
            _numeroPaginas = numeroPaginas;

            if (ehNovoStr == "N")
            {
                _ehNovo = true;
            }
            else
            {
                _ehNovo = false;
            }
                        
            _dataPublicacao = dataPublicacao;
            _preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public int NumeroPaginas
        {
            get { return _numeroPaginas; }
        }

        public bool EhNovo
        {
            get { return _ehNovo; }
        }

        public DateTime DataPublicacao
        {
            get { return _dataPublicacao; }
        }

        public double Preco
        {
            get { return _preco; }
        }
        public static int CalcularIdadeLivro(DateTime dataPublicacao)
        {
            int idadeLivro = DateTime.Now.Year - dataPublicacao.Year;

            return idadeLivro;
        }
    }

    
}

