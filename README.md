## Introduction
Simplify "DVD Library" application using Winform 

### Setup .env file
Create .env file in lab6_prjDVD/lab6_prjDVD

`
HOST=<Server name>
DATABASE=DVDLibrary
USER=mylogin 
PASSWORD=mylogin
`
### Having trouble with Database Connection
- Make sure that 4 properties in .env file is correct.
- Make sure that owner is correct (sp_changedbowner root;)
- Go to Server properties -> Security -> Select SQL Server and Windows Authentication mode -> Restart SQL Server Services.