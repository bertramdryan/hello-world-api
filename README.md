# hello-world-api
Hello World Api contains a sample Rest API in C# with a small frontend in C#

## HelloWorld.API
HelloWorld.API contains an Asp.Net Core Web Api with 1 controller, that returns a single object or a list of the same object. The following steps will start the API within a debug kestral server. 
        1. Open a terminal in .\HelloWorld.API directory.
        2. type in **dotnet restore**
        3. when all the dependancies have been restored, type in **dotnet run**.
    


## HelloWorld.SPA
HelloWorld.SPA constains a client side, single page application that is written in C#/.Net. The application is compiled into WebAssembly, and executived natively in the browser, with JavaScipt simply telling the browser to execute the compiled code.  The benefit is this is native .Net code running in a browser.  To execute:
    1. Make sure the API is running, as this is where the clint app will source its data.
    2. change directory into the HelloWorld.SPA.
    3. Type in **dotnet restore** to get all the dependancies for a blazor application.
    4. Once all the dependancies are installed, type in **dotnet run**. 
    5. Then point your browser to http://localhost:5000


## HelloWorld.Tests
HelloWorld.Tests contains the unit test needed for the HelloWorld.API.  There are several ways to executing the test, but by far the simplest way (for the author), is to:
    1. Change directory into .\HelloWorld.Tests.
    2. Type in **dotnet restore** to get all the dependancies for the classLibrary.
    3. Once all the dependancies are installed, type in **dotnet test**


All code compiles and executes. 


