# Michael-s-Cafe_v2

## SWE 3313 Class Project

#### Contributers:
* chel8282
* noahdnixon
* JoelSmi
* Arturo
* Eric

#### Arturo's Half
* Originally seperated to handle the basic application opening screen as well as account creation and the menu itself for Michael's Cafe
* The opening screen offers the ability to continue as guest --  which went directly to the menu for ordering, loging in -- which took the user to the login screen, or Create an account.
* Create an accrount would follow the three screens of gathering user information which would, at the end of account creation, store the profile to a file for access later in the project
* Loging in would involve accessing the customer file and seaching the username and pasword for proper checking
* All three of these start screen options: Continue as Guest, Account Creation, or logging in, would eventually end up at the menu screen where the customer is able to select the items they wish to purchase

###### Issues Recognized:
* Security for the customer information file
* communication and formating of information between screens/application components

#### Eric's Half
* This half of the project was meant to focus on the payment options, route for delivery, as well as the receipt and confirmation screen.
* There are different payemnt screens depending on if there is infomration stored in the customers profile allowing for the user to add a credit card or use existing, if found on  the profile
* The application then offers the different means of receiving the order, delivery or pickup
* Finally there checking of the delivery route, when one is availible and applicable, and payment conformation is displayed before offering for the user to return to the opening screen

###### Issues Recoginized:
* Major secuirty concern for user payment information in the customer profile file
* Issues communicating between the two halfs of the project when implementing the back buttons on the pages of the application
