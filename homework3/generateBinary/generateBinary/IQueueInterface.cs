using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace generateBinary
{
    /// <summary>
    /// First in, first out (FIFO) Singly linked queue interface
    /// </summary>
    interface IQueueInterface<T>
    {
        /// <summary>
        /// Adds an element to the end of the queue
        /// </summary>
        /// <param name="element"></param>
        /// <returns> the element that was enqueued </returns>
        T push(T element);

        /// <summary>
        /// Removes front element
        /// </summary>
        /// <returns> Returns front element </returns>
        T pop();

        /// <summary>
        /// Check to see if queue is empty
        /// </summary>
        /// <returns> True if the queue is empty, false if it is not </returns>
        bool isEmpty();
    }
}
