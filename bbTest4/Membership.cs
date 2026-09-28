using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbTest4
{
    public class Membership
    {
        private Member _owner;
        private int _monthlyPrice;
        private int _months;

        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MontlyPrice { get { return _monthlyPrice; } set { _monthlyPrice = value; } }
        public int Months { get { return _months; } set { _months = value; } }

        public Membership(Member owner, int montlyPrice, int months) 
        {
            _owner = owner;
            _monthlyPrice = montlyPrice;
            _months = months;
        }
        public int TotalCost() 
        {
            return Owner.isStudent ? (int)((MontlyPrice * Months)*0.8) : MontlyPrice * Months;
        }
        public void Extend(int months) 
        {
            _months += months;
        }

        public int PrivcePerVisit() 
        {
            return Owner.Visits ==0 ? MontlyPrice: TotalCost()/ Owner.Visits;
        }



    }
}
