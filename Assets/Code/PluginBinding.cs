using UnityEngine;
using System.Runtime.InteropServices;

public class PluginBinding : MonoBehaviour {

    [DllImport ("__Internal")]
    private static extern void _fooPluginFunction();

    [DllImport ("__Internal")]
    private static extern void _fooPluginFunctionWithCallback(string gameObjectName, string methodName);



    public static void FooPluginFunction()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            _fooPluginFunction();
        }
    }

    public static void FooPluginFunctionWithCallback(string gameObjectName, string methodName)
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            _fooPluginFunctionWithCallback(gameObjectName, methodName);
        }
    }
}
