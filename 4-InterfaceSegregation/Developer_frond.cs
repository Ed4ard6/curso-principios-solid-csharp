namespace InterfaceSegregation
{
    public class Developer_frond : IWorkTeamActivies, IDevelopFrondActivities
    {
        public Developer_frond()
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

        public void Develop_frond() 
        {
            Console.WriteLine("I'm developing the functionalities required");
            Console.WriteLine("Yo estoy realizando las actividades requeridas para la parte visual de la aplicacion");
        }

    }
}