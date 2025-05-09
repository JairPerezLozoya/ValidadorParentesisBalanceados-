using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidarParentesisBalanceados_Exam_JairPerez.Services
{
    public class ParenthesesValidator
    {
        public static bool IsBalanced(string input)
        {
            var stack = new Stack<char>(); // Pila para rastrear símbolos de apertura
            var mapping = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in input)
            {
                if (mapping.ContainsValue(c)) // Si es símbolo de apertura
                {
                    stack.Push(c); // Apilar
                }
                else if (mapping.ContainsKey(c)) // Si es símbolo de cierre
                {
                    if (stack.Count == 0 || stack.Pop() != mapping[c]) // Verificar coincidencia
                        return false;
                }
            }
            return stack.Count == 0; // True si la pila está vacía
        }
    }
}