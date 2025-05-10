namespace Parcial_II;

public class ArbolBinario
{
    protected Nodo raiz;

    public ArbolBinario()
    {
        raiz = null;
    }

    
    public ArbolBinario(Nodo raiz)
    {
        this.raiz = raiz;
    }

    public Nodo raizArbol() => raiz;

    public static string inorden(Nodo r)
    {
        if (r != null)
            return inorden(r.subarbolIzdo()) + r.visitar() + inorden(r.subarbolDcho());
        return "";
    }
}
