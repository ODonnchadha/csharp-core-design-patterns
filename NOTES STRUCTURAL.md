- ADAPTER:
  - AKA "Wrapper" pattern. Class adapter & object adaper.
  - Intent of this pattern is to convert the interface of a class into another interface client expect.
  - Adapter allows for classes to work together that could not otherwsie because of incompatible interfaces.
  - Two variations. "Adapt the external system."
  - Object adapter:
    - Adaptee defines an existing interface that needs to be adapted.
    - Target defines the domain-specific interface that the client works with.
    - Client collaborates with objects conforming to the target interface.
    - Adapter adapts the interface of the adaptee to the target interface.
  - Class adapter:
    - C# prefers composition over inheritance and does not support multiple inheritance.
    - Adapter dervives from the adaptee.
  - Use cases:
    - When you want to use an existing class but the interface does not match the one you need.
    - When you want to create a reuseable class, the adapter, that works with classes that don't have compatible interfaces.
    - When you need to use several existing subclasses, don't want to create additional subclasses for each of them, but still need to adapt their interface.
  - Consequesnces:
    - A single adapter can work with many adaptees, and can add functionality to all adaptees at once.
    - The interface is separated out from the rest od the code. Single responsobility principle.
    - New types of adapters can be introduced withut breaking client code. Open/closed principle.
    - The object adapter makes it hard to override adaptee behavior.
    - Aditional complexity is introduced.
  - Related:
    - Bridge: Seperates interface from implementation, adapter changes the interface of an existing object.
    - Decorator: Changes an obkect without changing its interface, adapter changes the interface of an existing object.
    - Facade: You define a new interface for an entire subsystem, with adapter you'ree making an eisting interface useable via wrapping.
    - Proxy: Defines a surrogate for another object, but does not change its interface.
  - Summary:
    - Lets classses work together that couldn't before because of incompatible interfaces.
    - Object adapter relies on composition. Class adapter relies on multiple inheritance.

- BRIDGE:
  - The intent of this pattern is to decouple an abstraction from its implementation so the two can vary independently.
  - Seperate abstraction from implementation.
    - A means to replace an implementation with another implementation without modifying the abstraction.
    - Think of an abstraction as a way to simplify something complex. e.g.: Console.WriteLine();
    - Abstractions handle complexity by hiding the parts we don't need to know about.
    - Subclassing is one way to add functionality. Subclassing tends to add avoidable complexity.
  - Abstraction defines the abstraction's interface and holds a reference to the implementor.
  - Refined abstraction extends the interface defined by abstraction.
  - Implementor defines the interface for imlementation classes.
  - Concrete implementor implements the implementor interface and defines its concrete implementation.
  - Use cases:
    - When you want to avoid a permanent binding between an abstraction and its implementation (to enable swithing implementations at runtime.)
    - When abstraction and implementations should be extensible by subclassing.
    - When you don't want changes in the implementation of an abstraction to have an impact on the client.
  - Pattern consequences:
    - Decoupling: The implementation isn't permanently bound to thr abstraction.
    - As the abstraction and implementation hiearchies can evolve independently, new ones can be introduced as such. Open/closed principle.
    - You can hide implementation details away from clients.
    - You can focus on high-level logic in the abstraction and on the details in the implementation. Single responsibility principle.
  - Related patterns:
    - Abstract factory: Factory can create and configure a bridge.
    - Adapter: Adapter lets unrelated classes wrk together, bridge lets abstractions and implementation vary independently.
    - Strategy: Based on composition, like bridge.
    - State: Based on composition, like bridge.
  - Summary:
    - Decouple an abstraction from its implementation so the two can vary independently.
    - Main consequences: Decoupling. Improved extensibility. Hidden implementation details.

- DECORATOR:
  - The intent of the pattern s to attach additional responsibilities to an object dynamically. 
  - A decorator thus provides a flexible alternative to subclassing for extendung functionality. "Wrapper." (Like adapter.)
  - Adding responsibility to a class can be done by adding an additional method to the class.
  - We don't want to add that responsibility to a class, we want to add it to an instance of a class, an object, at runtime.
  - Classes can be extended with additional functionality:
    - Leads to violations of the single responsibility principle.
    - Classes get littered with code that doesn't belong there.
  - Component defines the interface for objects that can have responsibilities added to them dynamically.
  - Concrete component defines an object to which additional responsibilities can be attached.
  - Decorator maintains a reference to a component object, and defines an interface that conforms to the component's interface.
  - Concrete decorator adds responsibilities to the component.
    - When you have a need to add responsibilities to individual objects dynamically without affecting other objects.
    - When you need to be able to withdraw responsibilities you attached to an object.
    - When extension by subclassing is impractical or impossible.
  - Pattern Consequences:
    - More flexible than using static inheritance via subclassing: Responsibilities can be added and removed at runtime as hoc.
    - You can use the pattern to split feature-loaded classes until there's just one responsibility left per class: Single responsibility principle.
    - Increased efort is required to learn the system due to the amount of small, simple classes.
  - Related Patterns:
    - Adapter: Gives a new interface to an object, decorator only changes its responsibilities.
    - Composite: Adapter can be seen as a composite with only one component.
    - Strategy: Decorator lets you change the skin of an object, strategy lets you change its inner workings.
  - Summary:
    - Attach additional responsibilities to an object dynamically.
    - More flexible than static inheritance through subclassing.

- COMPOSITE:
  - The intent of this pattern is to compose objects into tree structures to represent part-whole hierarchies.
  - As such, it lets clients treat individual objects and compositions of objects unifornly: as if they all were individual objects.
  - e.g.: XML document structure.
  - Intrinsic knowledge about the object type is required: Class. Method to call. Nesting level.
  - Component declares the interface for objects on the compositions, and contains a common operation.
  - Leaf represents leaf objects in the composition, and has no children. It defines behavior for primitive objects in the composition.
  - Composite sotres child components and defines behavior for components having children.
  - Client manipulates objects in the composites through the component interface.
  - Variations exist.
    - Original template defines an operation to get a specific child.
    - Original template defines child management operations on the component abstract base class.
  - Use cases:
    - When you want to represent part-whole hierarchies of objects.
    - When you want to be able to ignore the differece between compositions of objects and individual objects.
  - Pattern Consequences:
    - Makes the client simple.
    - Its easy to add new kinds of components. Open/closed principle.
    - It can make the overall system too generic.
  - Related Patterns:
    - Chain of responsibility: Leaf component can pass a request through a chain of all parent components.
    - Iteratr: Can be used to traverse composites.
    - Visitor: Can be used to execute an operation over the full composite tree.
  - Summary:
    - Provide a transparent, easy way to work with tree-like structures.

- FACADE:
  - Intent of this pattern is to provode a unified interface to a set of interfaces in a subsystem. 
  - It defines a higher-level interface that makes the subsystem easier to use.
  - Facade knows which subsystem classes are responsible for a request and delegates client requests to appropriate subsystem objects.
  - Each subsystem class implements subsystem functionality. They don't know about the facade, but they do handle wprk assigned by it.
  - Use cases:
    - When you want to provide a simple interface into a complex subsystem.
    - When there are many dependencies between a client and the implementation classese of the abstraction.
  - Consequences:
    - The number of objects clients have to deal wuth are reduced.
    - It promotes weak coupling between the subsystem and its clients, enabling subsystem components to vary without affecting the client. Open/closed principle.
    - Clients are nor forbidden to use the subsystem classes.
  - Related patterns:
    - Abstract factory: Can provide an interface for creating subsystem objects.
    - Mediator: Also abstracts functionality of existing classes, but its purpose is abstracting communication between objects, while facade is about promoting easy of use.
    - Adapter: Makes existing interfaces useable by wrapping one object, while with facade you're defining a new interface for an entire subsystem.
  - Summary:
    - Make it easier for a client to use subsystems by rovoding one or more interfaces into those subsystems.
    - Higher-level layer to promote ease of use.

- PROXY
  - AKA "surrogate" pattern. The intent of this pattern is to provide a surrogate or placeholder for another object to control access to it.
  - e.g.: Security reasons. Performance reasons. "Add service reference" for API interaction.
  - Proxy is responsible for controlling the actual access to the remote API.
    - Provides an interface identical to the actual call. Although sometimes this is diverted from.
    - Proxy can take on the responsibility of executing code before or after calling the API.
  - Pattern structure:
    - Subject defines the common interface between the real subject and the proxy. This is the contract.
    - Real subject defines the real object that the proxy presents.
    - Proxy provides and interface identical to the subject. It maintains a reference to and controls access to the real subject.
  - Variations:
    - Remote proxy: Client can communicate with the proxy. And it feels like a local resource.
    - Virtual proxy: Allows for creating expensive objects on demand.
    - Smart proxy: Allows adding additional logic around the subject.
    - Protection proxy: Used to control access to an object.
    - Seperation is not always clear. Not all code generators play nice.
    - Chain proxies when multiple variations are required for the use case.
  - Document object scenario:
    - Virtual proxy to ensure creation only occurs when needed.
    - Protection proxy to add a restriction on who can access the document.
    - Proxy is lazy about initializing the document.
  - Use Cases:
    - Use the pattern when you need to add some form of access control to an actual object.
      - Remote proxy: When you want to provide  local representative.
      - Virtual proxy: When you only want to create expensive objects on demand.
      - Smart proxy: When you're in need of a caching or locking scenario.
      - Protection proxy: When objects should have different access rules.
  - Pattern consequences:
    - Remote proxy: Hides the fact that an object resides in a different netwrok space.
    - Virtaul proxy: The object can be created on demand.
    - Smart proxy: Additional housekeeping tasks can be executed when an object is accessed.
    - Protection proxy: Additional housekeeping tasks can be execute when an object is accessed.
    - Allows introduced new proxies without changing the client code: Open/closed principle.
    - Added cmplexity because of additional classes.
    - Performance impact of passing through additional layers.
  - Related Patterns:
    - Adapter: Provides a different interface while the proxy provides the same interface.
    - Decorator: Adds responsibilities to n object, while proxy controls access to an object.
  - Summary:
    - Provide a surrogate, or placeholder, for another object to control access to it.
    - Variations:
      - Remote proxy. Virtual proxy. Smart proxy. Protection proxy.

- FLYWEIGHT:
  - The intent of this pattern is to use sharing to support large number of fine-grained objects efficiently.
  - It does that by sharing parts of the state between these objects instead of keeping all that state in all of the objects.
  - e.g.: Creating a new object instance would require a lot of memory.
  - Intrisic versus extrinsic state:
    - Intrisic state data is independent of the context.
    - Extrinsic state data varies with the context: Different class instances might have different extrinsic state data which cannot be shared.
  - Considerations:
    - Does the application use a large number of objects?
    - Are storage costs high because of the large amount of objects?
    - Can most of the object state be made extrinsic?
    - If you remove extrinsic state, can a large group of objects be relaced by relatively few shared objects?
    - Does the application require object identity?
  - Flyweight declares an interface through which they can receive and act on extrinsic state.
  - Flyweight factory creates and manages flyweights and ensures they are properly shared.
  - Client maintains a reference of flyweights and computes or stores their extrinsic state.
  - Working with an unshared concrete flyweight:
    - Not all flyweights have to be shared.
    - Ushared concrete flyweight enables acting on extrinsic state while having unshareable intrinsic state.
    - No storage advantage anymore. But working with the flyweight remains transparent to the client.
  - Use Cases:
    - When the application uses a large number of objects.
    - When storage costs are high because of the large amount of objects.
    - When most of the object state can be made extrinsic.
    - When, if you remove extrinsic state, a large group oj objects can be replaced by relatively few shared objects.
    - When the application does not require object identity.
  - Pattern Consequences:
    - You may save a lot of memory when using the pattern for an applicable use case.
    - Processing costs might go up, but that's typically offset by the reduced storage costs.
    - The pattern is complex, which makes the code base more complicated as well.
  - Related Patterns:
    - State: Without instance variables makes these objects flyweights.
    - Strategy: Can be implemented as flyweight.
  - Summary:
    - Use sharing to support large numbers if fine-grained object efficiently.
    - Key concepts:
      - Intrinsic state: State data that is independent of the context. It does not change when the object is used.
      - Extrinsic state: State data that is not independent of the context and can change when the object is used.
    - Variation: Unshared concrete flyweight: Doesn't have state to share.