# MovieDB
## Testing SPA project

MovieDB is a testing SPA(Single-Page-Application) project which shows data, which exists in MoviesList class.

## Technologies used

- DevExtreme - extension with pre-build solutions for showing processing data
- ASP.NET

The architecture is 3-layered: 
- DAL(Data Access Layer)
- BLL(Business Logic Layer) 
- UIL(User Interface Layer)

### DAL(Data-Access-Layer)
In DAL we use Data folder with a list of movies and Data Transfer Objects. 

### BLL(Business-Logic-Layer)
In BLL we use Domains(in Domain) for taking out the information from MoviesList and for creating aggregates. Also we use Repositories(in Infra) for sending data from 
MoviesList using Data classes to Domains. After that services get data from domains and send it to the API controller.

### UIL(User-Interface-Layer)
In UIL we also use MVC pattern. We have API controllers, which get data from services and send data as ViewModel(In Facade) to View. The view uses DevExtreme extension
to show a table with movies where every line could be expanded to check the movie's details.

Also, we use Aids to safely transfer data from one class to another similar. 
