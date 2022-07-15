Requirements:
	- Visual Studio 2022 (Project Runs in .NET 6.0)
	- Microsoft SQL Server
	
How to Run:
	1. Inside the project solution, open the appsettings.json file and change the 
	    ConnectionStrings/SqlDbContext to be like below:
		"Server=(localdb);Database=PersonDb;Trusted_Connection=True;MultipleActiveResultSets=true"
		where (localdb) is the name of your local SQL Server
		
	2. Open a powershell window, go to the project directory and run the following command
		dotnet build
		
	3. From VisualStudio, Open the Tools menu and select Nuget Package Manager -> Package Manager Console
		Enter the command:
		update-database
		
		This will run the migration code located inside the migrations folder creating the database used for this project.
		
	4. From your powershell window, run the following command
		dotnet run
		
	5. Open a browser and navigate to https://localhost:7009/
	
	6. Press Ctrl+C to stop the application
