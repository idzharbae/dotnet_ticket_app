# .NET ticket app 

## Services 
- Auth Service 
- Ticket Service 
- Web Service 

## Auth Service
This service handles register and login 
### Tech Stack 
- GRPC 
- SQLServer 
### How to run 
`make docker-run` start SqlServer container 
`make migrate` create tables 
`make run` run service 

## Ticket Service 
This service handles ticket and category CRUD 
## Tech Stack 
- GRPC 
- SQLServer 
### How to run 
`make docker-run` start SqlServer container 
`make migrate` create tables 
`make run` run service 

## Web Service 
This service act as an interface for user to access other services 
## Tech Stack 
- Blazor 
## How to run 
make sure to run the backend services beforehand 
`make run` start the web 
