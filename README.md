# Trivia Pro

---

## Funcionalidades por módulos

###  1. Interfaz de Inicio (FormInicio)
- Registro del nombre del jugador.
- Selección de categoría (Ciencia, Historia, Deportes).
- Selección de nivel (Fácil, Media, Difícil).
- Validación de campos.
- Transición a FormJuego.
- Reinicio de sesión de preguntas.

> **Archivo relacionado:** `FormInicio.cs`, `FormInicio.Designer.cs`

---

### 2. Motor de Juego (FormJuego)
- Generación de preguntas aleatorias no repetidas.
- Lógica de temporizador con barra de tiempo y reloj.
- Sistema de puntaje avanzado:
  - Correcta: +5/+10/+15 según nivel.
  - Incorrecta: -2 puntos (mínimo 0).
- Retroalimentación inmediata tras responder.
- Avance automático a la siguiente pregunta.
- Finaliza luego de 15 preguntas.

> **Archivos relacionados:** `FormJuego.cs`, `TemporizadorTrivia.cs`, `PreguntaFactory.cs`

---

### 3. Pantalla de Resumen (FormResumen)
- Muestra puntaje final.
- Número de respuestas correctas e incorrectas.
- Permite reiniciar la partida o cerrar.

> **Archivo relacionado:** `FormResumen.cs`

---

### 4. Lógica del sistema
- Uso de POO:
  - Clases abstractas como `Pregunta` con herencia (`PreguntaFacil`, `PreguntaMedia`, `PreguntaDificil`).
  - Encapsulamiento de datos en `Jugador`, `Partida`, `Puntaje`.
  - Polimorfismo en método `ObtenerPuntaje()`.
- Patrón Factory:
  - `PreguntaFactory` gestiona preguntas aleatorias por categoría y nivel.

---

## 5. Arquitectura de Clases

Diagrama:

- `Pregunta (abstracta)`
  - `PreguntaFacil`
  - `PreguntaMedia`
  - `PreguntaDificil`
- `Jugador`
- `Partida`
- `Puntaje`
- `PreguntaFactory`
- `TemporizadorTrivia`

---




