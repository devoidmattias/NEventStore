﻿namespace NEventStore.Persistence.AcceptanceTests
{
    using NEventStore.Persistence.SqlPersistence;
    using NEventStore.Persistence.SqlPersistence.SqlDialects;
    using NEventStore.Serialization;

    public partial class PersistenceEngineFixture
    {
        public PersistenceEngineFixture()
        {
            _createPersistence = () =>
                    new SqlPersistenceFactory(new EnviromentConnectionFactory("Firebird", "FirebirdSql.Data.FirebirdClient"),
                        new BinarySerializer(),
                        new FirebirdSqlDialect()).Build();
        }
    }
}