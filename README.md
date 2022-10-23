# MyPortFolio

This project is a Web App created using Asp.Net core with Entity framework and SqlServer

The application in hosted on Heroku and the data base on Somee.

The application is avaiable on this link : https://www.ayoublaouad.com/

<img src="https://user-images.githubusercontent.com/96794946/189964793-863b491c-8150-456c-b3aa-b928195e938f.png" width="700" height="400">

## Database
The informations about portfolio items and the owner of the portfolio are defined in the data access layer
![image](https://user-images.githubusercontent.com/96794946/196733411-4ea75ccf-9fcb-4c5a-bdb7-912cfc6ee41d.png)

## Repository/Unit of work

To create an abstraction layer between the data access layer and the business layer, I added Repository and Unit of work design patterns. Repository act like an in-memory collection of domain objects, while Unit of work maintains a list of objects and later saves in-memory updates as one transaction into database.

## Admin mode

The admin has the right to modify the portfolio items, also, he can read received messages :
<img src="https://user-images.githubusercontent.com/96794946/196310562-69ffeec8-58f7-4f03-8ba2-b85730c2c285.png" width="700" height="400">


<img src="https://user-images.githubusercontent.com/96794946/196753418-ca940e0f-4b09-43eb-8e06-9a787a24e043.png" width="700" height="400">
<img src="https://user-images.githubusercontent.com/96794946/195596992-6652fbb0-01b7-480a-bfde-332e1c367a61.png" width="700" height="400">
