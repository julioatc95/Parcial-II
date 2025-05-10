# Proyecto Parcial\_II - Árboles Binarios y AVL en C\#

Este proyecto gestiona estudiantes aprobados y reprobados utilizando estructuras de datos: Árbol Binario de Búsqueda (ABB) y Árbol AVL. Los estudiantes se separan con base en su nota final y se visualizan en orden.

---

## Estructura del Proyecto

### 1. `Comparador.cs`

**Tipo:** Interfaz

Permite definir cómo se comparan los elementos dentro de los árboles (por ejemplo, estudiantes por su carné o nota).

**Métodos definidos:**

* `igualQue(object q)`
* `menorQue(object q)`
* `menorIgualQue(object q)`
* `mayorQue(object q)`
* `mayorIgualQue(object q)`

---

### 2. `Estudiante.cs`

**Tipo:** Clase que implementa `Comparador`

Representa a cada estudiante y define cómo compararlos (por Carné).

**Propiedades:**

* `Carne`
* `Nombre`
* `Correo`
* `Total`

**Métodos:**

* Implementa la comparación por carné
* `ToString()`: Formatea la salida para visualización

---

### 3. `Nodo.cs`

**Tipo:** Nodo genérico para cualquier árbol binario

Contiene el dato y referencias al subárbol izquierdo y derecho.

**Propiedades privadas:**

* `dato`
* `izdo`, `dcho`

**Métodos clave:**

* `subarbolIzdo()`, `subarbolDcho()`
* `ramaIzdo(Nodo)`, `ramaDcho(Nodo)`
* `valorNodo()`, `nuevoValor(object)`
* `visitar()`

---

### 4. `ArbolBinario.cs`

**Tipo:** Clase base para ABB y AVL

Define la raíz del árbol y el método `inorden` para recorrer y mostrar datos ordenados.

---

### 5. `ArbolBinarioBusqueda.cs`

**Tipo:** Árbol Binario de Búsqueda

Administra los estudiantes reprobados.

**Funciones:**

* `insertar(object)`
* `buscar(object)`
* `eliminar(object)`
* `reemplazar(Nodo)`

---

### 6. `ArbolAVL.cs`

**Tipo:** Árbol AVL (autobalanceado)

Administra los estudiantes aprobados y balancea el árbol al insertar.

**Métodos incluidos:**

* `insertar(object)` con balanceo
* Rotaciones izquierda, derecha, doble
* Cálculo de altura y factor de balance

---

### 7. `Form1.cs`

**Tipo:** Interfaz gráfica con Windows Forms

Contiene botones y listas para interactuar con el usuario:

* `btnCargarCSV`: Lee el archivo CSV y separa aprobados/reprobados
* `btnMostrarAprobados`: Muestra en ListBox los aprobados (AVL)
* `btnMostrarReprobados`: Muestra en ListBox los reprobados (ABB)

Usa `ArbolBinario.inorden(...)` para mostrar los datos en orden ascendente.

---

## Cómo Ejecutar

1. Clona el proyecto:

```bash
git clone https://github.com/julioatc95/Parcial_II.git
```

2. Abre en Visual Studio

3. Asegúrate que el archivo `Estudiantes_Limpio.csv` esté en el directorio del ejecutable y tenga:

```
Carné,Nombre,Correo,Nota1,Nota2,...,Total
```

4. Ejecuta la app y usa los botones para cargar y visualizar los estudiantes.

---

## Autor

**Julio Trujillo**
Proyecto académico - Programación III

---
