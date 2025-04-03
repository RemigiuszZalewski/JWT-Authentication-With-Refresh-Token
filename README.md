# JWT-Authentication-With-Refresh-Token
JWT Authentication in ASP .NET Core with usage of refresh token source code

Video where I explain the topic:
https://www.youtube.com/watch?v=G6eEPPBIkh8

In order to run the application there's a need to have PostgreSQL server up and running and execute following command to create a database and apply initial migration:

dotnet ef database update -s Authentication.API -p Authentication.Infrastructure (in project root directory)

access the scalar UI by using https://localhost:[PORT]/scalar

Enjoy!
