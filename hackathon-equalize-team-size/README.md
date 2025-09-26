# hackathon-equalize-team-size

## Descripción
Solución para igualar el tamaño de equipos en un hackathon, permitiendo reducir el tamaño de hasta `k` equipos para maximizar la cantidad de equipos con el mismo tamaño.

## Algoritmo
- Ordena los tamaños de equipo y cuenta ocurrencias.
- Para cada tamaño posible, intenta reducir equipos más grandes hasta `k` veces.
- Devuelve el máximo número de equipos igualados.

## Complejidad
- **Temporal:** O(n log n) por el ordenamiento y conteos.
- **Espacial:** O(n) por el uso de diccionarios.

## Manejo de errores
- Si `teamSize` es nulo o vacío, retorna 0.
- Si `k < 0` o hay elementos no positivos, retorna 0.

## Estructura
```
hackathon-equalize-team-size/
├─ README.md
├─ src/
│  ├─ Program.cs
│  └─ Solver.cs
└─ tests/
   └─ SolverTests.cs
```

## Compilación y ejecución

1. Compilar:
   ```sh
   dotnet build
   ```
2. Ejecutar:
   ```sh
   dotnet run --project src
   ```
3. Probar:
   ```sh
   dotnet test
   ```

## Pruebas
Las pruebas unitarias están en `tests/SolverTests.cs` y cubren casos válidos e inválidos.
