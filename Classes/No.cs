using System;

namespace EstudoArvoreBinaria.Classes
{
    // Implementação da classe No em C#
    public class No
    {
        // Campos privados
        private long id;         // Identificador do elemento
        private object elemento; // Elemento armazenado
        private No esq;          // Filho esquerdo
        private No dir;          // Filho direito
        private No pai;          // Pai do nó
        private long b;          // Fator de balanceamento

        // Construtor
        public No(long id, object elemento, No esq, No dir)
        {
            this.id = id;
            this.elemento = elemento;
            this.esq = esq;
            this.dir = dir;
            this.pai = null;
            this.b = 0;
        }

        // Representação textual do nó
        public override string ToString()
        {
            return $"Id:{id} B:{b}";
        }

        // Propriedades públicas
        public long Id
        {
            get => id;
            set => id = value;
        }

        public object Elemento
        {
            get => elemento;
            set => elemento = value;
        }

        public No Esq
        {
            get => esq;
            set => esq = value;
        }

        public No Dir
        {
            get => dir;
            set => dir = value;
        }

        public No Pai
        {
            get => pai;
            set => pai = value;
        }

        public long B
        {
            get => b;
            set => b = value;
        }
    }
}