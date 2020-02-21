using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public Badge() { }
        public Badge(int badgeID)
        {
            BadgeID = badgeID;
        }
    }
    public class Door
    {
        public List<string> DoorAccessList { get; set; }
        public Door () { }
        public Door (List<string> doorAccessList)
        {
            DoorAccessList = doorAccessList;
        }
    }
    

}

/*
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccessList { get; set; }

        public Badge() { }
        public Badge(int badgeID, List<string> doorAccessList)
        {
            BadgeID = badgeID;
            DoorAccessList = doorAccessList;
        }
    }*/
