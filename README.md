# Assignment8

In this assignment we were tasked with looking up a programming design pattern from the Gang of Four, and implementing it in a simple console applicatin. The goal of this assignment is to find one we find interesting and illustrate it. The assignment must also include XUnit testing for the application, and can not be one of the following design patterns that were covered in class:

1) Factory
2) Strategy
3) Singleton
4) Builder
5) Decorator
6) Tempate
7) Facade
8) Adapter

For my assignment I utilized the command pattern which is used to encapsulate a request/command as an object, which allows you to paramterize clients with various requests/commands. As well as being able to handle queue/log requests, and allows you to do other typically undoable operations. 

In the case of my console application, the IOrder Interface, along with the BuyStock and SellStock classes, are utilizing the COMMAND PATTERN in order to carry out the operations of from the client Stock and Broker classes. Allowing us to queue/log those commands and allows us to parameterize the methods using the IOrder interface in the Broker class.

#Requirements

1) Unit tests
2) 100% code coverage
3) All tests pass
4) Follows coding standards in syllabus
5) README.md file with a summary of the patter and how it is used
6) Submitted via GitHub
