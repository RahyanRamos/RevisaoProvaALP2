using static System.Console;
using static System.Convert;

int[] numero = new int[10];
int[][] vet = new int[10][];
int[,] vet2 = new int[10,10];

for (int i = 0; i < vet.GetLength(0); i++)
{
	for (int j = 0; j < vet.GetLength(1); j++)
	{
		WriteLine(vet[i][j]);
	}
}

static int[,] matriz(int[,] vet)
{
    return vet;
}