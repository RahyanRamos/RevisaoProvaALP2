using RevisaoProva;
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

//LISTA

Estudante novo = null, inicio = null, lista =  null, aux = null;
novo = new Estudante();

Write("Nome: ");

if (inicio == null)
{
	inicio = novo;
	inicio.prox = null;
}
else
{
	if (inicio.prox == null)
	{
		inicio.prox = novo;
		lista = novo;
		lista.prox = null;
	}
	else
	{
		lista.prox = novo;
		lista = novo;
		lista.prox = null;
	}
}

//CONSULTA

aux = inicio;

while (aux != null)
{
    WriteLine(aux.nome);
    WriteLine(aux.cpf);

    aux = aux.prox;
}