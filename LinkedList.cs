using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            count++;
        }

        public void Remove(T data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data.Equals(data))
            {
                head = head.Next;
                count--;
                return;
            }

            Node<T> previous = head;
            Node<T> current = head.Next;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    previous.Next = current.Next;
                    count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public bool InIdentityZone(Func<T, int, int, bool> hitTest, int x, int y)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (hitTest(current.Data, x, y))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T GetItem(Func<T, int, int, bool> hitTest, int x, int y)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (hitTest(current.Data, x, y))
                {
                    break;
                }
                current = current.Next;
            }
            return current.Data;
        }

        public int DrawItems(Graphics g, DataGridView table)
        {
            table.Rows.Clear();
            Node<T> current = head;
            int countRows = 0;
            while (current != null)
            {
                switch (current.Data)
                {
                    case Point point:
                        point.Draw(g);
                        table.Rows.Add();
                        table.Rows[countRows].Cells[0].Value = point.X;
                        table.Rows[countRows].Cells[1].Value = point.Y;
                        table.Rows[countRows].HeaderCell.Value = point.Name;
                        break;
                    case Line line:
                        line.Draw(g);
                        break;
                    case Rectangle rectangle:
                        rectangle.Draw(g);
                        break;
                }

                current = current.Next;
                countRows++;
            }
            return countRows;
        }
    }
}
