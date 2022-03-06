# HotelManagementSystem

This is a school project I did a while back, making the repo public now. This is not a very safe way of approaching the data insertion in the database, as it is very easily SQL Injectable, making it very vulnerable to deploy in real world scenarios, I only decided to do it this way because we were in the beggining of learning Appplication and Database connections and it was easier to learn this way.

Visual Studio 2022.

For the application to run, you must have Microsoft SQL Server installed.
Refer to https://www.microsoft.com/en-us/sql-server/sql-server-downloads for more information on how to install it.

After successfully installing MS SQL Server and SQL Server Management Studio, open the SQL Script.sql file, and execute it in SQL Server Management Studio.

After successfully creating the database, you need to create a Data Connection in your Visual Studio.

Open the Server Explorer tab and do the following:

![image](https://user-images.githubusercontent.com/59257091/156922223-2862d755-e7be-49ce-a424-bfa2c5c87e4c.png)

The following prompt will show up, put the Server Name and the Database Name in the prompt and hit OK.

![image](https://user-images.githubusercontent.com/59257091/156922328-4019d9e1-4c7e-40c6-85aa-8dea3f34473d.png)

After creating a successful Data Connection, go to its properties and copy the Connection String

![image](https://user-images.githubusercontent.com/59257091/156922384-1517db1f-227f-47e8-ab3e-e520a6205859.png)

After copying the Connection String, view each files code and replace all the connection strings with your own connection string.

After replacing all the connection strings, the application should now run properly. After Executing the application, log in with the following administator credentials:

Username: admin
Password: admin

TO VIEW THE PROJECT:
1. Clone the repo in your Visual Studio application.
2. Open the solution
3. View the code/design of the app.

TO RUN THE PROJECT:
Go to where you cloned the repo (default is the source folder in your C:\Users\)
source\repos\HotelManagementSystem\HotelManagementSystem\obj\Debug\HotelManagementSystem.exe

Run the HotelManagementSystem.exe file
