using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoArvoreBinaria.Classes
{
    // Implementação da classe No em C#
    public class No
    {
        private long id; // identificador do elemento
        private object elemento; // armazena o elemento de cada No
        private No esq; // aponta para o filho esquerdo do nó
        private No dir; // aponta para o filho direito do nó

        // Construtor da classe No
        public No(long id, object elemento, No esq, No dir)
        {
            this.id = id;
            this.elemento = elemento;
            this.esq = esq;
            this.dir = dir;
        }

        // Método para alterar o identificador do nó
        public void SetId(long id)
        {
            this.id = id;
        }

        // Método para receber o identificador do nó
        public long GetId()
        {
            return this.id;
        }

        // Método para alterar o elemento
        public void SetElemento(object elemento)
        {
            this.elemento = elemento;
        }

        // Método para receber o objeto contido no No
        public object GetElemento()
        {
            return this.elemento;
        }

        // Método que altera o filho esquerdo
        public void SetEsq(No esq)
        {
            this.esq = esq;
        }

        // Método que recebe o filho esquerdo do nó
        public No GetEsq()
        {
            return this.esq;
        }

        // Método que altera o filho direito
        public void SetDir(No dir)
        {
            this.dir = dir;
        }

        // Método que recebe o filho direito do nó
        public No GetDir()
        {
            return this.dir;
        }
    }
    // Final da classe No
}