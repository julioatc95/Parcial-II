namespace Parcial_II;

public class Nodo
{
    private object dato;
    private Nodo izdo;
    private Nodo dcho;

    public Nodo(object valor)
    {
        dato = valor;
        izdo = dcho = null;
    }

    // Métodos públicos para conectar y acceder
    public Nodo subarbolIzdo() => izdo;
    public Nodo subarbolDcho() => dcho;
    public void ramaIzdo(Nodo n) => izdo = n;
    public void ramaDcho(Nodo n) => dcho = n;
    public object valorNodo() => dato;
    public void nuevoValor(object d) => dato = d;
    public string visitar() => dato.ToString() + "\n";
}

