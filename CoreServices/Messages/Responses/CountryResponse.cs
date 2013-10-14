using System.Collections.Generic;
using System.Runtime.Serialization;
using CoreServices.DataTransferObjects;
using CoreServices.Messages.Base;

namespace CoreServices.Messages.Responses
{
    [DataContract(Namespace = "")]
    public class CountryResponse : ResponseBase
    {
        /// <summary>
        /// Default Constructor for CountryResponse.
        /// </summary>
        public CountryResponse() { }

        [DataMember]
        public countryDto Country;

        [DataMember]
        public List<countryDto> Countries;


    }
}
