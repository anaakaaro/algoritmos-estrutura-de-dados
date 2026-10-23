using System;

namespace EDPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Parte1();
            Parte2();
            Parte3();
            Parte4();
            Desafio();
        }
        static void Parte1()
        {
            Console.WriteLine("=== Parte 1 - Implementando a Pilha ===");

            Pilha p = new Pilha(5);
            p.empilha(1); p.empilha(3); p.empilha(5); p.empilha(7);
            p.mostra();                
            Console.WriteLine(p.desempilha());
            Console.WriteLine(p.consultaTopo()); 
            p.empilha(8); p.empilha(9);
            p.mostra();                 
            Console.WriteLine(p.cheia());
            try { 
                p.empilha(2); 
            } catch (Exception e) { 
                Console.WriteLine(e.Message); 
            }

            Pilha q = new Pilha(2);
            try { 
                q.desempilha(); 
            } catch (Exception e) { 
                Console.WriteLine(e.Message); 
            } 
            try { 
                q.consultaTopo(); 
            }catch (Exception e) {
                Console.WriteLine(e.Message); 
                } 
        }

        static void Parte2()
        {
            Console.WriteLine("=== Parte 2 - Rastreio (new Pilha(4)) ===");

            Pilha p = new Pilha(4);

            Console.Write("empilha(10)   -> "); p.empilha(10);  Passo(p);
            Console.Write("empilha(20)   -> "); p.empilha(20);  Passo(p);
            Console.Write("desempilha()  -> "); Console.Write(p.desempilha() + " | "); Passo(p);
            Console.Write("empilha(30)   -> "); p.empilha(30);  Passo(p);
            Console.Write("empilha(40)   -> "); p.empilha(40);  Passo(p);
            Console.Write("desempilha()  -> "); Console.Write(p.desempilha() + " | "); Passo(p);
            Console.Write("desempilha()  -> "); Console.Write(p.desempilha() + " | "); Passo(p);
            Console.Write("empilha(50)   -> "); p.empilha(50);  Passo(p);
        }

        static void Passo(Pilha p)
        {
            Console.Write("tamanho = " + p.tamanho() + " | pilha = ");
            p.mostra();
        }

        static void Parte3()
        {
            Console.WriteLine("=== Parte 3 - Usando a Pilha ===");

            Console.WriteLine("inverte(\"PUCMINAS\") = " + Aplicacoes.inverte("PUCMINAS"));
            Console.WriteLine("inverte(\"\")         = \"" + Aplicacoes.inverte("") + "\"");
        }

        static void Parte4()
        {
            Console.WriteLine("=== Parte 4 - Bubble Sort com pilhas ===");

            int[][] testes = {
                new int[] { 5, 2, 9, 1, 7 },
                new int[] { 1, 2, 3, 4, 5 } 
            };

            foreach (int[] v in testes)
            {
                int comps;
                int[] r = BubblePilhas.bubblePilhas(v, out comps);

                Console.Write("entrada = ");
                MostraVetor(v);
                Console.Write(" -> saida = ");
                MostraVetor(r);
                Console.WriteLine(" | comparacoes = " + comps);
            }
        }

        static void MostraVetor(int[] v)
        {
            Console.Write("{");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
                if (i < v.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("}");
        }

        static void Desafio()
        {
            Console.WriteLine("=== Desafio - ordenaPilha ===");


            Pilha p = new Pilha(6);
            foreach (int x in new int[] { 4, 9, 1, 7, 3, 5 })
                p.empilha(x);

            Console.Write("entrada : "); p.mostra();
            Pilha o = Aplicacoes.ordenaPilha(p);
            Console.Write("ordenada: "); o.mostra(); 
        }
    }
}