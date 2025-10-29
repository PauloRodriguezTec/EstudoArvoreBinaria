using EstudoArvoreBinaria.Classes;

namespace EstudoArvoreBinaria;

class Program
{
    static void Main(string[] args)
    {
        ArvoreBinaria a = new ArvoreBinaria(); // cria a árvore binária

        a.Insere(10, "A");
        a.Insere(5, "B");
        a.Insere(15, "C");
        a.Insere(2, "D");
        a.Insere(7, "E");
        a.Insere(12, "F");
        a.Insere(6, "G");
        a.Insere(8, "H");

        a.ImprimeElementosArvore();
        Console.WriteLine($"Altura: {a.AlturaArvore()}");
    }

}
