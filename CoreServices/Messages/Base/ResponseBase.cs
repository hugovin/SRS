using System.Runtime.Serialization;
using CoreServices.Common.DataType;

namespace CoreServices.Messages.Base
{
    /// <summary>
    /// Base class for all response messages to clients of the web service. It standardizes 
    /// communication between web services and clients with a series of common values and 
    /// their initial defaults. Derived response message classes can override the default 
    /// values if necessary.
    /// </summary>
    [DataContract(Namespace = "")]
    public class ResponseBase
    {
        /// <summary>
        /// Default Constructor for ResponseBase.
        /// </summary>
        public ResponseBase() { }

        /// <summary>
        /// A flag indicating success or failure of the web service response back to the 
        /// client. Default is success. Ebay.com uses this model.
        /// </summary>
        [DataMember]
        public AcknowledgeType Acknowledge = AcknowledgeType.SUCCESS;

        /// <summary>
        /// Message back to client. Mostly used when a web service failure occurs. 
        /// </summary>
        [DataMember]
        public string Message;

    }
}
