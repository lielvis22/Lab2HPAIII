# Lab2HPAIII — Laboratorio #2: Clases en C#

**Universidad Tecnológica**
**Facultad de Ingeniería en Sistemas — Campus Víctor Levis Sasso**
**Herramientas de Programación Aplicada III (.Net)**
---
 **Fecha límite de entrega:** 31 de agosto de 2026 — II Semestre 2026
 **Instructor:** Ing. Irina Fong
 **Grupo:** 1IL133

## 📌 Título de la Experiencia

Modelado de Clases y Gestión de Atributos mediante Propiedades en C#

## Objetivos

- Comprender y aplicar la estructura básica de una aplicación de consola en C#, identificando el funcionamiento del método `Main` como punto de entrada de la ejecución.
- Diseñar y programar clases en C# siguiendo las convenciones de nomenclatura estándar (`PascalCase`) y los diagramas de clases UML.
- Implementar métodos con y sin parámetros para modularizar el comportamiento de los objetos.
- Diferenciar y aplicar los modificadores de acceso `public` y `private` para proteger los datos de una clase.
- Manejar variables de instancia y propiedades para asegurar una correcta manipulación y persistencia de los atributos en los objetos.
- Comprender y aplicar los descriptores de acceso `get` y `set` en las propiedades.

## Estructura del Repositorio

| Carpeta | Descripción |
|---|---|
| [`LibroCalificaciones_1`](./LibroCalificaciones_1) | **Actividad 1** — Clase `LibroCalificacion` con un método `MostrarMensaje()` sin parámetros que imprime un mensaje de bienvenida. Introduce la instanciación de objetos con `new` y la llamada a métodos. |
| [`LibroCalificaciones_2`](./LibroCalificaciones_2) | **Actividad 2** — Clase `MiLibroCalificaciones` con el método `MostrarMensaje(string nombreCurso)`, que ahora recibe un parámetro para personalizar el mensaje según el curso ingresado por el usuario. |
| [`LibroCalificacionesModificadores`](./LibroCalificacionesModificadores) | **Actividad 3** — Clase `LibroCalificaciones` con una variable de instancia privada `nombreCurso` y una propiedad pública `NombreCurso` (con `get`/`set`) que la encapsula, aplicando el principio de ocultamiento de información. |

## Conceptos Clave Aplicados

- **Estructura de un programa por consola:** organización del proyecto y el método `Main` como punto de entrada automático.
- **`Console` y compilación:** uso de `Console.WriteLine`, `Console.ReadLine` y marcadores de posición (`{0}`, `{1}`, ...) para interpolar valores en el texto.
- **Clases y objetos:** creación de tipos de datos extensibles, instanciación con `new`, y modelado mediante diagramas UML.
- **Métodos y parámetros:** declaración de métodos públicos (`public void`) y paso de argumentos.
- **Encapsulamiento:** uso de campos privados (variables de instancia) y propiedades públicas para un acceso controlado y seguro a los datos.
- **Modificadores de acceso:** diferencias entre `public` y `private`.

## Requisitos

- Visual Studio 2026
- .NET 10.0 (Compatibilidad a largo plazo)
- Lenguaje: C#

## Cómo ejecutar

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/lielvis22/Lab2HPAIII.git
   ```
2. Abrir la solución deseada (`.sln`) en Visual Studio.
3. Compilar y ejecutar (`F5` o `Ctrl+F5`).

## Recursos

- Visual Studio 2026, C#
- Guía del Laboratorio #2
---

