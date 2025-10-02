using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvores
{

    // <T> -> o Tsão é a especificação de um tipo genérico (Generics)
    public class TreeNode<T>
    {
        // O atributo data do tipo generic T armazenará o valor de fato
        public T ?Data { get; set; }
        // O atributo parent será a referência do nó pai da arvore
        public TreeNode<T>? Parent { get; set; }
        // Atribhuto Children é uma lista dos nós filhos também do tipo T
        public List<TreeNode<T>>? Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }


    }
}