using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace WalkyDog
{
    public

    class
    CustomPrincipal : IPrincipal

    {
        private

       CustomIdentity _identity; public

       CustomIdentity Identity

        {
            get
            {
                return
              _identity ?? new
              AnonymousIdentity();
            }

            set

            { _identity = value; }

        }



        #region
     
    

    IIdentity
IPrincipal.Identity

        {
            get

            {
                return

              this.Identity;
            }

        }


        public
       bool
       IsInRole(string

       role)

        {
            return

           _identity.Id.Contains(role);

        }

        #endregion

    }
}
