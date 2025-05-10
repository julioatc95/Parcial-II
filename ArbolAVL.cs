using System;
using Parcial_II;

namespace Parcial_II
{
    public class ArbolAVL : ArbolBinario
    {
        private int altura(Nodo nodo)
        {
            if (nodo == null) return 0;
            return Math.Max(altura(nodo.subarbolIzdo()), altura(nodo.subarbolDcho())) + 1;
        }

        private int balance(Nodo nodo)
        {
            return nodo == null ? 0 : altura(nodo.subarbolIzdo()) - altura(nodo.subarbolDcho());
        }

        private Nodo rotacionDerecha(Nodo y)
        {
            Nodo x = y.subarbolIzdo();
            Nodo T2 = x.subarbolDcho();

            x.ramaDcho(y);
            y.ramaIzdo(T2);

            return x;
        }

        private Nodo rotacionIzquierda(Nodo x)
        {
            Nodo y = x.subarbolDcho();
            Nodo T2 = y.subarbolIzdo();

            y.ramaIzdo(x);
            x.ramaDcho(T2);

            return y;
        }

        public void insertar(object valor)
        {
            Comparador dato = (Comparador)valor;
            raiz = insertarAVL(raiz, dato);
        }

        private Nodo insertarAVL(Nodo nodo, Comparador dato)
        {
            if (nodo == null)
                return new Nodo(dato);

            if (dato.menorQue(nodo.valorNodo()))
                nodo.ramaIzdo(insertarAVL(nodo.subarbolIzdo(), dato));
            else if (dato.mayorQue(nodo.valorNodo()))
                nodo.ramaDcho(insertarAVL(nodo.subarbolDcho(), dato));
            else
                throw new Exception("Estudiante duplicado");

            int balanceFactor = balance(nodo);

            if (balanceFactor > 1 && dato.menorQue(nodo.subarbolIzdo().valorNodo()))
                return rotacionDerecha(nodo);

            if (balanceFactor < -1 && dato.mayorQue(nodo.subarbolDcho().valorNodo()))
                return rotacionIzquierda(nodo);

            if (balanceFactor > 1 && dato.mayorQue(nodo.subarbolIzdo().valorNodo()))
            {
                nodo.ramaIzdo(rotacionIzquierda(nodo.subarbolIzdo()));
                return rotacionDerecha(nodo);
            }

            if (balanceFactor < -1 && dato.menorQue(nodo.subarbolDcho().valorNodo()))
            {
                nodo.ramaDcho(rotacionDerecha(nodo.subarbolDcho()));
                return rotacionIzquierda(nodo);
            }

            return nodo;
        }
    }
}
