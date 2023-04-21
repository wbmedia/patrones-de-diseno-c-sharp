namespace PatronesDeDiseno.Singleton
{
    /// <summary>
    /// The log.
    /// </summary>
    public sealed class Log
    {
        private static Log? _instance = null;
        private string _path;
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            lock (_protect)
            {
                if (_instance == null)
                    _instance = new(path); // Pro tip: pedemos omitir '_instance = new Log()' solo llamando directamente --> new();
            }

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
