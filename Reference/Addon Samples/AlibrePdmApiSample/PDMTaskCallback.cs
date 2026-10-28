using System;
using System.Runtime.InteropServices;
using AlibreX;

[ComVisible (true)]
[ClassInterface (ClassInterfaceType.None)]
public sealed class PdmTaskCallback : IADPDMTaskCallback
{
    private readonly Action _onCompleted;

    public PdmTaskCallback (Action onCompleted)
    {
        _onCompleted = onCompleted;
    }

    public void OnTaskCompleted ()
    {
        _onCompleted?.Invoke ();
    }
}
