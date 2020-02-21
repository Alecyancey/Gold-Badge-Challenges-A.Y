using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim
{
    public class Claim
    {
        public TimeSpan _month = new TimeSpan(30, 0, 0, 0);
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                if (DateOfClaim - DateOfIncident < _month)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }




        public Claim() { }
        public Claim(int claimID, string claimType, string description, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
}
