using System;

class Client
{
    InterfaceEncapsulation2 interfaceEncapsulation2;

    public Client(InterfaceEncapsulation2 _interfaceEncapsulation2) {
        interfaceEncapsulation2 = _interfaceEncapsulation2;
    }

    public void doSomething() {
        Console.WriteLine("Client doSomething");
        interfaceEncapsulation2.doThis();
    }
}