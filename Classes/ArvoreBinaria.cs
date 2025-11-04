using System;

namespace EstudoArvoreBinaria.Classes
{
    public class ArvoreBinaria
    {
        private No raiz;

        public ArvoreBinaria()
        {
            raiz = null;
        }

        public void InsereAVL(long id, object elemento)
        {
            No novoNo = new No(id, elemento, null, null);
            Insere(raiz, novoNo);
        }

        private void Insere(No atual, No novo)
        {
            if (atual == null)
            {
                raiz = novo;
                return;
            }

            if (novo.Id < atual.Id)
            {
                if (atual.Esq == null)
                {
                    atual.Esq = novo;
                    novo.Pai = atual;
                    AvaliaBalanceamento(atual);
                }
                else
                {
                    Insere(atual.Esq, novo);
                }
            }
            else if (novo.Id > atual.Id)
            {
                if (atual.Dir == null)
                {
                    atual.Dir = novo;
                    novo.Pai = atual;
                    AvaliaBalanceamento(atual);
                }
                else
                {
                    Insere(atual.Dir, novo);
                }
            }
        }

        private void AvaliaBalanceamento(No atual)
        {
            CalcBalanceamento(atual);
            long b = atual.B;

            if (b == -2)
            {
                if (Altura(atual.Esq.Esq) >= Altura(atual.Esq.Dir))
                {
                    atual = RotacaoDir(atual);
                }
                else
                {
                    atual = DuplaRotacaoDir(atual);
                }
            }
            else if (b == 2)
            {
                if (Altura(atual.Dir.Dir) >= Altura(atual.Dir.Esq))
                {
                    atual = RotacaoEsq(atual);
                }
                else
                {
                    atual = DuplaRotacaoEsq(atual);
                }
            }

            if (atual.Pai != null)
            {
                AvaliaBalanceamento(atual.Pai);
            }
            else
            {
                raiz = atual;
            }
        }

        private void CalcBalanceamento(No no)
        {
            no.B = Altura(no.Dir) - Altura(no.Esq);
        }

        private long Altura(No atual)
        {
            if (atual == null) return -1;
            return 1 + Math.Max(Altura(atual.Esq), Altura(atual.Dir));
        }

        private No RotacaoEsq(No inicial)
        {
            No dir = inicial.Dir;
            dir.Pai = inicial.Pai;

            inicial.Dir = dir.Esq;
            if (inicial.Dir != null)
                inicial.Dir.Pai = inicial;

            dir.Esq = inicial;
            inicial.Pai = dir;

            if (dir.Pai != null)
            {
                if (dir.Pai.Dir == inicial)
                    dir.Pai.Dir = dir;
                else if (dir.Pai.Esq == inicial)
                    dir.Pai.Esq = dir;
            }

            CalcBalanceamento(inicial);
            CalcBalanceamento(dir);

            return dir;
        }

        private No RotacaoDir(No inicial)
        {
            No esq = inicial.Esq;
            esq.Pai = inicial.Pai;

            inicial.Esq = esq.Dir;
            if (inicial.Esq != null)
                inicial.Esq.Pai = inicial;

            esq.Dir = inicial;
            inicial.Pai = esq;

            if (esq.Pai != null)
            {
                if (esq.Pai.Dir == inicial)
                    esq.Pai.Dir = esq;
                else if (esq.Pai.Esq == inicial)
                    esq.Pai.Esq = esq;
            }

            CalcBalanceamento(inicial);
            CalcBalanceamento(esq);

            return esq;
        }

        private No DuplaRotacaoDir(No inicial)
        {
            inicial.Esq = RotacaoEsq(inicial.Esq);
            return RotacaoDir(inicial);
        }

        private No DuplaRotacaoEsq(No inicial)
        {
            inicial.Dir = RotacaoDir(inicial.Dir);
            return RotacaoEsq(inicial);
        }

        public void ImprimeElementosArvore()
        {
            PreFixado(raiz);
        }

        private void PreFixado(No atual)
        {
            if (atual != null)
            {
                Console.WriteLine($"Id: {atual.Id} Elemento: {atual.Elemento}");
                PreFixado(atual.Esq);
                PreFixado(atual.Dir);
            }
        }

        private void PosFixado(No atual)
        {
            if (atual != null)
            {
                PosFixado(atual.Esq);
                PosFixado(atual.Dir);
                Console.WriteLine($"Id: {atual.Id} Elemento: {atual.Elemento}");
            }
        }

        private void SimFixado(No atual)
        {
            if (atual != null)
            {
                SimFixado(atual.Esq);
                Console.WriteLine($"Id: {atual.Id} Elemento: {atual.Elemento}");
                SimFixado(atual.Dir);
            }
        }

        private long CalcAltura(No atual, long a)
        {
            if (atual != null)
            {
                long e = CalcAltura(atual.Esq, a) + 1;
                long d = CalcAltura(atual.Dir, a) + 1;
                return a + Math.Max(e, d);
            }
            return a;
        }

        public long AlturaArvore()
        {
            return CalcAltura(raiz, 0);
        }
    }
}