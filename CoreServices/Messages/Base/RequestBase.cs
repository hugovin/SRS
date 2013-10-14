using System.Runtime.Serialization;


namespace CoreServices.Messages.Base
{
    /// <summary>
    /// Base class for all client request messages of the web service. It standardizes 
    /// communication between web services and clients with a series of common values.
    /// Derived request message classes assign values to these variables. There are no 
    /// default values. 
    /// </summary>
    [DataContract(Namespace = "")]
    public class RequestBase
    {
    }
}
