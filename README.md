# c-review-oop-practice---code-first-migration-Atinder-Pal

**Purpose:** This practice is designed to get amiliarization with the fundamentals of using Entity Framework to generate a database.  
This scenario is for when you would like to build your server and database both using C#. 
We will be building a simple database which will be expanded upon in future practices. O
ur database will eventually store “Shelves” made of different materials, with each shelf containing items. 
In this practice, we will only deal with the “Shelves” table.

**Author:** Atinder Pal

**Requirements:**
* Create a new console application in Visual Studio called CodeFirstPractice.
  * Add the packages:
    * Pomelo.EntityFrameworkCore.MySql
    * Microsoft.EntityFrameworkCore.Design
    * Microsoft.EntityFrameworkCore.SqlServer
* Create a model and a context for a simple database with the following:
  * A model called “Shelf” with:
  * A database table called “Shelf” with:
    * An int primary key called ID.
    * A varchar of length 50 called Name.
  * A context called “ShelfContext”.
* Use Entity Framework to create a database called “codefirst_practice” using your models.
  * This must be done in a migration.
* Write a program that will take in a shelf name and add it to the database using the context. You can create a method for this if you choose to.

**Link to TrelloBoard:** https://trello.com/b/aprQM50D/entity-framework-code-first-migration
