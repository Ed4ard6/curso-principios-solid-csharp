namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivies, IDevelopActivities
    {
        public Developer()
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

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
            Console.WriteLine("Yo estoy realizando las actividades requeridas para el backend");
        }

    }
}