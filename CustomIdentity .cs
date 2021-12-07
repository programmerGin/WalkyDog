using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace WalkyDog
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string id, string who, string name)
        {
            Id = id;
            Who = who;
            Name = name;
        }

        public string Name { get; private set; }
        public string Who { get; private set; }
        public string Id { get; private set; }

        #region IIdentity Members
        public string AuthenticationType { get { return "Custom authentication"; } }

        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
        #endregion
    }
}
