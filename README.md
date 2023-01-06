# cSharp
Advanced Concepts about c#

# Types of classes in c#
## Concrete Class 
This is the most basic type of class, and is defined using the class keyword. Here is an example of a normal class in C#

```c#
class MyClass
{
    // Class members (fields, methods, etc.) go here
}
```

## Static class 
A static class is a class that contains only static members and cannot be instantiated. It is defined using the static keyword. Here is an example of a static class in C#:


```c#
static class MyClass
{
    // Static fields, methods, etc. go here
}
```

## Abstract class 
An abstract class is a class that cannot be instantiated and is intended to be a base class for one or more derived classes. Abstract classes are defined using the abstract keyword and can contain abstract methods, which are methods that are declared but do not have an implementation. Here is an example of an abstract class in C#:

abstract class MyClass
{
    // Abstract class members (fields, methods, etc.) go here

    public abstract void MyMethod();  // Abstract method
}
