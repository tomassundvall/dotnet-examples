# Dotnet Examples
The purpose of this project is to test and playaround with different features of dotnetcore.

## Initiate project
mkdir src  
cd src  
dotnet new console -n Application
cd Application
mkdir src
mv Program.cs src/
cd ../..  
dotnet new sln -n dotnet-examples  
dotnet sln add src/Application/Application.csproj
Add .gitignore:
```
src/*/obj
src/*/bin
```

## Setup WebAPI project
Application.csproj
```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
  </PropertyGroup>
  
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Serilog.AspNetCore" Version="2.1.1" />
    <PackageReference Include="Serilog.Enrichers.Environment" Version="2.1.3" />
    <PackageReference Include="Serilog.Enrichers.Thread" Version="3.1.0" />
    <PackageReference Include="Serilog.Settings.Configuration" Version="3.1.0" />
    <PackageReference Include="Serilog.Sinks.Console" Version="3.1.1" />
  </ItemGroup>

  <ItemGroup>
    <None Include="appsettings.json" CopyToOutputDirectory="Always" />
  </ItemGroup>

</Project>
```