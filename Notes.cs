using System;

public class Class1
{
    /*			Clean Arch using DDD, CQRS
     *	- Structure
	 *		 - Domain Layer
	 *				- Core of the system 
	 *				- Has Domain Entity, Business Role, Aggregate, Value Object , Domain Events (Domain Driven Design), UnitOfWork Interface, Rpository Interfaces, Factory Interfaces , Domain Services , Custom Exceptions 
	 *				- All Other layers can access domain layer but not oppposite
	 *		 - Application Layer
	 *				- Has Use Cases, Application Services , Commands and Quieries (CQRS pattern)
	 *		 - Infrastructure Layer
	 *				- Anything is related to external systems 
	 *				- Hiding The implementation details for any External system to interact with it
	 *				- Has Databases Access, Messages Queues (RabbitMQ, Kafka), Email & Notification Service, Storage Service
	 *				- split into two seperate layers 
	 *					- persistance layer that we would handle anything related to database access
	 *					- Infrastructure layer would handle other external systems like email notifcation message Queues, Storage Service
	 *		 - Presentation Layer
	 *				- Define the entry point for outer users to be able to interact with system 
	 *				- Implemented Restful Api, grpc
	 *		- Web layer
	 *			- instead of define controller in web api layer, we define in presentation layer because if 
	 *				we define all controllers in web layer, we reference all other layers in web layer, and then we can access dbcontext in web layer and its break using the CQRS pattern
	 *				so we define all controllers in presentation layer
	 *	- Domain Driven Design
	 *		- Domain-Driven Design (DDD) is the approach to software development that enables us to translate complex problem domains into rich, expressive, and evolving software. It's the way we design applications when the needs of our users are complex.
	 *		- Two entities are considred equal if they have the same identifier even though the object reference might be different 
	 *		- convert anemic domain model to a rich domain model by pushing all the behavior and the interesting business login inside of our domain  
	 *		- What is An Entity
	 *			- Many objects are not fundamentally defined by their attributes, but rather by a thread of contiunity ( means that we need to be able to track an object through the lifetime of our application)  and identity (means that we can uniquely identify each object in our system)
	 *			- An object primarily defined by its identity is called an Entity
	 *			- Steps
	 *				- make Id property private init
	 *				- override Equals & GetHashCode
	 *				- Implement IEquatable<Entity>
	 *				- Implement static equals and not equals operators
	 *		- Validation
	 *			- Exceptions
	 *				- create custom exception that inherit from Exception
	 *				- Pros
	 *					- Defensive, our code will not proceed and we won't end up creating an entity in an invalid state
	 *					- Stack trace, generate a stack trace so that you can catch the exception in one of the upper layers, log the error and see which line of code throught the exception, this will make it easier for you to perform debugging
	 *					- Easier debugging
	 *				- Cons
	 *					- Performance  
	 *			- Result object
	 *				- Pros
	 *					- Expresiveness
	 *					- Performance
	 *					- Self-documenting
	 *				- Cons
	 *					- No stack trace
	 *		- Value Object
	 *			- is a type that is defined only by its values if two value objects have the same values they are considered equal 
	 *			- they are Immutable by design 
	 *			- used to solve primitive obsession
	 *			- Pros
	 *				- Type Safety
	 *				- Immutability
	 *				- Encapsulation
	 *				- Structureal Equality
	 *			- Cons
	 *				- Increased complexity
	 *		- steps to implement DDD
     *			- make ctor is private
	 *			- make all properties is private set
	 *			- make a factory static method
	 *			- when we working with collections inside of our domain model, a good rule of thumd is to encapsulate all collection access 
	 *				- private readonly List<Invitation> _invitations = new();
	 *				- public IReadOnlyCollection<Invitation> Invitations => _invitations;
	 *				- public Invitation SendInvitation(Memeber member){
	 *					var invitation = new Invitation();
	 *					_invitations.Add(invitation)
	 *				  }
	 *			- copy all validation in Domain
	 *	- Mediatr
	 *		- pipeline which is very similar to the middleware concept that you are used in asp.net what mediator allows us to do is to implement a pipline behavior which allows us to wrap our command or qeury handler and excute some accompanying logic 
	 *	- CQRS
	 *		- stands for command query responsiblity segregation 
	 *		- it's a very popular design pattern where you split the flows for reading and writning data into seperate path
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 * 
	 */
    public Class1()
	{
	}
}
