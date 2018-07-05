using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    class Deque<T>
    {
        private class Node<G>
        {
            private G value;
            public G Value
            {
                get { return value; }
                set { this.value = value; }
            }

            private Node<G> next;
            public Node<G> Next
            {
                get { return next; }
                set { this.next = value; }
            }

            public Node(G val)
            {
                this.value = val;
                this.previousAddress = null;
                this.isHead = false;
            }

            public Node() //constructor for the head or tail
            {
                this.value = default(G);
                this.previousAddress = null;
                this.isHead = true;
            }

            private Node<G> previousAddress;
            public Node<G> PreviousAddress
            {
                get { return previousAddress; }
                set { previousAddress = value; }
            }

            private bool isHead;

            public bool IsHead
            {
                get { return this.isHead; }
            }
        }

        Node<T> head;//holds the starting point

        private int count;
        public int Count
        {
            get { return count; }
        }

        private Node<T> currentFront;

        private Node<T> currentBack;

        public Deque()
        {
            this.head = new Node<T>();
            this.currentFront = head;
            this.currentBack = head;
        }

        public void AddFront(T item)
        {
            Node<T> newNode = new Node<T>(item);
            this.currentFront.PreviousAddress = newNode;
            newNode.Next = currentFront;
            this.currentFront = newNode;
            count++;
        }

        public void AddBack(T item)
        {
            Node<T> newNode = new Node<T>(item);
            this.currentBack.Next = newNode;
            newNode.PreviousAddress = this.currentBack;
            this.currentBack = newNode;
            count++;
        }

        public T RemoveFront()
        {
            T returnValue = this.currentFront.Value;
            Node<T> temp = currentFront.Next;
            this.currentFront = null;
            this.currentFront = temp;
            temp = null;
            count--;
            return returnValue;
        }

        public T RemoveBack()
        {
            T returnValue = this.currentBack.Value;
            Node<T> temp = currentBack.PreviousAddress;
            this.currentBack = null;
            this.currentBack = temp;
            temp = null;
            count--;
            return returnValue;
        }

        public T GetFront()
        {
            return this.currentFront.Value;
        }

        public T GetBack()
        {
            return this.currentBack.Value;
        }

        public void Print()
        {
            Node<T> current = this.currentFront;
            for (int i = 0; i < count+1; i++)
            {
                if (current.IsHead == false)
                {
                    Console.WriteLine(current.Value);
                }
                current = current.Next;
            }
        }
    }
}
