# Delicias Caseiras


## Intruduction

The "Delícias Caseiras" application was developed to optimize and simplify the internal management of orders and deliveries, customers, employees and stocks of a establishment (take-away). Dedicated exclusively to internal use, the application aims to improve operational efficiency and the customer experience.

Through the classes used, the application accurately models all stages of the process.

All information is stored in csv files for later consultation or data storage.

When customers place orders through social networks or telephone contact, they are entered into the system by an employee who monitors this section, taking the appropriate follow-up until they reach the customer's home.

The different sections of the program will be available depending on the position in the company, as soon as the employee enters the access credentials.

Each order has distinct states, from "pending" to "delivered", with specific dates assigned.

The "Restaurant" class assumes responsibility for storing the record of all orders, storing the global tracking of ongoing operations.

The interactive form provides features such as adding, excluding, editing and removing customers, stocks, employees and orders. In addition, the application offers the facility to calculate the total value of each order, considering the selected dishes and drinks, as well as verifying the amount invoiced per customer in a designated time interval.

The implementation of an order status forecast system further enhances customer service, ensuring timely and reliable deliveries, as any delay that occurs will be alerted.

In short, the "Delícias Caseiras" application represents a technological solution dedicated exclusively to the internal management of the establishment, promoting an agile and precise organization of all the processes involved.


## Functionalities

### Log In

When the application is launched, access credentials will be requested so that it is possible to verify the existence, in the storage, of information relating to any employee. If the fields match the data of a company employee, the windows related to the assigned status/function will be made available.

By default, password data is encrypted, but there is the option to view or hide the entered characters again.

<div align="Center">
<img src = "imgDoc/login.png">
</div>

If the operation has full access, that is, if it is the "Manager", the Menu will be presented as follows:

<div align="Center">
<img src = "imgDoc/full.png">
</div>

On the other hand, if it is an employee other than the "Manager", the Menu will be presented as follows:

<div align="Center">
<img src = "imgDoc/limited.png">
</div>