# Builder Pattern

## Gang of Four definition:
Separates the construction of a complex object from its representation so that the same construction process can create different representations.

We have a complex object, not simple, we are doing to separate the construction from its data.
Separating the logic from the data.
We can reuse the construction process for different data.

## Director
* Uses the concrete builder
* Knows how to build, what needs to be called, including the order to make the calls

## Builder
* Abstract class or interface
* Defines the steps for building, but not the sequence
* Hold an instance of the product (the Trip)
## Concrete Builder
* Should be more than one of these
* Implements the abstract builder
* The set of data for building the object – not the logic for building

## Product
* The object you are building

The Concrete builder has the data, or representation, the director has the logic of the sequence of what to do to create the object.

## When to use the builder pattern
* You have a complex object to create, that has logic combined with a lot of data (e.g. in the constructor)
* You have multiple Concrete builders – the object needs to be created differently with different data
* You always need to return the same object, just with different data. If you need a different object, this is the wrong pattern

## Disadvantages
* Constructing a new object requires some domain knowledge
* Explosion of Concrete builder objects
