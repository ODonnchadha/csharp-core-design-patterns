- TEMPLATE METHOD:
  - This is a fundamental pattern RE: code reuse.
  - The intent of this pattern is to define the skelton of an algorithm in a operation, deferring some steps to subclasses.
  - It lets subclasses redefine certain steps for an algorithm without changing the algorithm's structure.
  - The steps needed to be executed are the same for all classes, but some implementations can differ.
  - Abstract class defines the abstract primitive operations that concrete subclasses define to implement steps of an algorithm.
  - Also implements a template method defining the skeleton of an algorithm.
  - Concrete class implements the primitive operations to carry out subclass-specific steps of the algorithm.
  - Use Cases:
    - When you want to implement invariant parts of an algorithm only once, and want to leave it to subclasses to implement the rest of the behavior.
    - When you want to control which part of an algorithm subclasses can vary.
    - When you have a set of algorithms that don't vary much.
  - Pattern Consequences:
    - Template methods are fundamental technique for code reuse.
    - Template methods cannot be changed: The order of the methods thaey call is fixed:
  - Related Patterns:
    - Factory Method: Can be viewed as a specialization of template method. Template methods often use factory methods as part of their skeleton structure.
    - Strategy: Template method allows varying part of an algorithm through inheritance: A static approach. Strategy allows behavior to be switched at runtime, via composition: A dynamic approach.
  - Summary:
    - To define the skeleton of an algorithm in the operation, deferring some steps to subclasses.
    - Define the template method on the abstract base class and don't allow overridding it.
    - Mark methods that differ per subclass as abstract. Mark mwthods that differ for some subclasses as virtual.

- STRATEGY:
  - AKA Policy pattern.
  - The intent of this pattern is to define a family of algorithms, encapsulate each one, and then make them interchangeable. 
  - Strategy lets the algorithm vary independently from clients that use it.
  - The Players:
    - Strategy declares an interface common to all supported algorithms. Context uses it to call the algorithm defined by a concrete strategy.
    - Context is configured with a Concrete Strategy object and maintains a reference to a Strategy object.
  - Implementating a strategy pattern variation with a method parameter:
    ```csharp
      public void Export(IExportService service);
    ```
  - Use Cases:
    - When many related classes differ only in their behavior.
    - When you need different variants of an algorithm which you want to be able to switch a runtime.
    - When your algorithm uses data, code, or dependencies that the clients shouldn't know about.
    - When a class defines many different behaviors which appear as a bunch of conditional statements in its method.
  - Pattern Consequences:
    - It offers an alternative to subclassing your context.
    - New strategies con be introduced without having to change the context: Open/closed principle.
    - It eliminates conditional statements.
    - It can provide a choice of implementations with the same behavior.
    - If the client injects the strategy, the client must be aware of how strategies differ.
    - There's overhead in communication between the strategy and the context.
    - Additional objects are introduced, which increases complexity.
  - Related Patterns:
    - Flyweight: Strategy objects make good flyweights.
    - Bridge: Also based on composition, but solves a different problem.
    - State: Also based on composition, but solves a different problem.
    - Template Method: Allows varying part of an algorithm through inheritance: A static approach. Strategy allows behavior to be switched at runtime via composition: A dynamic approach.
  - Summary:
    - To define a family of algorithms, encapsulate each one, and make them interchangeable.
    - Common variation: Concrete strategy injected via method parameter.

- COMMAND:
  - The intent of this pattern is to encapsulate a request as an object, there letting you parameterize clients with different requests, queue or logs requests, and support undoable operations.
  - The command pattern allows decoupling the requester of an action from the receiver.
  - Very common in mobile or rich UI development.
  - The Players:
    - Invoker asks Command to carry out a request.
    - Command declares an interface for executing an operation.
    - Concrete Command defines a bidning between a Receiver and an action. It implements Execute() by invoking the corresponding operation(s) on a Receiver.
    - Receiver knows how to perform the operation(s) associated with carrying out a request.
    - Client creates the COncrete Command and sets its Receiver.
  - Use Cases:
    - When you want to parameterize objects with an action to perform.
    - When you want to support undo.
    - When you want to specify, queue, and execute requests at differet times.
    - When you need to store a list of changes to potentially reapply later on.
  - Pattern Consequences:
    - It decouples the class that invokes the peration from the one that knows how to perform it: Single responsibility principle.
    - Command can be manipulated and extended.
    - Commands can be assembled into a composite command.
    - Existing implementations don't have to be changed to add new commands: Open/closed principle.
    - Because an additional layer is added, complexity increases.
  - Related Patterns:
    - Composite: Can be used to implement commands composed of other commands.
    - Memento: Can be used to store the state a command requires to undo its effect.
    - Prototype: In case of supporting undo, a command that must be copied acts as a prototype.
    - Chain Of Responsibility: Handlers can be implemented as commands.
  - Patterns That Connect Senders & Receivers:
    - Chain Of Responsibility: Passes a request along a chain of receivers.
    - Command: Connects senders with receivers unidirectionally.
    - Mediator: Eliminates direct connections altogether.
    - Observer: Allows receivers of requests to (un)subscribe at runtime.
  - Summary:
    - Intended to encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
    - Define methods on command. IMplement on concrete command.
    - Invoker is often a UI element. Receiver can be any object.
    - Consider using a command manager. e.g.: Undo/redo.

- MEMENTO:
  - AKA token pattern.
  - The intent of this pattern is to capture and externlize an object's internal state so that the onject can be restored to this state later, without violation encapsulation.
  - Store and restore private field and property values.
  - Solve with memento: Making internal state public breaks encapsulation.
  - Provide two interfaces to the Meemento: 
    - A wide interface, used by the command to create the Memento. Narrow interface, used by the command manager (for storage.)
  - The Players:
    - Memento: Stores the internal state of the originator. The state should be protected against access by other objects as much as possible.
    - Originator: Creates a Memento with a snapshhot of its internal state. It also uses the Memento to restore its internal state.
    - Caretaker: Keeps the Memento safe and should not operate on or examine its contents.
  - Use Cases:
    - When part of an object's state must be saved so it can be restored later on.
    - And when a dorect interface to obtaining the state would expose implementation details and break encapsulation.
  - Pattern COnsequences:
    - It preserves encapsulation boundaries.
    - It simplefies the originator.
    - Using Mementos might be expensive.
    - It can introduce complexity to your codebase.
  - Related Patterns:
    - Command: Can use a Memento to store and restire its state.
    - Iterator: Memento can be used to capture the current interation state and potentially roll it back.
  - Summary:
    - Capture and internalize an object's internal state so that the object can be restored to this state later, without violating encapsulation.
    - With implementation, make the distinction between a narrow and a wider interface to the Memento.

- MEDIATOR:
  - The intent is to define an object, the mediator, that encapsulates how a set of objects interact.
  - It does this by forcing objects to communicate with each other via the mediator, promoting loose coupling.
  - NOTE: Obects hold references to each other. Management and keeping communication in sync is an issue.
  - A central object, the mediator, holds references to objects that want to communicate with each other. It handles communication between them.
  - The Players:
    - Mediator defines an interface for communicating with Colleague objects.
    - Colleague knows its Mediator and communicates with it instead of with another Colleague.
    - Concrete Mediator knows and maintains it Colleagues, and it implements cooperative behavior by coordingating Colleague objects.
  - MediatR: Simple mediator implementation in .NET. From the AutoMapper guy.
  - Use Cases:
    - When a set of objects communicate in well-defined but complex ways.
    - When, because an object refers to and communicates with many other objects, the object is difficult to reuse.
    - When behavior that is distributed between several classes should be customizable without a lot of subclassing.
  - Pattern Consequences:
    - It limits subclassing.
    - It decouples colleagues.
    - It simplifies object protocols. Not M:M anymore.
    - New mediators can be introduced without having to change the components: Open/closed principle.
    - It centralizes control, whch can make the mediator turn into a monolith. (Complex. Hard to maintain.)
  - Related Patterns:
    - Facade Pattern: Mediator abstracts communication between objects. Facada abstracts the interface to the subsystem objects to promote ease of use.
    - Patterns that connect senders & receivers:
      - Chain Of Responsibility: Passes a request along a chain of receivers.
      - Command: Connects senders with receivers unidirectionally.
      - Mediator: Eliminates direct connections altogether.
      - Observer: Allows receivers of requests to (un)subscribe at runtime.
  - Summary:
    - To define an abject that encapsulates how a set of objects interact.
    - Promotes loose coupling.
    - Object interaction can vary independently.
    - Use an internal method to ensure the mediator can't be set outside of an assembly.
    - Don't allow overriding methods when not needed.

- CHAIN OF RESPONSIBILITY:
  - The intent of this pattern is the avoid coupling the sender of a request to its receiver by giving more thn one object a chance to handle the request.
  - It does that by chaining the receiving objects and passing the request along the chain until an object handles it.
  - Too many conditional statements. Validation method becomes bloated. Cannot easily reuse the code.
  - The oroginal Chain Of Responsibility pattern is more strict. Original GO4:
    - Each handler only checks whether it can handle the request or not.
    - If it can't, the request is passed on.
    - If it can, the request is handled and no longer passed on. e.g.: Middleware(s).
  - The Players:
    - Handler defines an interface for handling requests and optionally implements the successor link.
    - Concrete Handler handles the requests it is responsible for. It can access the successor and potentially pass the request on.
    - Client initiats the request to a Concrete Handler object on the chain.
  - Use Cases:
    - When more than one object may handle a request and the handler isn't known beforehand.
    - When you want to issue a request to one of several objects (handlers) without specifying the receiver explicitly.
    - When the set of objects that handle a request should be specified dynamically.
  - Pattern Consequences:
    - It enables reduced coupling & works toward a single responsibility per class.
    - It adds flexibility in regard to assigning responsibilities to objects.
    - It does not guarentee receipt of the request.
  - Related Patterns:
    - Composite: The parent of a leaf can act as the successor.
    - Command: Chain Of Responsibility handlers can be implemented as commands.
    - Patterns that connect Senders & Receivers:
      - Chain Of Responsibility: Passes a request along a chain of receivers.
      - Command: Connects senders with receiver unidirectionally.
      - Mediator: Eliminates dirrect connections altogether.
      - Observer: Allows receivers of requests to (un)subscribe at runtime.
  - Summary:
    - Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
    - Implementation:
      - Provide an easy way to set the next handler.
      - Return the successor when setting the next handler to enable a fluent interface.
      - Use generics to make the handler more generic.

- OBSERVER:
  - AKA "Pub/Sub."
  - The intent of this pattern is to define a one-to-many dependency between objects so that when one object changes state all its dependents are notified and updated automatically.
  - Common pattern: Observables in Angular. Service commuication in microservice architectures.
  - Tight coupling becomes complex to maintain.
  - The Players:
    - Observer defines an updating interface for objects that should be notified of changes in a Subject.
    - Subject knows its Observers. Provides an interface for attaching and detaching them.
    - Concrete Observer stores state that must remain constistant with the Subject's state. They implement the Observer updating interface to keep state consistent.
    - Concrete Subject stores state of interest to Concrete Observer objects, and sends a notification to its Observers when its state changes.
    - NOTE: State is passed through via the Notify() method.
    - ORIGINAL: No need for the Concrete Observer to hold a reference to the Concrete Subject.
    - Both implementations are valid.
  - Use Cases:
    - When a change to one object requires changing others and you don't know in advance how many objects need to be changed.
    - When objects that observe others are not necessarily doing that for the total amount of time the application runs.
    - When an object should be able to notify other objects without making assumptions about who those objects are.
  - Pattern Consequences:
    - It allows subjects and observers to vary independently: Subclasses can be added and change wihtout having to change others: Open/closed principle.
    - Subject and observer are loosely coupled: Open/closed principle.
    - It can lead to a cascade of unexpected updates.
  - Related Patterns:
    - Patterns that connect Senders & Receivers:
      - Chain Of Responsibility: Passes a request along a chain of receivers.
      - Command: Connects senders with receiver unidirectionally.
      - Mediator: Eliminates dirrect connections altogether.
      - Observer: Allows receivers of requests to (un)subscribe at runtime.
  - Summary:
    - To define 1:M dependencies between objects so that when one object changes state all its deoendencies are notified and updated automatically.
    - Implementation:
      - Use an abstract base class to implement Notify(), Add(), Remove() functionality.
      - Concrete Subjects are responsible for managing their own state.

- STATE:
  - The intent of this pattern is to allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
  - e.g.: Withdrawing money from a bank account can change its state from REGULAR to OVERDRAWN. Or adding additional state.
  - Concrete implementation over enumeration.
  - The more states you have, the more improvements in regards to complexity you'll notice.
    - Typically not every state can transition to all others. 
  - Conditional statements become easier.
    - You don't have to check for the state you're in when you're in a state object.
  - The Players:
    - Context defines the interface that's of interest to clients. It maintains an instance of a Concrete State subclass that defines the current state.
    - Concrete State implements behavior associated with a state of the COntext.
    - State defines an interface for encapsulating the behavior associated with a particular state of the context.
  - Use Cases:
    - When an object's behavior depends on its state ad it must change it at runtime (depending on that state.)
    - When your objects are dealing with large conditional statements that depend on the object's state.
  - Pattern Consequences:
    - It localizes state-specific behavior and partitions behavior for different states: Single responsibility principle.
    - New states and transitions can be easily added by defining new subclasses: Open/closed principle.
    - The number of classes is increased, whoch adds additional complexity.
  - Related Patterns:
    - Flyweight: Without instance variables in the state objects, they become flyweights.
    - Singleton: State objects are often singleton.
    - Strategy: Also based on composition, but solves a different problem.
    - Bridge: Also based on composition, but solves a different problem.
  - Summary:
    - To allow an object to alter its behavior when its internal state changes.
    - Implementation:
      - Transitions are handled in the state objects themselves.
      - Context needs to pass requirements through to the underlying state objects to handle them.

- ITERATOR:
  - The intent of this pattern is to provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
  - Aggregate objects (List, Dictionary, Stack, Queue, etc...) keep their items in an internal structure.
    - You don't want to expose this internal structure.
    - You might not always want to traverse aggregate ojects in the same way. e.g.: Alphabetically, Reverse Order, etc...
    - Avoid bloating the aggregate onbject interface.
  - The Players:
    - Aggregate defines an interface for creating an Iterator object.
    - Iterator defines an interface for accessing and traversing elements.
    - Concrete Iterator implements the Iterator interface and keeps track of the current position in the traversal of the Aggregate.
    - Concrete Aggregate implements the Iterator interface to return an instance of the proper Concrete Iterator.
  - Use Cases:
    - When you want to access an aggregate object's content without exposing its internal representation.
    - When you want to support multiple ways of traversal for the same aggregate object.
    - When you want to avoid code duplication in regards to traversing the aggregate object.
  - Pattern Consequences:
    - Iterators simplify the interface of your aggregate structure as traversal code is seperated out: Single responsibility principle.
    - You can implement new types of aggregate objects as iterators without them interferring with each other: Open/closed principle.
    - Iterators can exist next to each other at the same time on the same collection.
    - Can be a bit overkill when you only use simple traversals and collections.
  - Related Patterns:
    - Composite: Iterators are often used to traverse its recursive structure.
    - Memento: Can be used to store the state of the iterator and, potentially, roll it back.
    - Visitor: You can use an iterator to traverse a potentially complex data structure and apply logic to the items in that structure with a visitor.
  - Summary:
    - To provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    - Imlementation:
      - Leverage existing framework code when possible.

- VISITOR:
  - The internt of this pattern is to represent an operation to be performed on the elements of an object structure.
  - Visitor lets you define a new operation without changing the classes of the elements on which it operates.
  - The more additional requirements come in, the more often the classes will need to be changed.
  - Also, adding all that behavior violates the single responsibility principle.
  - The Players:
    - Element defines an accept operation that takes a Visitor as an argument.
    - Concrete Element impements the accept operation that takes a Visitor as an argument.
    - Object Structure enumerates its elements. It may provide an interface to allow a Visitor to visit its Elements. It can be a composite or a collection.
    - Visitor declares a visit operation for each class of Concrete Element in the Object Structure.
    - Concrete Visitor implements each operation declared by Visitor.
  - Simplify the interface so that it does not to be updated with a new concrete type.
    ```csharp
      private interface IVisitor
      {
        void Visit(IElement element);
      }
    ```
  - Use Cases:
    - When an object structure contains many classes of objects with differing interfaces and you want to perform operations on them that deopend on their concrete classes.
    - When the classes defining your objectstructure don't have to change often but you do often want to define new operations over the structure.
    - When you've got potentially many operations that need to be performed on objects in your object structure but not necessarily on all of them.
  - Pattern Consequences:
    - It makes adding new operations easy; you can define a new operation by creating a new visitor: Open/closed principle.
    - A vistor can accumulate information on the objects it visits.
    - A visitor gathers related operations together and seperates unrelated onces: Single responsibility principle.
    - Adding a new concrete element class can be hard.
    - It might require you to break encapsulation.
  - Related Patterns:
    - Composite: A visitor can be used to apply an operation over an object structure defined by the composite pattern.
    - Iterator: You can use an iterator to traverse a potentially complex data structure and apply logic to the items in that structure with a visitor.
  - Summary:
    - To represent an operation to be performed on the elements of an object structure.
    - Implementation:
      - IVisitor interfaces amd its implementations work on concrete objects.

- INTERPRETER:
  - The intent of this pattern is to, given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
  - e.g.: LINQ queries. Regular expressions. C# compiler. Huge, unmanageable switch statement.
  - A set of expressions is called a syntax tree.
  - The Players:
    - Abstract Expresion declares an abstract Interpret operation that is common to all nodes in the abstract syntax tree.
    - Terminal Expression implements an Interpret operation associated with terminal symbols in the grammar.
    - Context contains information that is global to the Interpreter.
    - Client builds or is given the abstract syntax tree which represents a sentence in the language that the grammar defines.
    - Client invokes the Interpret operation.
  - Terminal expressions:
    - A symbol, the smallest meaningful part or unit of a language, is called a terminal.
    - Implemented through a terminal expression. Terminals make up statements.
  - Non-terminal expressions:
    - Statements that are made up of terminals and are allowed by a language are called non-terminals.
    - Can consist of terminals and/or non-terminals.
    - e.g.: A list of abstract expressions make up a non-terminal expression.
  - Use Cases:
    - When there's a language you can interpret and you can represent statements in the language as abstract syntax trees.
    - AND when the grammar is simple.
    - AND when the best possible efficiency isn't required. e.g. State machines.
  - Pattern Consequences:
    - It's easy to change and extend the grammar.
    - It's easy to implement the grammar.
    - Complex grammars are hard to maintain. Rules = Classes to maintain.
  - Related Patterns:
    - Composite: The abstract syntax tree is an instance of the composite pattern.
    - Iterator: You an use the iterator to traverse the tree.
  - Summary:
    - To, given a language, define a representation for its grammar along with an interpreter that uses the representation to intrepret sentences in the language.
    - A symbol, the smallest meaningful part or unit of a language, is called a terminal.
    - Statements that are made up of terminals and are aowed by a language care called non-terminals.