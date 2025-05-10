namespace Parcial_II;

using System;


    public class ArbolBinarioBusqueda : ArbolBinario
    {
        public ArbolBinarioBusqueda() : base() { }
        public ArbolBinarioBusqueda(Nodo nodo) : base(nodo) { }

        public Nodo buscar(object buscado)
        {
            Comparador dato = (Comparador)buscado;
            return raiz == null ? null : buscar(raizArbol(), dato);
        }

        public Nodo buscar(Nodo raizSub, Comparador buscado)
        {
            if (raizSub == null) return null;
            else if (buscado.igualQue(raizSub.valorNodo())) return raizSub;
            else if (buscado.menorQue(raizSub.valorNodo())) return buscar(raizSub.subarbolIzdo(), buscado);
            else return buscar(raizSub.subarbolDcho(), buscado);
        }

        public void insertar(object valor)
        {
            Comparador dato = (Comparador)valor;
            raiz = insertar(raiz, dato);
        }

        protected Nodo insertar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null) return new Nodo(dato);
            else if (dato.menorQue(raizSub.valorNodo())) raizSub.ramaIzdo(insertar(raizSub.subarbolIzdo(), dato));
            else if (dato.mayorQue(raizSub.valorNodo())) raizSub.ramaDcho(insertar(raizSub.subarbolDcho(), dato));
            else throw new Exception("Elemento duplicado");
            return raizSub;
        }

        public void eliminar(object valor)
        {
            Comparador dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }

        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null) throw new Exception("Elemento no encontrado");
            else if (dato.menorQue(raizSub.valorNodo())) raizSub.ramaIzdo(eliminar(raizSub.subarbolIzdo(), dato));
            else if (dato.mayorQue(raizSub.valorNodo())) raizSub.ramaDcho(eliminar(raizSub.subarbolDcho(), dato));
            else
            {
                Nodo q = raizSub;
                if (q.subarbolIzdo() == null) raizSub = q.subarbolDcho();
                else if (q.subarbolDcho() == null) raizSub = q.subarbolIzdo();
                else q = reemplazar(q);
            }
            return raizSub;
        }

        private Nodo reemplazar(Nodo act)
        {
            Nodo a = act.subarbolIzdo(), p = act;
            while (a.subarbolDcho() != null)
            {
                p = a;
                a = a.subarbolDcho();
            }
            act.nuevoValor(a.valorNodo());
            if (p == act) p.ramaIzdo(a.subarbolIzdo());
            else p.ramaDcho(a.subarbolIzdo());
            return a;
        }
    }

