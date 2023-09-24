using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCorchetes
{
    public class VerificadorColchetes
    {
        private static readonly Dictionary<char, char> mapaColchetes = new Dictionary<char, char>
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

        public static bool VerificarOrdemColchetes(string input)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char c in input)
            {
                if (mapaColchetes.ContainsKey(c))
                {
                    pilha.Push(c);
                }
                else if (mapaColchetes.ContainsValue(c))
                {
                    if (pilha.Count == 0 || c != mapaColchetes[pilha.Pop()])
                    {
                        return false;
                    }
                }
            }

            return pilha.Count == 0;
        }

        public static bool ValidarEntrada(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(c => mapaColchetes.ContainsKey(c) || mapaColchetes.ContainsValue(c));
        }
    }
}
