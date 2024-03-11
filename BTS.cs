public class BST<T> : IBST<T> where T : IComparable<T>
{
    private Nodo<T> raiz;

    public void Inserir(T valor)
    {
        Nodo<T> novoNodo = new Nodo<T>(valor);

        if (raiz == null)
        {
            raiz = novoNodo;
        }
        else
        {
            Nodo<T> atual = raiz;
            Nodo<T> pai;

            while (true)
            {
                pai = atual;
                if (valor.CompareTo(atual.Valor) < 0)
                {
                    atual = atual.Esquerda;
                    if (atual == null)
                    {
                        pai.Esquerda = novoNodo;
                        return;
                    }
                }
                else
                {
                    atual = atual.Direita;
                    if (atual == null)
                    {
                        pai.Direita = novoNodo;
                        return;
                    }
                }
            }
        }
    }

    public bool Buscar(T valor)
    {
        Nodo<T> atual = raiz;
        while (atual != null)
        {
            int resultado = valor.CompareTo(atual.Valor);
            if (resultado < 0)
            {
                atual = atual.Esquerda;
            }
            else if (resultado > 0)
            {
                atual = atual.Direita;
            }
            else
            {
                return true; // Valor encontrado
            }
        }

        return false; // Valor não encontrado
    }
}