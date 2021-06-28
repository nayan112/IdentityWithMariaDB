
--dotnet tool install --global dotnet-ef
cd .\IdentityWithMariaDB
--creates initial migration folder
dotnet ef migrations add _InitialCreate
dotnet ef database update
--Scafold whole database or schema (--schema, -t) under 1 DB Context
dotnet ef dbcontext scaffold Name=DefaultConnection MySql.EntityFrameworkCore -o DBModel -f --context IdentityDBContext

error
Could not find type mapping for column 'efcoretest.aspnetusers.LockoutEnd' with data type 'timestamp'
Fix: change datatype to datetime

CI/CD with migration
https://markpatton.cloud/2020/07/03/entity-framework-core-migrations-in-azure-devops/