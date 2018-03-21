# EF.CodeFirst.TDD.NUnit
This example explore features of EF code first with help of TDD and NUnit. The project will give you little bit of idea how the code is organised and structure in real. However to keep the matter simple I am not following SOLID entirely. Also note that the project Codefirst.Domain is just added to illustrate that UI layer will never work directly with the repository. To follow the example please read below instruction.
# Test
I tried to put together different test cases to explore all EF Code first feature in an oder. Follow the test cases in ascending order

![](CodeFirst.UnitTest.TDD/ReadMeImages/TestStructure.jpg?raw=true "Optional Title")

## Database Initialization

This is little trickly. There are a few ways to intialise a database. Usualy you will decide at the start of the project as how you want to
initialise database. Here I have showcased two options. By default the connectionstring is comment in webconfig. To run Initialise_Database_NoConnectionString_WithoutSeed 
you must comment the connection string if its not already commented.

## CRUD Simple Type
Now once the database is initialze there isnt much difference for doing CRUD on simple types from that of database first. I added couple of test case to run through the scenario. Debug the test cases to see how it works. Remember evertime test case is run database is getting recreated. You can change this behavior in the TestSetUp method.

## CRUD for Complex type

# References
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

