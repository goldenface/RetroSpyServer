﻿using System.Collections.Generic;

namespace PresenceConnectionManager.Profile.RegisterNick
{
    public class RegisterNickQuery
    {
        public static void UpdateUniquenick(Dictionary<string, string> dict)
        {
            GPCMServer.DB.Execute("UPDATE  namespace SET uniquenick=@P0 WHERE sesskey=@P1 AND partnerid=@P2", dict["uniquenick"], dict["sesskey"], dict["partnerid"]);


        }
    }
}
