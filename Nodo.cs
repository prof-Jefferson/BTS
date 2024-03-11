public class Nodo<T> where T : IComparable<T>
{
    public T Valor { get; set; }
    public Nodo<T> Esquerda { get; set; }
    public Nodo<T> Direita { get; set; }

    public Nodo(T valor)
    {
        Valor = valor;
    }
}