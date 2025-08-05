# User Information
- Name: Theodore Gyaqueh Abbey
- Student ID: 11343393  
<br><br />
# DCIT 318: Programming II - Assignment 2

This repository holds the solutions for Assignment 2 of the DCIT 318 course, focusing on object-oriented programming principles in C#. The assignment includes three separate applications demonstrating Inheritance, Abstract Classes, and Interfaces.

## Prerequisites

To build and run these programs, you will need the following tools installed on your local machine:
* .NET SDK (9.0)
* A code editor or IDE (e.g., Visual Studio, VS Code)
* Git for version control

## How to Run

1.  Clone the repository to your local machine using Git.
2.  Open your terminal or command prompt.
3.  Navigate into the directory of the specific program you want to run (e.g., `InterfacesApp`).
4.  Execute the following command:
    ```sh
    dotnet run
    ```
5.  The program will execute and display the output in the console.

---

## Programming Tasks

### 1. Inheritance and Method Overriding

This application demonstrates polymorphism through method overriding.
* A base class `Animal` is defined with a virtual method `MakeSound()` that outputs a generic sound message.
* Two derived classes, `Dog` and `Cat`, inherit from `Animal`.
* Each derived class overrides the `MakeSound()` method to print "Bark" and "Meow" respectively.
* The main program creates an instance of each of the three classes and calls the `MakeSound()` method on them to show how the overridden methods are executed.

### 2. Abstract Classes and Methods

This program shows the use of abstract classes to enforce a common contract for a group of related classes.
* An abstract class `Shape` is defined with an abstract method `GetArea()`.
* A `Circle` class is derived from `Shape` and implements the `GetArea()` method to calculate a circle's area.
* A `Rectangle` class is also derived from `Shape` and implements `GetArea()` to calculate a rectangle's area.
* The main program creates instances of `Circle` and `Rectangle` and prints their calculated areas.

### 3. Interfaces

This application demonstrates how to use interfaces to define a capability that can be implemented by unrelated classes.
* An interface `IMovable` is defined with a single method, `Move()`.
* A `Car` class implements the `IMovable` interface, providing a `Move()` method that prints "Car is moving".
* A `Bicycle` class also implements the `IMovable` interface, with its `Move()` method printing "Bicycle is moving".
* The main program creates instances of `Car` and `Bicycle` and calls the `Move()` method on each to demonstrate their functionality.