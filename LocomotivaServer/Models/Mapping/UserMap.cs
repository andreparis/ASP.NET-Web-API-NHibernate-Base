using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models.Mapping
{
    public class UserMap : ClassMapBase<UserModel>
    {
        public UserMap()
        {
            Table("USERS");
            Map(x => x.Name).Length(250);
            Map(x => x.Password).Length(250);
            Map(x => x.Tellphone).Length(250);
            Map(x => x.Cellphone).Length(250);
            Map(x => x.ArcelorRegistration).Length(250).Column("Arcelor_Registration");
            Map(x => x.Email).Length(250);

        }
    }
}