namespace NEventStore
{
    using NEventStore;

    public static class RavenPersistenceWireupExtensions
    {
        public static RavenPersistenceWireup UsingRavenPersistence(this Wireup wireup, string connectionName)
        {
            return new RavenPersistenceWireup(wireup, connectionName);
        }

        public static RavenPersistenceWireup UsingRavenPersistence(this Wireup wireup)
        {
            return new RavenPersistenceWireup(wireup);
        }
    }
}