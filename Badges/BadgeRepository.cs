using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    /*
    public class BadgeRepository : Badge
    {
        protected Dictionary<int, List<string>> _badgeDirectory = new Dictionary<int, List<string>>();
        

        public Dictionary<int, List<string>> CreateDictionary(Badge badge)
        {
            _badgeDirectory.Add(badge.BadgeID, badge.DoorAccessList);
            return _badgeDirectory;
        }



        public void CreateNewBadge(Badge newBadge)
        {
            int badgeID = new int();
            List<string> doorList = new List<string>();
            newBadge.BadgeID = badgeID;
            newBadge.DoorAccessList = doorList;

            _badgeDirectory.Add(badgeID, doorList);
        }



        public Dictionary<int, List<string>> ShowAllBadges()
        {
            return _badgeDirectory;
        }



        public List<string> UpdateDoorsOnBadge(int badgeID, List<string> newDoorList)
        {
            List<string> oldDoorList = ReturnValueFromKey(badgeID);
            if
        }



        public Badge DeleteAllDoorsOnBadge(Badge badge)
        {
            if (_badgeDirectory.ContainsKey(badge.BadgeID))
            {
                badge.DoorAccessList = new List<string>();
                return badge;
            }
            else
            {
                return badge;
            }
        }



        public List<string> ReturnValueFromKey(int key)
        {
            if (_badgeDirectory.ContainsKey(key))
            {
                return _badgeDirectory[key];
            }
            return null;
        }
    }


    */






    public class BadgeRepository1 : _badgeDirectory
    {
        protected Dictionary<Badge, Door> _badgeDirectory = new Dictionary<Badge, Door>();


        public void CreateNewBadge(Badge badge, Door door)
        {
            _badgeDirectory.Add(badge, door);
        }


        public Dictionary<Badge, Door> DisplayBadgeDirectory()
        {
            return _badgeDirectory;
        }


        public void UpdateBadgeDoorList(Badge, badge, Door oldList)
        {
            
        }

        public List<string> ReturnBadgeByID(int badgeID)
        {
            foreach (_badgeDirectory.)
            {
                if ( = _badgeDirectory.TryGetValue(badge))
                {
                }
            }
        }
        public List<string> ReturnBadgeFromID(int badgeID)
        {
            if ()
                return _badgeDirectory[badgeID];
        }
    }
}
