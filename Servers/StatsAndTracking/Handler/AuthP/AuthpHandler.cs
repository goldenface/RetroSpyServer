﻿using System;
using System.Collections.Generic;

namespace StatsAndTracking.Handler.AuthP
{
    /// <summary>
    /// Authenticate with profileid
    /// </summary>
    public class AuthPHandler
    {
        public static void AuthPlayer(GstatsSession session, Dictionary<string, string> dict)
        {
            /* process the playerauth result */
            // \\pauthr\\100000\\lid\\1\\final\\
            session.SendAsync(@"\pauthr\26\lid\"+dict["lid"]);
            session.SendAsync(@"\getpidr\26\lid\" + dict["lid"]);
            session.SendAsync(@"\pauthr\26\lid\" + dict["lid"]);
            session.SendAsync(@" \getpdr\26\lid\"+dict["lid"]+@"\mod\1234\length\5\data\mydata");
            session.SendAsync(@"\setpdr\1\lid\"+dict["lid"]+@"\pid\26\mod\123");
        }
    }
}
