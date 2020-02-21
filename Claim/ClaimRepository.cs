using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim
{
    class ClaimRepository : Claim
    {
        protected readonly List<Claim> _claimDirectory = new List<Claim>();
        public List<Claim> DisplayDirectory()
        {

            return _claimDirectory;
        }
        public void DisplayNextClaim()
        {
            foreach (Claim claim in _claimDirectory)
            {
                Console.WriteLine($"{claim}");

            }
        }

        public Claim GetItemByNumber(int claimID)
        {
            foreach (Claim claim in _claimDirectory)
            {
                if (claim.ClaimID == claimID)
                {
                    return claim;
                }
            }
            return null;
        }

        public Claim GetFirstListItem()
        {//works if there are claims, but maybe some logic to keep it from breaking when queue.count == 0
            Claim firstClaim = _claimDirectory.ElementAt(0);
            return firstClaim;
        }
        public bool RemoveFromDirectory()
        {
            List<Claim> directory = _claimDirectory;
            Claim topClaim = _claimDirectory.ElementAt(0);
            return directory.Remove(topClaim);
        }
        public bool AddNewClaim(Claim newClaim)
        {
            int menuLength = _claimDirectory.Count();
            _claimDirectory.Add(newClaim);
            bool wasAdded = menuLength + 1 == _claimDirectory.Count();
            return wasAdded;
        }
    }

}