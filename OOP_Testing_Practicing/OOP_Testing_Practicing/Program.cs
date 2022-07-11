using System;

namespace OOP_Testing_Practicing
{
    class Program
    {

        public static double Average(int a, int b)
        {
            return (a + b) / 2.0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Average(2, 1));

            Employee e1 = new Employee(); // instantiating an object Employee            
            Manager m = new Manager(); // instantiating an object Manager (child class of Employee)

            Employee e = new Manager(); // example of Polymorphism. object "e" can be from class Manager and Doctor because botth are child of Employee.
            e = new Doctor();
            
            e1.name = "Tiago";
            e1.address = "360 Hoffman st";
            m.Validate(); //Manager is a child class of Employee and inherites the method Validate

            string[] cars = { "Corvete", "Lambo", "Ferrari" };
            Console.WriteLine("First car of the array : " + cars[0]);
            //
        }
    }

    //https://www.youtube.com/watch?v=u99wAoBjDvQ
    ///////////////////////////////////////////////////////////////////////////////////

    // 1. Why object oriented Programming? Helps us to think in terms of real world objects 

    ///////////////////////////////////////////////////////////////////////////////////

    /* 2. What are important pillars in OOP?
     - Abstraction = Show only necessary
     - Encapsulation = Bind data and function together. Hide complexity. Example of engine motor. 
     - Inheritance = Same function can be used in diferent classes. arent child relationship 
     - Polymorphism = Function can have different parameters. Objects acts differently under different conditions.     
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 3. What is a class and object ?
     - Class is a blueprint. A classification
     - Object is an instance of a class     
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /*4 Abstraction vs Encapsulation
     - Abstraction = Show only necessary. Happens during design phase. Decide what is going to be public.
     - Encapsulation = Hide complexity. Happens during coding/ implementation phase. Change access modyfiers in order to give access or not to an object.
     Encapsulation implements abstraction.
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 5. Explain Inheritance
      - One of properties of OOP where we can define a parent / child relationship.
      It is also knon as "Is a relationship" Manager is a child of Employee.
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 6. Explain virtual Keyword
      - Virtual keyword helps us to define some logic in the parent class wich can be overridden in the child class.
    insert "virtual" word on the mother class function and will allow overriding on the child class. 
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 7. Explain Overriding
      - One implemetation in the parent class will be overriden on the child class
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 8. Explain Overloading
     Same methods name with different signature, different parameters in the same class.
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 9. Overloading vs Overriding - they are not related
    Overloading - Method with same name but different signatures (different parameters)
    
    Overriding - Using virtual keyword and overring (change code insde function) in a child class. 
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 10. explain Polymorphism
    Poly = many , morphism = different forms.
    It's the ability of an object to act differently under different condition
   */

    ///////////////////////////////////////////////////////////////////////////////////


    /* 11. explain Polymorphism
    Poly = many , morphism = different forms.
    It's the ability of an object to act differently under different condition
    To implement Polymorphism, Inheritance is a must.
   */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 12. Static (compiled time polimorhism) vs Dynamic Polymorphism (runtime polymorphism)
      static = implemented by overloading - same function, differnt parameters. Checked during compiled time. When click build.
      dynamic = implemented by overriding - happens in a parent/child relationship. Checkd when we are able to select a funcion from a mother class. runtime polymorphism
   */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 13. Explain operator overloading
      Helps to redefine additional functionalities for plus, minus, multi and addition. It is a built in feature of .NET. 
      Example: we can sum strings and numbers.    
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 14. How to custom overloading
        user operator keyword to create a custom operator. Example: sum objects from 2 classes. 
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 15. 
        
     */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 16. Why do we need Abstract class ?
    To create a class that is half defined. Where theer are some implementations defined and some implemetations are left to be defined by the child class.
    Example in Customer class.
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 17. Are Abstract methods virtual ?
        Yes. They are virtual
    */

    ///////////////////////////////////////////////////////////////////////////////////

    /* 18. Cna we create an instance of an abstract class ?
        No
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 19. Is it compulsory to implement abstract methods ?
        yes. The child class needs to implement the code 
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 20. Why simple base(parent) class replace an abstract class ?
        Simple base class can not be defined in a pure half way.
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 21. Explain interfaces and why do we need it?
        Interface is a contract. Legal biding between developer who is creating the class and the consumer who is using the class.
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 22. Can we have logic in interface ?
       No. We can only have signature. 
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 23. Can we methods as private in interface ?
       No.must be all public
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 24. If I want to change the interface, qhat s the best practice  ?
       Perform multiple inheritance
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 25. Explain Multiple inheritance in Interface  ?
     * Helps to add new methods without affecting the old interfaces.
       Create a new interfcae. Never change the same interface
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 26. Explain Inheritance Segreggation Principle  ?
       ISP =   Inheritance Segreggation Principle
       Create different interfaces and we do not force cliuente uses all of them. They only use what is interesting for them.
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 27. Can we create instance of interface  ?
       No. Neither cant create instance of abstract class.
    */

    //////////////////////////////////////////////////////////////////////////////////

    /* 28. Can we do multiple inheritance with Abstract classes  ?
      No. We can only do multiple inheritance with interfaces.
   */
    //////////////////////////////////////////////////////////////////////////////////

    /* 28. What is the difference betweeen abstract class and interface  ?
      No. We can only do multiple inheritance with interfaces.
   */
    //////////////////////////////////////////////////////////////////////////////////



} //




