# Mvc_Movie_Database_Deployment
I was given a piece of software (the MVC Movie Database) to deploy. 
The MVC Movie Store is a demonstration store for purchasing movies built upon the ASP.NET MVC platform.
When the web application has been deployed, the website should be running in “Release” not “Debug” mode.

Features

The MVC Movie Store has the following features:
•	Ability to search and filter movies based on category and search terms.
•	Ability to view additional details for each movie.
•	Ability to create additional movies.
•	Ability to edit existing movies.
•	Ability to delete existing movies.

Database
The store uses a Microsoft SQL Server database. The database will be populated with data when the web application is first run in debug mode as the database does not already exist, this includes a built-in administration user. Tip: You will need to create a blank database to connect to using Ms Server Management Studio, and update the app settings json file so population can happen for first use. 

Users
The web application contains a built in user account to act as an administrator. The details of this account can be specified in the MVC Movie Store config.json file.
