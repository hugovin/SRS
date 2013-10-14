using System.Runtime.Serialization;

namespace CoreServices.Common.DataType
{
    /// <summary>
    /// Enumeration of message response acknowledgements. This is a simple
    /// enumerated values indicating success of failure.
    /// </summary>
    [DataContract(Namespace = "")]
    public enum AcknowledgeType
    {
        /// <summary>
        /// Respresents an failed response.
        /// </summary>
        [EnumMember]
        FAILURE = 0,

        /// <summary>
        /// Represents a successful response.
        /// </summary>
        [EnumMember]
        SUCCESS = 1
    }
}