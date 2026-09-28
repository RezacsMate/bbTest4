using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbTest4
{
    public class Gym
    {
        private string _name;
        private List<Membership> _memberships;

        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Membrstips { get { return _memberships; } set { _memberships = value; } }
        public Gym(string name) 
        {
            _name = name;
            _memberships = new List<Membership>();
        }

        public void AddMembership(Membership membership) 
        {
            _memberships.Add(membership);
        }
        public int TotalIncome() 
        {
            int total =0;
            foreach (var x in _memberships) 
            {
               total += x.TotalCost();
            }
            return total;
        }
        public Member MostActive() 
        {
            Membership bigest = _memberships.First();
            foreach (var x in _memberships) 
            {
                if (x.Owner.Visits > bigest.Owner.Visits) 
                {
                    bigest = x;
                }
                
                
            }
            return bigest.Owner;
        }
        public Membership BestValue() 
        {
            Membership smallest = _memberships.First(); ;
            foreach (var x in _memberships)
            {
                if (x.PrivcePerVisit() < smallest.PrivcePerVisit())
                {
                    smallest = x;
                }


            }
            return smallest;
        }
    }
}
