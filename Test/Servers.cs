namespace Test
{
    public static class Servers
    {
        private static T getServers<T>() where T : new()
        {
            var servers = new T();
            return servers;
        }
        public static General general
        {
            get { return getServers<General>(); }
        }
    }
}