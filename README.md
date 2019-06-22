# Dotnet Examples
The purpose of this project is to test and playaround with different features of dotnetcore.

## Initiate project
mkdir src  
cd src  
dotnet new console -n Application  
cd ..  
dotnet new sln -n dotnet-examples  
dotnet sln add src/Application/Application.csproj  
Add .gitignore:
```
src/*/obj
src/*/bin
```