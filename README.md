"# Web_Application_with_Razor_Pages" 

"MVS Application Project is on the master branch.
Web Application published state is on Deploy branch.

In order to run the application please do the following inside Deploy branch:
ROUTE:
\Web_Application_with_Razor_Pages\Web_Application_with_Razor_Pages\bin\Release\netcoreapp2.1\win-x86\Web_Application_with_Razor_Pages.exe

1. Double click LMB (left mouse button) on the - Web_Application_with_Razor_Pages.exe
2. CMD will open up indicating which localhost is set for the web app
3. Open your web browser of choice and type in the localhost:XXXX like you would type in any other website
4. When you are finished please go back to the CMD window and pres - Ctrl + C - to close localhost for this web app

------------------------------------------------------------------------------------------------------

Configuration: Release
Target Framework: netcoreapp2.1
Deployment Mode: Self-Contained
Target Runtime: win-x86

Please be informed that:

1. Deployment mode of finished application is set to Self-Contained,
which means that it is framework independend, or self-contained deployment (SCD).
In a nutshell - it does not rely on the presence of shared components on the target system.

2. Target Runtime is set to Windows X86, for different version please use master branch,
and publish the application using different Target Runtime.

------------------------------------------------------------------------------------------------------

Web Application using Razor Pages developement history:
- SQL DataBase written using T-SQL in [Design] window, and connected to C# application
- Implemented CRUD functionality with Razor Pages template
- Search function and filter by Genre
- New field in CRUD pages - Rating
- SQL script to ALTER DataBase without loosing any of the data. Later parsed with the DataBase Design
- Validation capabilities added to the Model file, so they apply everywhere in the application - following DRY ideology


Still pending activities to be done:
- Rework using CSS Framework


This web application was written according to https://docs.microsoft.com documentation"
