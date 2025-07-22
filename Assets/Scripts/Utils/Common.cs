using UnityEngine;
using System.ComponentModel;    

public static class Common {
    public static string GetVersion()
    {
        return Application.version;
    }

    public static string GetBuildDate()
    {
        return System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public static string GetDeviceModel()
    {
        return SystemInfo.deviceModel;
    }

    public static string GetDeviceName()
    {
        return SystemInfo.deviceName;
    }
}