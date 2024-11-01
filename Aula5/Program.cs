//formas de declarar o vetor
int [] vetor = new int[5];
//sem estabelecer tamanho
int [] vetor2 = new int[] {1,2,3,4,5};
int [] vetor3 = {1,2,3,4,5};
int [] vetor4 = {}; //vetor vazio

//acessando elemento
System.Console.WriteLine(vetor2[4]); //começa no zero, vai ser 5

//alterando elementos
vetor2[4] = 10;
System.Console.WriteLine(vetor2[4]);

//percorrendo o vetor
for(int i = 0; i < vetor2.Length; i++)
{
    System.Console.WriteLine(vetor2[i]);
}

//percorrendo vetor com while
int j = 0;
while (j < vetor2.Legth)
{
    System.Console.WriteLine(vetor2[j]);
    j++;
}
