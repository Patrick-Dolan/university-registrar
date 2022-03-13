# {Application name here}

#### By _**{List of contributors}**_

#### _{Brief description of application}_

## Technologies Used

* C#
* .NET 5.0
* dotnet
* MySql/Workbench

## Description

{This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have.}

## Setup/Installation Requirements

* Make sure you have MySql Workbench installed on your computer.
* Make sure to have dotnet-ef installed too.<br>
<em>This project uses <code>dotnet-ef --version 3.0.0</code> which I have globally installed but you can install it however you want. 
* Download repo to your computer using either clone or the download link.
* Open the project in VScode or your terminal/IDE of choice.
* Create a <code>appsettings.json</code> file in the root directory of the project folder. And add the following code replacing anything in square brackets with the information it represents specific to the project database:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

Example of complete appsettings.json:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=MySuperStrongPassword;"
  }
}

```
* CONTINUE WITH PROJECT SPECIFIC INSTRUCTIONS FROM HERE!

### Test Setup/Installation

* Open the repo on your editor of choice/terminal
* Navigate to ProjectName.Tests directory in your terminal
* Run the following command to setup testing:  
<code>dotnet restore</code>  
* Run tests by going to the test project in the terminal (ProjectName.Solution/ProjectName.Tests) and running the following command:  
<code>dotnet test</code>  
<br>--TEMPLATE INSTRUCTIONS DELETE FOLLOWING AFTER SETUP--  
[Resource on how to build/use this template](https://www.learnhowtoprogram.com/c-and-net-part-time/test-driven-development-with-c/mstest-configuration-quick-reference)
* In Startup.cs change ProjectName for database class name in configurationServices class.  
Example: <code>.AddDbContext<ProjectNameContext\></code> changed to <code>.AddDbContext<ToDoListContext\></code>
* In ProjectNameContext.cs model the DbSet type and name should be renamed to what the table in the database represents.
* <strong>Make sure to rename ProjectName & ClassName in ProjectName.Tests to match those in the ProjectName directory tree.</strong>  
* Rename the ProjectName in the following files for use: ProjectName in all folder its included in, Homecontroller.cs, ClassName.cs, PageName.cshtml, Program.cs,ProjectNameContext.cs, and Startup.cs.
* Once everything is renamed and can build navigate into the production folder <code>ProjectName/ProjectName/</code> and run the following command to make the initial migrations directory: <br>
<code>dotnet ef migrations add Initial</code>

<br>
* When renaming project files for new project make sure to rename all fields with "ProjectName" as the directory/file name. This includes line 13 of "ProjectName.Tests.csproj" to the names of your directories. 

## Known Bugs

* _No known issues_

## Contact Me

Let me know if you run into any issues or have questions, ideas or concerns:  
{PUT EMAIL HERE}

## License

_MIT_

Copyright (c) _date_ _author name(s)_