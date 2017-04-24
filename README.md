"# OnlineStoreSample" 

This a sample ASP.NET MVC web application of an Online Store. 

MY goals for this project are as follows:

1. Demonstrate my understand of ASP.NET MVC and the C# programming Language

2. Demonstrate my knowledge of Enity Framework and SQL

3. Demonstrate my knowledge of Code-First migrations for building and updating database structures.

4. Give other programmers a starting point for any of their MVC projects


Current Focus(I will update this section as I make further progress on this application):

1. Finish up Admin Functionality to add new Items to the database

2. Add an Admin User-role to prevent other users(without proper credentials) from adding items to the database


Next Task:

1. Create Views to allow users to search for items to evetually add to a cart once they log-in.


Current Functionality:

1. Use of Inheretance and Code-First work flow to create a table called Items in a MS SQL Database.
(Example: The Items Model is inhereted by models named Electronics, Accessories, and Media)

2. Controllers and Views have been added to allow user Employees to add new Items to the database

3. Front End authentication has been implemented to make sure Item data is in an acceptable form before it is inserted into
the databse.

4. Because my Model uses inheritance, all items are stored in the same table using a Discriminator.
This allows one controller to return any Item from the database table regardless of its type (i.e Camera,
Desktop, Laptop, Videogame, Major Appliance)