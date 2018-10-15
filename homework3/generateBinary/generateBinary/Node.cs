namespace generateBinary
{
    /// <summary>
    /// Singly linked node class
    /// </summary>
    /// <typeparam name="T"> Type T allows any type to be used in the function </typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Data in the node
        /// </summary>
        public T data;
        /// <summary>
        /// Points to the next node
        /// </summary>
        public Node<T> next;

        /// <summary>
        /// Default Constructor for Node class
        /// </summary>
        /// <param name="data"> Object in the Node </param>
        /// <param name="next"> Pointer to the next node </param>
        public Node (T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
