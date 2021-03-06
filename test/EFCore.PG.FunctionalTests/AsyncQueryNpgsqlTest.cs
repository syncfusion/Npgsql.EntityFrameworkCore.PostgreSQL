﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Specification.Tests;
using Xunit;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.FunctionalTests
{
    public class AsyncQueryNpgsqlTest : AsyncQueryTestBase<NorthwindQueryNpgsqlFixture>
    {
        public AsyncQueryNpgsqlTest(NorthwindQueryNpgsqlFixture fixture)
            : base(fixture) {}

        #region Skipped tests

        [Fact(Skip = "Test skipped in EFCore (SqlServer/Sqlite)")]
        public override Task Projection_when_arithmetic_expressions() => null;

        [Fact(Skip = "Test skipped in EFCore (SqlServer/Sqlite)")]
        public override Task Projection_when_arithmetic_mixed() => null;

        [Fact(Skip = "Test skipped in EFCore (SqlServer/Sqlite)")]
        public override Task Projection_when_arithmetic_mixed_subqueries() => null;

        [Fact(Skip = "Fails on Npgsql because it does close in connecting state (https://github.com/npgsql/npgsql/issues/1127)")]
        public override Task Throws_on_concurrent_query_first() => null;

        #endregion
    }
}
