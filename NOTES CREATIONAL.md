- SINGLETON:
  - The intent of the singleton pattern is to ensure that a class only has one instance and to provide a global point of access to it.
  - Real-life example. Logger. One instance is prefered.
  - Holding the class instance in a global veriable doesn't prevent cliets from creating other instances of the class.
  - Make the class responsible for enxuring only one instance of itself exists.
  - Logger() (private/protected.) static Logger? Instance. return _instance. static Logger? _instance.
  - Log(). Regular instance methods. Not static.
  - Prefer lazy instantiation:
    - Create and store the instance when it is requested for the first time and return that instance on subsequent requests.
  - A singleton defines an instamce operation that lets clients access its unique instance.
  - Ensure that lazy initialization is thread-safe.
  - Pattern consequences:
    - Strict control over how and when clients access it.
    - Avoids polluting the namespace with global variables.
    - Subclassing allows configuring the application with an instance of the class you need at runtime.
    - Multiple instances can be allowed without having to alter the client.
    - Violates the single responsibility principle. This is all mostly dealt with via an IOC container.
  - Related patterns? Can be implemented as a singleton: Abstract factory. Builder. Prototype. State.
  - Summary:
    - Ensure that a class only has one instance with global access to it.

- FACTORY METHOD:
  - "Virtual constructor."
  - The intent is to define an interface for creating an object, but to let the subclasses decide which class to instantiate. 
  - Factory method lets a class defer instantiation to subclasses.
  - Product defines the interface of objects that the factory method creates.
  - Concrete product implements the product interface.
  - The creator declares the factory method, which must return a product.
  - Concrete creator implements creator and overrides the factory method to return an instance of concrete product.
  - Use cases:
    - Whan a class can't anticipate the class of objects it must create.
    - When a class wants its subclasses to specify the objects it creates.
    - When classes delegate responsibility to one of several helper subclasses, and you want to localize knowledge of which helper subclass is the delegate.
    - As a way to enable reusing of existing objects.
  - Consequences:
    - Eliminate the need to bind application-specific classes to your code. The code only deals with the interface.
    - New types of products can be added without breaking client code. open/closed principle.
    - Creating products is moved to one specific place in your code: the creator. single responsibility principle.
    - Clients might need to create subclasses or the creator class just to create a particular concrete product object.
  - Related patterns:
    - Abstract factory. Often implemented with factory methods.
    - Prototype. No subclassing is needed as it is not based on inheritance, but an initialize action on product is often required.
    - Template. Factory methods are often called from within template methods. 
  - Summary:
    - Define an interface for creating an object but let subclasses decide which class to instantiate.
    - Eliminate the need to bnd application-specific classes to code.
    - Product or creator can be implemented as interface, or abstract, base class.

- ABSTRACT FACTORY:
  - The intent of te abstract factory pattern is to provide an interface for creating families of related or dependent objects without specifying their concrete classes.
  - Provide a concrete factory implementation via the constructor.
  - The client is decoupled from the concrete factory implementation.
  - Use cases:
    - When a system should be independent of how its products are created, composed, and represented.
    - When you want to provide a class library of products and you only want to reveal their interfaces and not their implementations.
    - When a system should be configured with one of multiple familes of products.
    - When a family of related product objects is designed to be used together and you want to enforce this constraint.
  - Consequences:
    - It isolates concrete classes because it encapsulates the responsibility and the process of creating product objects.
    - New products can easily be introduced without breaking client code. Open/closed principle.
    - Code to create products is contained in one place. Single responsibility principle.
    - It makes exchanging product familes easy.
    - It promotes consistency among products.
    - Supporting new kinds of products is rather difficult.
  - Factory Method & Abstract Factory comparisons:
    - Factory Method: 
      - Exposes an interface with a method on it to create on object of a certain type.
      - Produces one product.
      - Creates objects through inheritance.
    - Abstract Factory:
      - Exposes and interface to create related objects: families of objects.
      - Produces a family of products.
      - Creates families if objects through composition.
  - Related patterns:
    - Abstract method. Can be implemented using factory methods.
    - Prototype. Abstract factory can be implemented using prototypes.
    - Singleton. A concrete factory is often implemented as a singleton.
  - Summary:
    - Provide an interface for creating families of related or dependent bjects without specifying their concrete classes.
    - Clients are isolated from implementation class. Decoupled.
    - Return ConcreteProduct via the underlying interface.

- BUILDER:
  - The intent of the builder pattern is to seperate the construction of a complex object from its representation.
  - By doing so, the same construction process can create different representations.
  - Creating a complex object is transparent for the consumer of the builder. Work on interfaces. Not implementations.
  - Builder specifies an abstract interface for creating parts of a Product object.
  - COncrete builder constructs and assembles parts of the product by implementing the builder interface.
  - It keeps track of the representation it creates, and provides an interface for retrieving the product.
  - Product represents a complex object under construction.
  - Director constructs the object using the builder interface.
  - Use cases:
    - When you want to make the algorithm for creating a complex object independent of the parts that make us the object and how they're assembled.
    - When you want the construction process to allow different representations for the object that's constructed.
  - Consequences:
    - It lets us vary a products' internal representation.
    - It isolates code for construction and representation. Thus improving modularity by encapsulating the way a complex object is constructed and represented. Single responsibility principle.
    - It gives us finer control over the construction process.
    - Complexity f the codebase increases.
  - Related patterns:
    - Abstract factory: Bot can be used to construct complex objects, but the builder constructs the complex objects step-by-step.
    - Singleton: A builder can be implemented as a singleton.
    - Composite: Composites are often built by builders.
    - Summary:
      - Seperate the cnstruction of a complex object from its representation so the same construction process can create different representations.
      - Use it when you want to make the algorithm for creating a complex object independent of the oarts that make up the object and how they're assembled.
      - Define an abstract base class or interface as Builder and have the director work on the builder and not the concrete builder implementations.

- PROTOTYPE:
  - The intent of this pattern is to specify the kinds of objects to create using a ptototypical instance, and create new objects by copying this prototype.
  - Remove client requirement to have intrinsic knowledge of concrete classes ad how to create them.
  - Prototype declares an interface for cloning itself.
  - Concrete Prototype implements an operation for cloning itself.
  - Client creates a new object by asking a prototype to clone itself.
  - Shallow copy:
    - Copy of primitive type values
    - Complex type values will be shared across clones.
  - Deep copy:
    - Copy of priitive values and complex type values.
  - ICloneable interface:
    - ICloneable enables us to provide a customized implementation that creates a copy of an existing object.
    - Disadvantages. 
      - It does not specify whether the cloning operation performs a deep copy, a shallow copy. or something inbetween.
      - It doesn't require all property values of the original instance to be copied to the new instance.
      - It returns an object, which means that the client would need an additional cast.
  - Use Cases:
    - When a system should be independent of how its objects are created and to avoid building a set of factories that mimic the class hierarchy.
    - When a system should be independent of how its objects are created and when instances of a class can have one of only a few different combinations of states.
  - Consequences:
    - Prototype hides the concrete product classes from the client, which reduces what the client needs to know.
    - Reduced subclassing.
    - Each implementation of the prototype base class must implement its own clone method.
  - Related patterns:
    - Abstract factory: Might store a set of prototypes from which it clones when a new instance is requested.
    - Factory method: Based on inheritance, but doesn't require an initization step.
    - Singleton: Can be implemented as a singleton.
    - Composite: Can use prototype for convenient object creation.
    - Decorator: Can use prototype for convenient object creation.
  - Summary:
    - Intent is to specify the kinds of objects to create using a prototypical instance and to create new objects by copying this prototype.
    - Implementation means that subclasses implement the Clone() method and clients work on the prototype.
    - SHallow copy is a copy of primitive types values, which a deep copy is a copy of primitive type values and complex type values.