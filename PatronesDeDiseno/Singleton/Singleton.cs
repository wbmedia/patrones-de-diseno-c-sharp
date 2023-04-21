namespace PatronesDeDiseno.Singleton
{
    public class Singleton
    {
        private static readonly Singleton _instance = new();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private Singleton()
        {
        }
    }
}