using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    internal class Notes
    {



        
    }
}



/*
Questions to Answer

<Interface>

What is an interface?
Answer:
Interfaces are like a contract in programming.
They are inherited, like classes, but don't have any behavior.
By implementing an Interface ( implements means to connect, add, or install ),
you are saying, "This code will be able to do X," without implementing the code yet.
  
Why do you use interfaces?
Answer:
So that you can give a child class an inheritting parent class and/or any number of Interfaces
that the user can do click events and stuff with. (ex. IOpen.cs so that later we can have different child objects like chests and doors that we can assign this Interface IOpen.cs that give an action.

How do we create interfaces?
Answer:
Right click on your project name (On the right, in the Solution Explorer)
Hover over add
Select New Item
Click Interface from the menu
Give it a name, Start your name with a capital "I" because that's A c# naming standard. (ex. IOpen)

Interfaces can have Fields and Methods
What must an interface field have to work?
Answer:
// Constant fields ( or properties ) that can't be changed once the code gets running. example:
internal interface IOpen
{
    const double _minRotation; //keyword "const"
    // Method names
    public void Open(); key part of the contract, everything that inherits from this is going to have access.
}

What must an interface method NOT have?
Answer:
Constructor because this is not meant to be an instanced object, it is meant work with inherited data

How do you call a Interface field?
Answer:
You can associate your project with an Interface you created by opening a child class .cs (example: Door.cs is a child to Bottle.CS) and next to the
parent it is inheriting, add a comma followed by the name of the Interface you want to use.
ex.
internal class Door : Bottle, IOpen // Child class can have 1 Inheritting Parent class and any # of Interfaces

<IEnumerable and IEnumerator>

What loop does IEnumerable work with?
Answer: foreach loop.
IEnumerable is the thing that tells our foreach how to loop.
IEnumerator is the underlining code that tells us how to work through a list


 */