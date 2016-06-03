using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.ObjectHandlers
{
    public class ObjectException : ApplicationException
    {

        //
        // Summary:
        //     Initializes a new instance of the ObjectException class.
        public ObjectException() : base()
        { }

        //
        // Summary:
        //     Initializes a new instance of the ObjectException class with a specified
        //     error message.
        //
        // Parameters:
        //   message:
        //     A message that describes the error.
        public ObjectException(string message) : base(message)
        { }

        //
        // Summary:
        //     Initializes a new instance of the ObjectException class with a specified
        //     error message and a reference to the inner exception that is the cause of this
        //     exception.
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for the exception.
        //
        //   innerException:
        //     The exception that is the cause of the current exception. If the innerException
        //     parameter is not a null reference, the current exception is raised in a catch
        //     block that handles the inner exception.
        public ObjectException(string message, Exception innerException) : base(message, innerException)
        { }

        //
        // Summary:
        //     Initializes a new instance of the ObjectException class with serialized
        //     data.
        //
        // Parameters:
        //   info:
        //     The object that holds the serialized object data.
        //
        //   context:
        //     The contextual information about the source or destination.
        protected ObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }

    }
}
