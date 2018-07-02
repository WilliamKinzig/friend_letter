run > dotnet restore for every project.

create a project folder called friend_letter and in it, create a friend_letter.csproj file

You will create both a
.csproj file and Startup.cs
and run > dotnet restore for every project.

friend_letter/friend_letter.csproj

friend_letter/Startup.cs

create a file called Program.cs.

Just like with the Startup.cs file, this file contains code that we can reuse from project to project.
important to note that both files contain code that resides in the same namespace,
this code shares SCOPE
Startup.cs and Program.cs have access to each other

create a .gitignore file
obj/
bin/

run > dotnet restore
run > dotnet build
run > dotnet run
