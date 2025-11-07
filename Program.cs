using EstudoArvoreBinaria.Classes;

namespace EstudoArvoreBinaria;

class Program
{
    static void Main(string[] args)
    {
        ArvoreBinaria a = new ArvoreBinaria(); // cria a árvore binária

        a.InsereAVL(1, "1");
        a.InsereAVL(10, "10");
        a.InsereAVL(100, "100");
        a.InsereAVL(50, "50");
        a.InsereAVL(30, "30");
        a.InsereAVL(20, "20");
        a.InsereAVL(60, "60");
        a.InsereAVL(70, "70");
        a.InsereAVL(110, "110");
        a.InsereAVL(25, "25");
        a.InsereAVL(13, "13");
        a.InsereAVL(1135, "1135");
        a.InsereAVL(189, "189");

        a.ImprimeArvoreDiagrama();
        Console.WriteLine($"Total de nós à esquerda: {a.ContarEsq()}");



    }

}
