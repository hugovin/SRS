using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using CoreServices.Messages.Base;


namespace CoreServices.Messages.Requests
{
    [DataContract(Namespace = "")]
    public class CountryRequest : RequestBase
    {

        [DataMember]
        public int CountryId;

        [DataMember]
        public string CountryName;

        [DataMember]
        public string ModifiedBy;

    }
}
