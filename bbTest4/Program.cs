namespace bbTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, friend!");
            Member member1 = new Member("csavo1", 56, true);
            Member member2 = new Member("csavo2", 5, true);
            Member member3 = new Member("csavo3", 16, false);

            member2.CheckIn();
            member2.CheckIn();

            member3.CheckIn();

            member1.CheckIn();
            member1.CheckIn();
            member1.CheckIn();


            Console.WriteLine(member1.describe());
            Console.WriteLine(member2.describe());
            Console.WriteLine(member3.describe());

            Membership memberhip1 = new Membership(member1, 153000, 5);
            Membership memberhip2 = new Membership(member3, 553000, 10);

            Console.WriteLine(memberhip1.TotalCost());
            Console.WriteLine(memberhip2.TotalCost());

            memberhip1.Extend(5);
            memberhip2.Extend(5);
            Console.WriteLine(memberhip1.TotalCost());
            Console.WriteLine(memberhip2.TotalCost());

            Console.WriteLine(memberhip1.PrivcePerVisit());
            Console.WriteLine(memberhip2.PrivcePerVisit());

            Gym gym1 = new Gym("gym1");
            Gym gym2 = new Gym("gym2");


            Console.WriteLine(gym1.TotalIncome());
            Console.WriteLine(gym2.TotalIncome());
            
            
            Console.WriteLine(gym1.MostActive().describe());
            Console.WriteLine(gym2.MostActive().describe());

            Console.WriteLine("-------");
            gym1.BestValue();
        }


    }
}
