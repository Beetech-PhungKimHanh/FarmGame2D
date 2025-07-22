using System.ComponentModel;
using UnityEngine;

public static class EnvConfig 
{
    private static EnvType currentEnv = EnvType.Dev;
    private static readonly string devUrl = "https://dev.example.com";
    private static readonly string stgUrl = "https://stg.example.com";
    private static readonly string prodUrl = "https://prod.example.com";

    public static void SetEnv(EnvType env)
    {
        currentEnv = env;
    }
    public static EnvType GetCurrentEnv()
    {
        return currentEnv;
    }
    public static string GetCurrentUrl()
    {
        switch (currentEnv)
        {
            case EnvType.Dev:
                return devUrl;
            case EnvType.Stg:
                return stgUrl;
            case EnvType.Prod:
                return prodUrl;
            default:
                return devUrl;
        }
    }
    public static string GetPlatform()
    {
        #if UNITY_EDITOR
            return "Editor";
        #elif UNITY_ANDROID
            return "Android";
        #elif UNITY_IOS
            return "iOS";
        #elif UNITY_STANDALONE_WIN
            return "Windows";
        #elif UNITY_STANDALONE_OSX
            return "macOS";
        #else
            return "Unknown";
        #endif
    }

}

public enum EnvType
{
    [Description("Dev")]
    Dev,
    [Description("Stg")]
    Stg,
    [Description("Prod")]
    Prod
}
