#include <stdlib.h>
#include <stdio.h>

#define SIZE 1000000

void siftDown(int *mas, int root, int bottom)
{
	int maxChild;
	int done = 0;
	
	while ((root * 2 <= bottom) && (!done))
	{
		if (root * 2 == bottom)
			maxChild = root * 2;
		else if (mas[root * 2] > mas[root * 2 + 1])
			maxChild = root * 2;
		else
			maxChild = root * 2 + 1;

		if (mas[root] < mas[maxChild])
		{
			int temp = mas[root];
			mas[root] = mas[maxChild];
			mas[maxChild] = temp;
			root = maxChild;
		}
		else
			done = 1;
	}
}

void heapSort(int *mas, int masLength)
{
	for (int i = (masLength / 2) - 1; i >= 0; i--)	//формирование
		siftDown(mas, i, masLength - 1);

	for (int i = masLength - 1; i >= 0; i--)	//просеивание
	{
		int temp = mas[0];
		mas[0] = mas[i];
		mas[i] = temp;
		siftDown(mas, 0, i - 1);
	}
}
int main()
{
	//int mas[1000000];
	//int* mas = (int*)malloc(SIZE * sizeof(int));
	int* mas = new int[SIZE];
	if (mas != NULL)
	{
		for (int i = 0; i < SIZE; i++)
			mas[i] = rand();

		/*for (int i = 0; i < masLength; i++)
			printf("%d ", mas[i]);*/

		heapSort(mas, SIZE);

		for (int i = 0; i < 100; i++)
			printf("%7i ", mas[i]);
		/*for (int i = 0; i < SIZE; i++)
			printf("%d ", mas[i]);*/
		printf("\n");
	}
	else printf("Не выделена память");
	return 0;
}