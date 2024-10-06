| Module              | Responsible        |
|---------------------|--------------------|
| Login               | Ana Larios         |
| Module 1 Employee   | Anthony Orlando    |
| Module 1 User Account | Ana Larios       |
| Module 2            | Ana Larios         |
| Module 3            | Anthony Orlando    |
| Module 4            | Ana Larios         |
| Documentation       | Ana Larios         |


Project Description
The Hi-Tech Order Management System is an important tool for Hi-Tech Distribution Inc., a big company that sells computer science books to schools in Quebec. 
This system is made using Microsoft Visual Studio 2022, C#, and SQL Server 2022/2019. Its main goal is to make managing orders, keeping track of inventory, 
dealing with customers, and managing employees easier and more organized. The Employee and User Account Management was implemented with ADO.NET in Connected Mode, 
the Sales Manager  was implemented with ADO.NET in Disconnected Mode. On the other hand the Inventory Controller that include the book and Authors Management and 
the Order Clerks was implemented using Enity Framework. 

Database Design
The database design was made to ensure efficiency, consistency, and data integrity. It adheres to best practices, including consistent naming conventions, normalization 
to minimize redundancy, and establishment of appropriate relationships among tables. Entities such as books, authors, publishers, customers, orders, 
and employees are accurately represented in the database schema.

![Picture1](https://github.com/user-attachments/assets/4296dc6c-4d3d-4d3e-afe0-aacfa1b23d24)

Application Domain Classes
The application domain classes encapsulate the business logic and domain-specific operations of the system. A comprehensive class diagram illustrates the structure and 
relationships among these classes/entities, providing a clear understanding of the system's architecture.

![Picture2](https://github.com/user-attachments/assets/b5da775a-133f-4c08-b5b3-fbc7552f9156)

GUI Classes
The visual part of the program, called the graphical user interface (GUI), is carefully designed to make it easy for users to interact with the system. It has simple menus 
and clear instructions to guide users. If users make mistakes, the system shows helpful error messages. The interface is designed to be safe and user-friendly, and it checks 
the information users enter to make sure it's correct before saving it.

![Picture3](https://github.com/user-attachments/assets/5eacaa71-d073-42ca-b287-73d9eb3478bc)

Data Access Classes
Data access classes leverage ADO.NET in both connected and disconnected modes for efficient database interactions. The Entity Framework is utilized to provide an object-oriented 
approach to data access, enhancing maintainability and extensibility.

![Picture4](https://github.com/user-attachments/assets/2f7c00d7-fc03-4989-a8f3-d48e1f1c250e)

Project Testing 

![Picture5](https://github.com/user-attachments/assets/bf14c278-8ad0-47ae-90c3-042d4afc2b55)

Login is used to send the user to the corresponding platforms, which are Inventory MIS Controller (Employee and User Account) and Order Management

![Picture6](https://github.com/user-attachments/assets/1ab07b1b-42a8-49ac-8713-66a042c69fb5)

![Picture7](https://github.com/user-attachments/assets/631a1e4d-235f-40dd-a718-caaead0d6ba8)

![Picture8](https://github.com/user-attachments/assets/1d72fbc2-8120-48b4-8a86-55c48f3c9f75)

![Picture9](https://github.com/user-attachments/assets/b4f167f1-92a5-4140-a7b8-9558da4dd8b8)

User Account
The user can modify the information of a customer by using their ID. The ID reference of each customer is displayed in the table below, where all active customers are listed. 
In case the user wishes to delete a customer who has open orders, an error message will be shown, preventing the user from deleting the customer until the order database is empty.
The application includes validations of phone number and minimum credit validations to ensure accurate information in the database.


![Picture10](https://github.com/user-attachments/assets/45683b56-8d6e-4a87-8066-ab4f3e322419)
![Picture11](https://github.com/user-attachments/assets/476b15d5-295f-4065-a871-b911cfa23379)

The user account also can udpate the password of the user account if I is needed 

Inventory Controller

![Picture12](https://github.com/user-attachments/assets/9c1f2e22-a53a-4484-9a98-faee33fe3efd)

If the user is allowed to access to the inventory controller it will display a many with authors and book management in different forms to do easier the organization of the information. 

![Picture13](https://github.com/user-attachments/assets/79754ff7-c447-41d8-8d96-1bccdc6b30e9)
![Picture14](https://github.com/user-attachments/assets/4940d962-ae77-4708-9114-fe9a9b9e9d4a)


We can search Authors from id, name and  email but just update with the Id, when the user whats to update a Author he needs to add the id number and it will display the full information
in the textlabels to make easier the experience for the user.

![Picture15](https://github.com/user-attachments/assets/6b981190-bd32-4394-8520-51a2e2410ca0)
![Picture16](https://github.com/user-attachments/assets/77bf71b5-27bb-48c6-b5f9-71c36f604d1a)
![Picture17](https://github.com/user-attachments/assets/ca9eb6fa-cd24-448f-baea-ebf7ee17a3ed)



Many authors can be part of one book but just one publisher is allow to have a book, to update the book data base is necessary to search for the ISBN of the book for that a list of books is available to the user. 

![Picture18](https://github.com/user-attachments/assets/0dff20c9-743c-47e2-94ca-7abf1b49c365)

![Picture19](https://github.com/user-attachments/assets/7f2a1213-d357-476b-b232-a720399265bc)


The order management has a list of customer information to give to the user the access of the list of orders for each customer, the user is allowed to modify any order, if the user want to modify the quantity or 
the books in the order the system will show the amount updated, also if the user don’t add the quantity of books it will display a error windows asking the user to add the quantity of books.

![Picture20](https://github.com/user-attachments/assets/a96f6913-d8b1-4413-8e72-bc7261571692)

![Picture21](https://github.com/user-attachments/assets/1da27456-1129-4f35-8780-21ca044454a9)


Conclusions 
Our project was centered around creating a software solution tailored to meet particular requirements. We dedicated significant time to planning, designing, and testing to guarantee its effectiveness. From conceptualizing the database layout to crafting user-friendly interfaces, we paid attention to every aspect of the development process. Now that we've completed the project, we're eager to witness its impact and how it fulfills its intended purpose.
As a programming student, this project helps me learn by doing. It boosts your coding skills, problem-solving abilities, and understanding of how software is developed















