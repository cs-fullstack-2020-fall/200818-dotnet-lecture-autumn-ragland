# 200818 .NET MVC Intro

### Set Up
Create a new .NET MVC app using
```
dotnet new mvc -o Lecture
```

Run the aplication using 
```
dotnet run 
```
or `Run > Run without Debugging` in the naivation bar

### Get Endpoints
In the HomeController.cs file create a new method called Test that accepts two parameters to display the content "Hello NAME. You are AGE years old"
```c#
public IActionResult Test(string name, int age)
{
    return Content($"Hello {name}!\nYou are {age} years old");
}
```

Create a new controller class in the Controller directory called TestController.cs

Extend the base Controller class

Define a method called Greeting to display the content "Howdy! Welcome to the greeting page"
```c#
using Microsoft.AspNetCore.Mvc;

namespace MVCLecture.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Greeting()
        {
            return Content("Howdy! Welcome to the greeting page");
        }
    }
}
```

### Postman
Create a new collection in Postman called "200818 MVC Lecture"

Create a get request for each endpoint defined above. Access the first endpoint from `https://localhost:5001/Home/Test?name=Autumn&age=21`. Access the second endpoint from `https://localhost:5001/Test/Greeting`

Export the collection to this respository 
