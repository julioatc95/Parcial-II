using System;
using Parcial_II;
namespace Parcial_II;

public class Estudiante : Comparador
{
    public string Carne { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public int Total { get; set; }

    public Estudiante(string carne, string nombre, string correo, int total)
    {
        Carne = carne;
        Nombre = nombre;
        Correo = correo;
        Total = total;
    }

    public bool igualQue(object q) => this.Carne == ((Estudiante)q).Carne;
    public bool menorQue(object q) => this.Carne.CompareTo(((Estudiante)q).Carne) < 0;
    public bool menorIgualQue(object q) => this.Carne.CompareTo(((Estudiante)q).Carne) <= 0;
    public bool mayorQue(object q) => this.Carne.CompareTo(((Estudiante)q).Carne) > 0;
    public bool mayorIgualQue(object q) => this.Carne.CompareTo(((Estudiante)q).Carne) >= 0;


    public override string ToString()
    {
        return $"Estudiante: {Nombre}\nCarné: {Carne}\nCorreo: {Correo}\nNota Total: {Total}";
    }
}




