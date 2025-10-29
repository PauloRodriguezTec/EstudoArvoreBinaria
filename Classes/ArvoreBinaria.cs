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
    }
}