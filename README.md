# _State and National Parks Lookup_

#### By _**Trevor Hunter**_

#### _An API where you can look through different state and national parks._

## Technologies Used

* _C#_
* _.NET 5_
* _Entity_
* _MySQL_
* _ASP.NET Core MVC_
* _Identity and Authorization_
* _Postman_

## Description

_This API stores State and National Park information that you can sort through based on name, or whether or not it is a state or national park. Updates can be made to the information through PUT requests, as well as removing information through DELETE requests._

_This API also has a WIP Authorization addition. The ApplicationUser.cs file has been created, as well as AccountController.cs and changes to Startup.cs. Still needs to have a DTO created for the use of authorization without a front-end, and updates need to be made to the Parks Controller as well._

## Setup/Installation Requirements

* _Clone project from repo: https://github.com/TrevorH08/ParksLookup ._
* _Make sure you have Entity Framework Core installed at a Global level. To Ensure, paste the following into your terminal_
* ``` $ dotnet tool install --global dotnet-ef --version 5.0.1 ```
* _Create a file in the main project folder /ParksLookup called appsettings.json_
* _Enter this code into the file:_

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_lookup;uid=root;pwd=epicodus;"
  }
}
```

_From there run the following commands in the terminal:_
* ``` $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0 ```
* ``` $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2 ```
* ``` $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0 ```
* ``` $ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0 ```
* ``` $ dotnet restore ```
* ``` $ dotnet build ```
* ``` $ dotnet ef migrations add Initial ```
* ``` $ dotnet ef database update ```
* ``` $ dotnet run ```

## Endpoints

```
GET /api/parks
GET /api/parks/{id}
POST /api/parks
DELETE /api/parks/{id}
PUT /api/parks/{id}
```

### Search Parameters

```
/api/parks?stateOrNational=[ENTER STATE OR NATIONAL]
/api/parks?name=[ENTER NAME OF PARK]
```

## Known Bugs

* _Identity and Authorization not full implemented._
* _- Currently, The ApplicationUser.cs, AccountController.cs, and changes to Startup.cs have been made to incorporate it. There is an [HttpPost] route commented out in AccountController.cs, as it was having issues with a RegisterViewModel parameter since there is no ViewModel for this project. A DTO is needed to resolve this._
* _- Once DTO is added, changes to ParksController.cs would need to be made to account for Authorization for POST, PUT, and DELETE calls._

## License

MIT

If you have any questions or issues, head over to this projects GitHub Repository, and navigate to the "Issues" tab to leave feedback! If you have any suggestions or would like to contribute to this project, reach out and let me know!

Copyright (c) 11/06/22 Trevor Hunter

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
