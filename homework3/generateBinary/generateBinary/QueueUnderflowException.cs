using System;

namespace generateBinary
{
    /// <summary>
    /// Exception that can catch situations where
    /// an illegal operation was performed on an empty queue.
    /// 
    /// QueueUnderflowException class extends SystemException
    /// </summary>
    class QueueUnderflowException : SystemException
    {
        /// <summary>
        /// Overrides the SystemException using base()
        /// </summary>
        public QueueUnderflowException() : base()
        {

        }

        /// <summary>
        /// Overrides the SystemException using base()
        /// </summary>
        /// <param name="message"> Receives a message and overrides SystemException using base(message) </param>
        public QueueUnderflowException(string message) : base(message)
        {

        }
        
    }
}
