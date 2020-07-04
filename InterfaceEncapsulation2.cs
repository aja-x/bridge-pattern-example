class InterfaceEncapsulation2
{
    private InterfaceEncapsulation implementation;

    public virtual void doThis() {
        implementation = new InterfaceEncapsulation();
        implementation.doThisOne();
        implementation.doThisTwo();
    }
}