/*
A restrição where T : IComparable<T> garante que os tipos de dados usados com esta interface 
possam ser comparados, o que é essencial para as operações em uma árvore binária de busca.
*/

public interface IBST<T> where T : IComparable<T>
{
	void Inserir(T valor);
	bool Buscar(T valor);
}
