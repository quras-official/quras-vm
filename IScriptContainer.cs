namespace Pure.VM
{
    public interface IScriptContainer : IInteropInterface
    {
        byte[] GetMessage();
    }
}
