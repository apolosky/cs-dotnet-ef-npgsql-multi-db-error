# C# Dotnet Entity Framework Multi Database Context Error

An error occurs while using Dotnet EF with the Npgsql backend connecting to multiple databases. This is a solution to attempt to pinpoint the error.

In order to start this solution, it must first start on a linux platform (technically it's useable on Windows) to utilize the sqitch required for the docker containers.

The actual programs can be ran on either Windows or Linux, provided it has access to both databases outlined in the docker-compose file.

To start, just `docker-compose up`.

After starting the docker database images, some objects need to be created. This is done by running `dotnet run RunFirst`.

Finally, the error can be seen by running `dotnet run --project test.1`, which is `Can't cast database type db2.custom_type_2 to Int32`. However, it should be noted that it worked fine for the call to the first database. Interestingly, setting `THROW_IT = false` will cause the program to set d2 early, before any actual calls are made to the database. It should be noted that this does not throw an error.

There is also another project, test.2, which shows that both data access layers can be combined into one. This is a functioning workaround, however not one that I want to stay locked into.

To re-scaffold da1: `dotnet ef dbcontext scaffold "Host=localhost;Username=test_dba;Password=test_dba;Database=db1;Port=15432" Npgsql.EntityFrameworkCore.PostgreSQL --context DA1Context --context-dir Context --output-dir Models --schema db1`

To re-scaffold da2: `dotnet ef dbcontext scaffold "Host=localhost;Username=test_dba;Password=test_dba;Database=db2;Port=25432" Npgsql.EntityFrameworkCore.PostgreSQL --context DA2Context --context-dir Context --output-dir Models --schema db2`
