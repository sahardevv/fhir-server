﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Azure.Documents;
using Microsoft.Health.Fhir.Core.Features.Search;

namespace Microsoft.Health.Fhir.CosmosDb.Features.Search.Queries
{
    public interface IQueryBuilder
    {
        SqlQuerySpec BuildSqlQuerySpec(SearchOptions searchOptions, bool calculateTotalCount = false);

        SqlQuerySpec GenerateHistorySql(SearchOptions searchOptions);
    }
}
