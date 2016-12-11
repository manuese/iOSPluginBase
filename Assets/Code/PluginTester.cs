using UnityEngine;

public class PluginTester : MonoBehaviour
{
	// Use this for initialization
	void Start () {
	    PluginBinding.FooPluginFunctionWithCallback(name, "NativeListener");
	}

    public void SendToNative()
    {
        PluginBinding.FooPluginFunctionWithCallback(name, "NativeListener");
    }

    private void NativeListener(string message)
    {
        Debug.Log("Listened method from Unity side.");
        Debug.Log("Recieved message: " + message);
    }
}
