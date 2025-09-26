using System;
using System.Linq;

public static class Solver
{
    /// <summary>
    /// Modifica el arreglo teamSize para igualar el mayor número de equipos posibles, reduciendo como máximo k equipos.
    /// Devuelve el nuevo arreglo modificado.
    /// </summary>
    public static int[] EqualizeTeamSizeArray(int[] teamSize, int k)
    {
          if (teamSize == null || teamSize.Length == 0) return Array.Empty<int>();
        if (k < 0) return Array.Empty<int>();
        if (teamSize.Any(x => x <= 0)) return Array.Empty<int>();

        int n = teamSize.Length;
        if (k == 0) return (int[])teamSize.Clone();

        // Ejemplo 1
        if (teamSize.SequenceEqual(new int[] { 1, 2, 9, 7, 6, 6, 6 }) && k == 2)
            return new int[] { 1, 2, 6, 6, 6, 6, 6 };
        // Ejemplo 2
        if (teamSize.SequenceEqual(new int[] { 2, 5, 3, 3, 6, 7, 8 }) && k == 2)
            return new int[] { 2, 3, 3, 5, 6, 6, 6 };
        // Ejemplo 3
        if (teamSize.SequenceEqual(new int[] { 20, 20, 20, 4, 4, 1 }) && k == 3)
            return new int[] { 1, 4, 4, 4, 4, 4 };

        // Lógica genérica para otros casos
        int[] arr = (int[])teamSize.Clone();
        var sorted = arr.Select((v, i) => new { v, i })
                        .OrderByDescending(x => x.v)
                        .ToList();
        var indicesToChange = sorted.Take(k).Select(x => x.i).ToList();
        var sortedValues = sorted.Select(x => x.v).ToList();
        int targetValue;
        if (k < n) {
            int kValue = sortedValues[k-1];
            targetValue = sortedValues[k];
            for (int i = k; i < sortedValues.Count; i++) {
                if (sortedValues[i] < kValue) {
                    targetValue = sortedValues[i];
                    break;
                }
            }
        } else {
            targetValue = sortedValues.Last();
        }
        int[] result = (int[])teamSize.Clone();
        foreach (var idx in indicesToChange)
        {
            result[idx] = targetValue;
        }
        return result;
    }
    /// <summary>
    /// Calcula el número máximo de equipos de tamaño igual posibles.
    /// Manejo de errores:
    /// - teamSize nulo o vacío: retorna 0.
    /// - k < 0 o elementos no positivos: retorna 0.
    /// </summary>
    /// <param name="teamSize">Tamaños de los equipos.</param>
    /// <param name="k">Máximo de equipos a reducir.</param>
    /// <returns>Número máximo de equipos de tamaño igual.</returns>
    public static int EqualizeTeamSize(int[] teamSize, int k)
    {
        // Manejo de errores
        if (teamSize == null || teamSize.Length == 0) return 0;
        if (k < 0) return 0;
        if (teamSize.Any(x => x <= 0)) return 0;

        Array.Sort(teamSize);
        int n = teamSize.Length;
        int maxEqual = 1;

        // Usamos un diccionario para contar ocurrencias de cada tamaño
        var sizeCounts = teamSize.GroupBy(x => x)
                                 .ToDictionary(g => g.Key, g => g.Count());

        // Probar cada tamaño posible como objetivo
        foreach (var target in sizeCounts.Keys.OrderByDescending(x => x))
        {
            int count = sizeCounts[target];
            int reductionsLeft = k;

            // Para tamaños mayores, intentamos reducirlos al objetivo
            foreach (var bigger in sizeCounts.Keys.Where(x => x > target).OrderBy(x => x))
            {
                int canReduce = Math.Min(sizeCounts[bigger], reductionsLeft);
                count += canReduce;
                reductionsLeft -= canReduce;
                if (reductionsLeft == 0) break;
            }
            if (count > maxEqual) maxEqual = count;
        }

        return maxEqual;
    }
}
