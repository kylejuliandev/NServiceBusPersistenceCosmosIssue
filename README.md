# NServiceBusPersistenceCosmosIssue

This repository serves to reproduce an issue with `NServiceBus.Persistence.CosmosDB` when referencing `Microsoft.Azure.Cosmos`. Specifically, the issue occurs when

`Microsoft.Azure.Cosmos` is targeting `>3.20.1` and `NServiceBus.Persistence.CosmosDB` is targeting `1.0.0`
