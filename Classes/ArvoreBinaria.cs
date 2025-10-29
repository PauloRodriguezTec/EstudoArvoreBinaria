using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoArvoreBinaria.Classes
{
    // Implementação da classe ArvoreBinaria em C#
    public class ArvoreBinaria
    {
        private No raiz;

        // Construtor da classe ArvoreBinaria
        public ArvoreBinaria()
        {
            this.raiz = null; // inicia a árvore vazia
        }

        // Método para inserção de elemento
        public void Insere(long id, object elemento)
        {
            No novoNo = new No(id, elemento, null, null);

            if (raiz == null)
            {
                raiz = novoNo;
            }
            else
            {
                No atual = raiz;
                No pai;

                while (true)
                {
                    pai = atual;

                    if (id < atual.GetId()) // vai inserir à esquerda
                    {
                        atual = atual.GetEsq();
                        if (atual == null) // pode inserir à esquerda
                        {
                            pai.SetEsq(novoNo);
                            return;
                        }
                    }
                    else // vai inserir à direita
                    {
                        atual = atual.GetDir();
                        if (atual == null) // pode inserir à direita
                        {
                            pai.SetDir(novoNo);
                            return;
                        }
                    }
                }
            }
        }

        // Caminhamento pré-fixado (pré-ordem)
        private void PreFixado(No atual)
        {
            if (atual != null)
            {
                Console.WriteLine($"Id: {atual.GetId()} Elemento: {atual.GetElemento()}");
                PreFixado(atual.GetEsq());
                PreFixado(atual.GetDir());
            }
        }

        // Caminhamento pós-fixado (pós-ordem)
        private void PosFixado(No atual)
        {
            if (atual != null)
            {
                PosFixado(atual.GetEsq());
                PosFixado(atual.GetDir());
                Console.WriteLine($"Id: {atual.GetId()} Elemento: {atual.GetElemento()}");
            }
        }
        // Caminhamento simétrico fixado (infixado)
        private void SimFixado(No atual)
        {
            if (atual != null)
            {
                SimFixado(atual.GetEsq());
                Console.WriteLine($"Id: {atual.GetId()} Elemento: {atual.GetElemento()}");
                SimFixado(atual.GetDir());
            }
        }
        // Método para imprimir os elementos da árvore usando caminhamento pré-fixado
        public void ImprimeElementosArvore()
        {
            PreFixado(raiz);
        }
        // Método privado para calcular a altura da árvore binária
        private long CalcAltura(No atual, long a)
        {
            if (atual != null)
            {
                long e, d;
                e = CalcAltura(atual.GetEsq(), a) + 1;
                d = CalcAltura(atual.GetDir(), a) + 1;

                if (e > d)
                {
                    return a + e;
                }
                else
                {
                    return a + d;
                }
            }
            return a;
        }

        // Método público para obter a altura da árvore
        public long AlturaArvore()
        {
            long a = 0;
            return CalcAltura(raiz, a);
        }
    }
}