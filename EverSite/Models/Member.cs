﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverSite.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberUuid { get; set; }
        public long MemberDiscordId { get; set; }
    }
}
