using System;
using System.Text;

namespace EDPilha
{
    public static class Aplicacoes
    {
        //Inverter texto
        public static string inverte(string s)
        {
            Pilha p = new Pilha(s.Length);

            foreach (char c in s)
            {
                p.empilha(c); 
            }
                  
            string resultado = "";

            while (!p.vazia())
            {
                resultado = resultado + (char)p.desempilha();
            }

            return resultado;
        }

        // Desafio
        public static Pilha ordenaPilha(Pilha p)
        {
            int n = p.tamanho();
            Pilha aux = new Pilha(n);

            while (!p.vazia())
            {
                int t = p.desempilha();

                while (!aux.vazia() && aux.consultaTopo() > t)
                {
                    p.empilha(aux.desempilha());
                }

                aux.empilha(t);
            }

            return aux;
        }
    }
}
