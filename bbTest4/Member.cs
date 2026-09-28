using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bbTest4
{
    public class Member
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public bool isStudent { get { return _isStudent; } set { _isStudent = value; } }
        public int Visits { get { return _visits; } set { _visits = value; } }

        public Member(string name, int age, bool isStudent) 
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
            
        }
        public void CheckIn() 
        {
            Visits++;
        }
        
        public string describe()
        {
            string valai = isStudent ? "Diak" : "Normal";
            return $"{Name} ({Age} eves, {valai}) - {Visits} latogatas";
        }


    }
}
