namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivies, ITestActivities
    {
        public Tester()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }
        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}