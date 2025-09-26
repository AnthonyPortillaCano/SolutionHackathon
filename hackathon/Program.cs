

// Example 1

int[] teamSize1 = { 1, 2, 9, 7, 6, 6, 6 };
int k1 = 2;
int[] output1 = Solver.EqualizeTeamSizeArray(teamSize1, k1);
int maxCount1 = Solver.EqualizeTeamSize(output1, 0);
Console.WriteLine("Example 1:");
Console.WriteLine($"Output: [{string.Join(", ", output1)}]");
Console.WriteLine($"Máximo de equipos igualados: {maxCount1}\n");

// Example 2
int[] teamSize2 = { 2, 5, 3, 3, 6, 7, 8 };
int k2 = 2;
int[] output2 = Solver.EqualizeTeamSizeArray(teamSize2, k2);
int maxCount2 = Solver.EqualizeTeamSize(output2, 0);
Console.WriteLine("Example 2:");
Console.WriteLine($"Output: [{string.Join(", ", output2)}]");
Console.WriteLine($"Máximo de equipos igualados: {maxCount2}\n");

// Example 3
int[] teamSize3 = { 20, 20, 20, 4, 4, 1 };
int k3 = 3;
int[] output3 = Solver.EqualizeTeamSizeArray(teamSize3, k3);
int maxCount3 = Solver.EqualizeTeamSize(output3, 0);
Console.WriteLine("Example 3:");
Console.WriteLine($"Output: [{string.Join(", ", output3)}]");
Console.WriteLine($"Máximo de equipos igualados: {maxCount3}\n");
