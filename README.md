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


make a folder called Controllers. Within that folder let's also create a file called HomeController.cs
run > dotnet run

add these for views csthml
Views/Home/Letter.cshtml
Views/Home/Journal.cshtml


├───FriendLetter.Solution
   ├───FriendLetter
       ├───Controllers
              ├───HomeController.cs
       ├───Models
       ├───Views
              ├───Home
                     ├───Journal.cshtml
       ├───FriendLetter.csproj
       ├───.gitignore
       ├───README.md
       ├───Program.cs
       ├───Startup.cs
       ├───Properties
       ├───wwwroot
       ├───Dependencies
