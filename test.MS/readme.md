

## Navigation Commands:

- driver.Navigate().GoToUrl(url): Navigate to the specified URL.
- driver.Navigate().Back(): Navigate back in the browser history.
- driver.Navigate().Forward(): Navigate forward in the browser history.
- driver.Navigate().Refresh(): Refresh the current page.
Element Location Commands:

- driver.FindElement(By selector): Find a single web element using the specified selector.
- driver.FindElements(By selector): Find multiple web elements matching the specified selector.
- WebElement.FindElement(By selector): Find a child element of the current element using the specified selector.
- WebElement.FindElements(By selector): Find multiple child elements of the current element matching the specified selector.


## Element Interaction Commands:

webElement.Click(): Click on the web element.
webElement.SendKeys(text): Send keys (text input) to the web element.
webElement.Clear(): Clear the text entered in a text input field.
webElement.GetText(): Get the text content of the web element.
webElement.GetAttribute(attributeName): Get the value of the specified attribute of the web element.
Browser Window and Frame Commands:

driver.SwitchTo().Window(windowHandle): Switch to a different browser window by its handle.
driver.SwitchTo().Frame(frameLocator): Switch to a frame within the page by its locator.
driver.SwitchTo().DefaultContent(): Switch back to the default content (main frame) from a nested frame.
Browser Control Commands:

driver.Manage().Window.Maximize(): Maximize the browser window.
driver.Manage().Timeouts().ImplicitWait: Set the implicit wait time for locating elements.
driver.Quit()





Sure, here are some object-oriented programming (OOP) interview questions that are commonly asked in C# interviews:

What is encapsulation? How is it achieved in C#?

Encapsulation is the bundling of data and methods that operate on that data into a single unit (class). It hides the internal state of an object from outside interference. In C#, encapsulation is achieved using access modifiers such as public, private, protected, and internal.
What is inheritance? How is it implemented in C#?

Inheritance is the mechanism by which a class can inherit properties and behavior from another class. The class that inherits is called a derived class or subclass, and the class it inherits from is called a base class or superclass. In C#, inheritance is implemented using the : (colon) symbol followed by the name of the base class.
What is polymorphism? How is it achieved in C#?

Polymorphism is the ability of an object to take on multiple forms. In C#, polymorphism is achieved through method overriding and method overloading. Method overriding allows a subclass to provide a specific implementation of a method that is already defined in its superclass. Method overloading allows a class to have multiple methods with the same name but different parameters.
What is the difference between abstract classes and interfaces in C#?

Abstract classes can have both abstract and non-abstract (concrete) methods, while interfaces can only have method declarations without implementations. A class can implement multiple interfaces but can only inherit from one abstract class. Abstract classes can have constructors, fields, and properties, while interfaces cannot.
What is the sealed keyword used for in C#?

The sealed keyword is used to prevent inheritance. When applied to a class, it prevents other classes from inheriting from it. Similarly, when applied to a method, it prevents overriding of that method in derived classes.
What is the difference between value types and reference types in C#?

Value types store their data directly in memory, whereas reference types store a reference (memory address) to their data. Value types are stored on the stack, while reference types are stored on the heap. Value types include primitive types like int, float, and char, as well as structs, while reference types include classes, arrays, interfaces, and delegates.
What is the purpose of the using directive in C#?

The using directive is used to import namespaces in C#. It allows you to use types from a namespace without having to fully qualify their names. It also helps prevent naming conflicts between types from different namespaces.



```
IWebElement Here's an overview of some commonly used methods and properties of the IWebElement interface:

Click(): This method simulates a click on the element.

SendKeys(string text): This method sends a sequence of keystrokes to the element. It is commonly used to input text into text fields.

Clear(): This method clears the text if it's an input element.

GetAttribute(string attributeName): This method gets the value of the specified attribute of the element.

Text Property: This property gets the visible inner text of the element.

Displayed Property: This property returns a boolean value indicating whether the element is displayed or not.

Enabled Property: This property returns a boolean value indicating whether the element is enabled or not.

Selected Property: This property returns a boolean value indicating whether the element is selected or not (for checkboxes, radio buttons, etc.).

Location Property: This property gets the location of the element on the page.

Size Property: This property gets the size of the element.

IWebElement is returned by various methods in the IWebDriver interface (like FindElement and FindElements) when locating elements on a web page. Once you have an IWebElement instance, you can perform various operations on the corresponding element.
```



```
Primitive Types:

Numeric Types:
byte: 8-bit unsigned integer.
sbyte: 8-bit signed integer.
short: 16-bit signed integer.
ushort: 16-bit unsigned integer.
int: 32-bit signed integer.
uint: 32-bit unsigned integer.
long: 64-bit signed integer.
ulong: 64-bit unsigned integer.
float: 32-bit floating point number.
double: 64-bit floating point number.
decimal: 128-bit decimal number.
Boolean Type:
bool: Represents a boolean value (true or false).
Character Types:
char: Represents a single Unicode character.
String Type:
string: Represents a sequence of characters.
Composite Types:

Arrays: Ordered collection of elements of the same type.
Structures (struct): User-defined composite data type that can contain data members of different types.
Enumerations (enum): User-defined type consisting of a set of named constants.
Reference Types:

Class (class): User-defined reference type that can contain data members and methods.
Interface (interface): Defines a contract for classes to implement.
Nullable Types:

Any of the built-in value types can be made nullable by appending ? to the type name. For example, int? represents a nullable integer.
Pointer Types (Unsafe Context):

pointer: Represents a pointer to a memory address. Use in unsafe contexts.
Special Types:

object: The ultimate base class for all other types. Can store any value.
dynamic: Allows late binding of member and method calls, bypassing compile-time type checking.
Example usage:

int age = 30;
double height = 6.2;
char grade = 'A';
string name = "John";
bool isStudent = true;
int[] numbers = {1, 2, 3, 4, 5};
Person person = new Person(); // Assuming Person is a class defined elsewhere
```