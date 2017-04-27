"# OnlineStoreSample" 

This a sample ASP.NET MVC web application of an Online Store. 

MY goals for this project are as follows:

1. Demonstrate my understand of ASP.NET MVC and the C# programming Language

2. Demonstrate my knowledge of Enity Framework and SQL

3. Demonstrate my knowledge of Code-First migrations for building and updating database structures.

4. Give other programmers a starting point for any of their MVC projects


Current Focus(I will update this section as I make further progress on this application):

1. Finish update actions for the Amin User Role to update Items in the database/ Just mapping the data before 
saving changes.

Next Task:

1. Create Views to allow users to search for items to evetually add to a cart once they log-in.

2. Create Restful API's to load data into nice looking bootstrap tables for customers.

3. Add search bars and ajax for customers and employees to search for Items.

Current Functionality:

1. A user role has been added so only employees that use the admin@store.com account can use CRUD actions.
Here I am using [Authorize] so no outside user can call any CRUD actions.  

2. Full CRUD functionality for Items using only one Controller(ItemsController) and ability to 
choose the type of Item we want to add to the database or edit(i.e. Desktop, Laptop. etc.)

3. Use of Inheretance with models and Code-First work flow to create a table called Items in a MS SQL Database.
Here I am using Code-First migrations for full versioning of my database.

4. Front End authentication has been implemented to make sure Item data is in an acceptable form before it is inserted into
the databse.
