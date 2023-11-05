<br>

 <p align="center">
    🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶
</p>
  <p align="center">
  🛶🛶🛶🛶🛶<u><big>|| <b>National Park API</b> ||</big></u>🛶🛶🛶🛶🛶
</p>
    <p align="center">
      🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶
    </p>
    <p align="center">
  <small>Initiated October 27nd, 2023</small>
  <br>
  <small>By:</small>
</p>
 <p align="center">
    <a href="https://github.com/Schmelzberry">
        <strong>Schmelzberry</strong>
    </a>
  </p>
    
------------------------------

## 🗺️ About the Project

### 🏕️ Description
An API that allows users to look up both state and national parks. It utilizes RESTful principles, version control, and has full CRUD functionality. The user is able to interact with/call on the API when using Postman and in a web browser using Swagger UI.

### 📃 Further Exploration - Pagination

Users can select how many results they want to see when creating a GET request for both National and State Parks.

Example of Pagination Request:

```https://localhost:5001/api/stateparks?page=1&pageSize=3```

When making a GET request, specify the following:

* page = The specific page you would like to see
* pageSize = how many results will be on a page

Resource Reference:  
* [CodeMaze](https://code-maze.com/paging-aspnet-core-webapi/https://code-maze.com/paging-aspnet-core-webapi/)
* [Microsoft](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-7.0)

### 🐛 Known Bugs

No known bugs currently.

### 🔨 Built With (Technologies Used)
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC 6.0.0](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.34 for Windows](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 18.2.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows. Version 6.0 is used in this project. 
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the .NET Core SDK from Microsoft Corp for macOS.  Version 6.0 is used in this project. 
#### Install ```dotnet script```
 Enter the command ``$ dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:

  * [VisualStudio Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

 #### Cloning

  1) Navigate to the project directory, [project repository here,](https://github.com/Schmelzberry/NationalParkApi).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `$ cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/Schmelzberry/NationalParkApi` and navigate to root directory of project.
  5) Run the command `$ cd NationalParkApi` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `$ code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Project repository here](https://github.com/Schmelzberry/NationalParkApi.git).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the NationalParkApi.Solution/NationalParkApi directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
 ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=national_park_api;uid=root;pwd=Password;"
    }
}
  ```
3) Change the server, port, and user id as necessary. Replace 'Password' with your own relevant MySQL password and userId. (set at installation of MySQL).

#### Database
  1) Navigate to NationalParkApi.Solution/NationalParkApi directory using the MacOS Terminal, Windows Powershell, or other preferred terminal (e.g. `cd Desktop/NationalParkApi.Solution/NationalParkApi`).
  2) Run the command `$ dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `$ dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to NationalParkApi.Solution/NationalParkApi directory using the MacOS Terminal, Windows Powershell, or other preferred terminal (e.g. `cd Desktop/NationalParkApi.Solution/NationalParkApi`).
  2) Run the command `dotnet watch run` to have access to the API in Postman or browser.

------------------------------

## 🚣‍♀️ API Documentation
Explore the API endpoints in Postman or a browser utlizing Swagger UI. 

### Using Swagger Documentation 
To build and view the National Park API with Swagger, launch the project using ```$ dotnet watch run``` within the production directory 'NationalParkApi', and input the following URL into your browser: `http://localhost:5000`

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```
..........................................................................................

### National Parks in US
Access information on a select number of National parks across the United States.

#### Example Query

###### *Returns a National Park matching the id provided at end of query string

```
https://localhost:5001/api/nationalparks/3
```

#### Sample JSON Response
```
{
  "nationalParkId": 3,
  "name": "Crater Lake National Park",
  "stateCode": "OR",
  "yearCreated": 1902
}
```

#### HTTP Request
```
GET /api/nationalparks
POST /api/nationalparks
GET /api/nationalparks/{id}
PUT /api/nationalparks/{id}
DELETE /api/nationalparks/{id}
```

###### Note on Ids:

* Always include an ID(whether it be a State or National Park) in the URL and in the json request body , as the application needs to know which park the user is trying to reference. 

* When using a POST request, do not include an ID, as the application will generate that for you.

#### Example Query

```
{
  "nationalParkId": 3,
  "name": "Crater Lake National Park",
  "stateCode": "OR",
  "yearCreated": 1902
}
```


#### National Park Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Return entries by name.
| state code | string | none | true | Return entries that match the user provided state code. |
| year founded | int | none | true | Return entries up to the user provided year. |

..........................................................................................

### State Parks in US
Access information on a select number of State parks across the United States.

#### Example Query
```
https://localhost:5001/api/stateparks/3
```

#### Sample JSON Response
```
{
    "stateParkId": 3,
    "name": "Silver Sands State Park",
    "stateCode": "CT",
    "yearCreated": 1960
}
```

#### HTTP Request
```
GET /api/stateparks
POST /api/stateparks
GET /api/stateparks/{id}
PUT /api/stateparks/{id}
DELETE /api/stateparks/{id}
```

#### State Park Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Return entries by name.
| state code | string | none | true | Return entries that match the user provided state code. |
| year founded | int | none | true | Return entries up to the user provided year. |


### 🤝 Contributors

| LinkedIn | GitHub | 
|--------|:------:|
| [Jake Elsberry](https://www.linkedin.com/in/jake-elsberry/) | [Schmelzberry](https://github.com/Schmelzberry)

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) Jake Elsberry

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
