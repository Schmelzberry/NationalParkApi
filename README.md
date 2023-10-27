<br>
<p align="center">
  <u><big>|| <b>🛶National Park API🛶</b> ||</big></u>
</p>
 <p align="center">
    🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶
</p>
  <!-- GitHub Link -->
  <p align="center">
    <a href="https://github.com/Schmelzberry">
        <strong>Schmelzberry</strong>
    </a>
  </p>
    <p align="center">
      🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶🛶
    </p>
    <br>
    <p align="center">
  <small>Initiated October 27nd, 2023.</small>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🏕️-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🚣‍♀️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
An API that allows users to look up both state and national parks. It utilizes RESTful principles, version control, and pagination is a work in progress. The user is able to interact with/call on the API when using Postman and in a web browser using Swagger UI.

### 🦠 Known Bugs

* This is an API for learning purposes, and to create a robust README with clear install instructions.

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC 6.0.0](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.34 for Windows](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 18.2.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows. Version 6.0 is used in this project. 
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the .NET Core SDK from Microsoft Corp for macOS.  Version 6.0 is used in this project. 
#### Install ```dotnet script```
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

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
  5) Run the command `$ cd CretaceousApi` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Project repository here](https://github.com/Schmelzberry/NationalParkApi.git).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the CretaceousApi/CretaceousApi directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  (Add appsettings.Development.json???)
 ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=coffee_tracker_api;uid=root;pwd=Password;"
    }
}
  ```
3) Change the server, port, and user id as necessary. Replace 'Password' with your own relevant MySQL password and userId. (set at installation of MySQL).

#### Database
  1) Navigate to CretaceousApi/CretaceousApi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/CretaceousApi/CretaceousApi`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to CretaceousApi/CretaceousApi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/CretaceousApi/CretaceousApi`).
  2) Run the command `dotnet watch run` to have access to the API in Postman or browser.

------------------------------

## 🚣‍♀️ API Documentation
Explore the API endpoints in Postman or a browser utlizing Swagger UI. 

### Using Swagger Documentation 
To build and view the Cretaceous API with Swagger, launch the project using `dotnet watch run` within the production directory 'CretaceousApi', and input the following URL into your browser: `http://localhost:5000`

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

#### Example Query
```
http://localhost:5000/api/animals?minimumAge=5
```

#### Sample JSON Response
```
{
  "animalId": 1,
  "species": "Woolly Mammoth",
  "name": "Matilda the Woolly Mammoth",
  "age": 8
}
```
..........................................................................................

### Dinosaurs from Cretaceous Period
Access information on fake dinosaurs from cretaceous period.

#### HTTP Request
```
GET /api/animals
POST /api/animals
GET /api/animals/{id}
PUT /api/animals/{id}
DELETE /api/animals/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| species | string | none | false | Return any entries that matches the user provided species. |
| age | int | none | false | Return entries up to the user provided number. |

#### Example Query
```
https://localhost:5000/api/animal/?species=shark&name=pip
```

### 🤝 Contributors

| Author | GitHub | 
|--------|:------:|
| [Jake Elsberry](https://www.linkedin.com/in/jake-elsberry/) | [Schmelzberry](https://github.com/Schmelzberry)

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) Jake Elsberry

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

