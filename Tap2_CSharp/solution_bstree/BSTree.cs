using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace bstree
{
    public class BSTree<T> : IEnumerable<T>
    {

        T data;

        BSTree<T> left;

        BSTree<T> right;

        IEnumerable<T> comp;

        public BSTree(IEnumerable<T> comp)
        {
            this.comp = comp;
            this.left = null;
            this.right = null;
            this.data = default;
        }

        public BSTree(IEnumerable<T> comp, T data)
        {
            this.comp = comp;
            this.left = null;
            this.right = null;
            this.data = data;
        }

        public void insert(T elem)
        {
            if ((this.data == null))
            {
                this.data = elem;
            }
            else if ((this.comp.(elem, this.data) <= 0))
            {
                if ((this.left == null))
                {
                    this.left = new BSTree<T>(this.comp, elem);
                }
                else
                {
                    this.left.insert(elem);
                }

            }
            else if ((this.right == null))
            {
                this.right = new BSTree<T>(this.comp, elem);
            }
            else
            {
                this.right.insert(elem);
            }

        }

        public bool contains(T elem)
        {
            if (this.data.Equals(elem))
            {
                return true;
            }
            else if ((this.comp.compare(elem, this.data) <= 0))
            {
                if ((this.left != null))
                {
                    return this.left.contains(elem);
                }
                else
                {
                    return false;
                }

            }
            else if ((this.right != null))
            {
                return this.right.contains(elem);
            }
            else
            {
                return false;
            }

        }

        public Iterator<T> iterator()
        {
            LinkedList<T> lista = new LinkedList<T>();
            BSTree.tree2list(this, lista);
            return lista.iterator();
        }

        public static void tree2list<T>(BSTree<T> arbol, List<T> list)
        {
            if ((arbol.getData() != null))
            {
                list.add(arbol.getData());
                if ((arbol.getLeft() != null))
                {
                    BSTree.tree2list(arbol.getLeft(), list);
                }

                if ((arbol.getRight() != null))
                {
                    BSTree.tree2list(arbol.getRight(), list);
                }

            }

        }

        public T getData()
        {
            return this.data;
        }

        public void setData(T data)
        {
            this.data = this.data;
        }

        public BSTree<T> getLeft()
        {
            return this.left;
        }

        public BSTree<T> getRight()
        {
            return this.right;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
