using System;
using System.Collections.Generic;
using System.Text;

namespace bstree2
{
    public class BSTree<T : IComparer<T>> {
        internal void Insert(int v)
        {
            throw new NotImplementedException();
        }
    }
: 
    {

        T data;

        BSTree<T> left;

        BSTree<T> right;

        public BSTree()
        {
            this.left = null;
            this.right = null;
            this.data = null;
        }

        public BSTree(T data)
        {
            this.left = null;
            this.right = null;
            this.data = data;
        }

        public void Insert(T elem)
        {
            if ((this.data == null))
            {
                this.data = elem;
            }
            else if ((elem.compareTo(this.data) <= 0))
            {
                if ((this.left == null))
                {
                    this.left = new BSTree<T>(elem);
                }
                else
                {
                    this.left.insert(elem);
                }

            }
            else if ((this.right == null))
            {
                this.right = new BSTree<T>(elem);
            }
            else
            {
                this.right.insert(elem);
            }

        }

        public bool contains(T elem)
        {
            if (this.data.equals(elem))
            {
                return true;
            }
            else if ((elem.compareTo(this.data) <= 0))
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

        public IEnumerable<T> iterator()
        {
            LinkedList<T> lista = new LinkedList<T>();
            BSTree.tree2list(this, lista);
            return lista.iterator();
        }

        public static void Greater<T, extends, Comparable, <T>(void tree2list)
        {
        }


    public T getData()
    {
        return data;
    }

    public void setData(T data)
    {
        this.data = data;
    }

    public BSTree<T> getLeft()
    {
        return left;
    }

    public BSTree<T> getRight()
    {
        return right;
    }
}
}
