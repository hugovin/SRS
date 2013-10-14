using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreServices.DataTransferObjects
{
    public class RepositoryRequesterInfo
    {
        public int UserId { get; set; }


        public RepositoryRequesterInfo() { }


        public RepositoryRequesterInfo(int userId)
        {
            this.UserId = userId;
        }
    }
}
