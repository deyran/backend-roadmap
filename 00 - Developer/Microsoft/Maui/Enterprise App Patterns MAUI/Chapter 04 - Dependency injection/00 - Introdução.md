## Core Concept & Mechanism

- **Object instantiation**

	- A class constructor is invoked
	- Values required by the object are passed as arguments to it

- **Constructor Injection**

	- Required dependencies are directly injected into the constructor
## Benefits & Architecture

- **Use of Interfaces**: Dependencies are specified as interface types
- **Decoupling**: Separes/decouples concrete types from the code that relies on them
## DI Container

- **Role**: Holds the core configuration

- **Key Components**:

	- A list of registration
	- Mappings between interface/abstract types and their corresponding concrete types (implementations/extensions)
## Other Types of Injection (Less Common)

- Property Setter Injection
- Method Call Injection