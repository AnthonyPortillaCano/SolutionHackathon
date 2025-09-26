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
        int[] arr = (int[])teamSize.Clone();
        int maxCount = 1, bestTarget = arr[0];

        // Probar cada valor posible como objetivo
        foreach (var target in arr.Distinct().OrderByDescending(x => x))
        {
            int count = arr.Count(x => x == target);
            int reductionsLeft = k;
            // Simular reducción de los más grandes (de derecha a izquierda)
            for (int i = n - 1; i >= 0 && reductionsLeft > 0; i--)
            {
                if (arr[i] > target)
                {
                    count++;
                    reductionsLeft--;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                bestTarget = target;
            }
        }

        // Aplicar reducción real de derecha a izquierda, manteniendo el orden original
        int[] result = (int[])teamSize.Clone();
        int reduce = k;
        for (int i = n - 1; i >= 0 && reduce > 0; i--)
        {
            if (result[i] > bestTarget)
            {
                result[i] = bestTarget;
                reduce--;
            }
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
