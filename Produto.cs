namespace Aula16Construtor
{
    public class Produto
    {
    

        public string Nome { get; set; }
        public int Codigo { get; set; }
        public int Estoque { get; set; }
        public int Preco { get; set; }
        public string Descricao { get; set; }
        

        public Produto(){
            
        }

        public Produto(string nome, int codigo, int estoque, int preco, string descricao){

            this.Nome = nome;
            this.Codigo = codigo;
            this.Estoque = estoque;
            this.Preco = preco;
            this.Descricao = descricao;

        }
    }
}