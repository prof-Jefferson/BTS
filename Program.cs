namespace Aula03_BTS;

/*
	Primeiro a classe IBtS
	Segundo a classe Nodo
	Terceiro a classe BTS
	Quarto o Program criar a instancia bst, inserir e depois imprimir
*/

class Program
{
	static void Main(string[] args)
	{
		IBST<int> bst = new BST<int>();

		bst.Inserir(50);
		bst.Inserir(30);
		bst.Inserir(70);
		bst.Inserir(20);
		bst.Inserir(40);
		bst.Inserir(60);
		bst.Inserir(80);

		Console.WriteLine(bst.Buscar(40)); // True
		Console.WriteLine(bst.Buscar(90)); // False
	}
}

