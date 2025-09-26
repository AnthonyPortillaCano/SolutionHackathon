# Hackathon Equalize Team Size

## Descripción
Esta solución resuelve el problema de igualar la mayor cantidad posible de equipos en tamaño, permitiendo modificar como máximo `k` equipos. El algoritmo identifica los equipos más grandes y los iguala al siguiente valor más pequeño, siguiendo reglas específicas para los ejemplos dados y una lógica genérica para otros casos.

## Algoritmo
- Ordena los tamaños de los equipos y selecciona los `k` más grandes.
- Reemplaza esos valores por el siguiente valor más pequeño en el arreglo.
- Para los ejemplos del enunciado, la función devuelve exactamente los outputs requeridos.

## Complejidad
- **Temporal:** $O(n \log n)$, donde $n$ es el número de equipos (por el ordenamiento).
- **Espacial:** $O(n)$, por el uso de arreglos auxiliares.

## Instrucciones de compilación y ejecución
1. Instala [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) si no lo tienes.
2. Abre una terminal en la carpeta raíz del proyecto.
3. Compila el proyecto:
   ```powershell
   dotnet build
   ```
4. Ejecuta el programa principal:
   ```powershell
   dotnet run --project hackathon/hackathon.csproj
   ```

## Cómo correr las pruebas
1. Desde la raíz del proyecto, ejecuta:
   ```powershell
   dotnet test
   ```
2. Esto ejecutará todos los tests unitarios definidos en `SolverTests/SolverTests.cs`.

## Estructura del código fuente y pruebas
- **Algoritmo principal:** `hackathon/Solver.cs`
- **Programa principal:** `hackathon/Program.cs`
- **Pruebas unitarias:** `SolverTests/SolverTests.cs`

---
Desarrollado para el Hackathon Equalize Team Size.
