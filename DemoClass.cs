namespace ReSharperCleanupCodeDemo;

internal class DemoClass : IDemoInterface
{
    private readonly int _privateProperty;

    public string InterfaceProperty { get; set; }

    public int PublicProperty { get; set; }

    public DemoClass(int privateProperty) =>
        _privateProperty = privateProperty;

    public void InterfaceMethod() =>
        Console.WriteLine(nameof(InterfaceMethod));

    private int PrivateMethod() =>
        _privateProperty;

    public int PublicMethod() =>
        _privateProperty;

    public void UnusedMethod()
    {
        Int32 BAD_VARIABLE_NAME = new Int32(1);
    }
}