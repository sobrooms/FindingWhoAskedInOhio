using UnityEngine;
using System.IO;
using XLua;

public class Lua : MonoBehaviour
{
    DirectoryInfo di_start;
    DirectoryInfo di_update;
    DirectoryInfo di_fixedUpdate;
    DirectoryInfo diL;
    private string[] DirBuild = {
        "./FindingWhoAskedInOhio_Data/lua", "./FindingWhoAskedInOhio_Data/lua/start", "./FindingWhoAskedInOhio_Data/lua/update", "./FindingWhoAskedInOhio_Data/lua/fixed_update"
    };
    private string[] DirDebug = {
        "./fwdbg/lua/start", "./fwdbg/lua/update", "./fwdbg/lua/fixed_update", "./fwdbg/lua"
    };
    LuaEnv luaEnv = new();
    private void Update()
    {
        hu(di_update);
    }
    private void Start()
    {
        try
        {
            if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsPlayer && Debug.isDebugBuild)
            {
                if (!Directory.Exists(DirBuild[0]))
                    Directory.CreateDirectory(DirBuild[0]);
                if (!Directory.Exists(DirBuild[1]))
                    Directory.CreateDirectory(DirBuild[1]);
                if (!Directory.Exists(DirBuild[2]))
                    Directory.CreateDirectory(DirBuild[2]);
                if (!Directory.Exists(DirBuild[3]))
                    Directory.CreateDirectory(DirBuild[3]);

                di_start = new(DirBuild[1]);
                di_update = new(DirBuild[2]);
                di_fixedUpdate = new(DirBuild[3]);
                diL = new(DirBuild[0]);
            } else if (Application.platform == RuntimePlatform.WindowsEditor && Debug.isDebugBuild)
            {
                di_start = new(DirDebug[0]);
                di_update = new(DirDebug[1]);
                di_fixedUpdate = new(DirDebug[2]);
                diL = new(DirDebug[3]);
            }
        }
        catch (DirectoryNotFoundException err)
        {
            Debug.Log(err);
            if (Debug.isDebugBuild && Application.platform != RuntimePlatform.WindowsEditor)
                Debug.LogError(err);
        }
        hu(di_start);
    }
    private void FixedUpdate()
    {
        hu(di_fixedUpdate);
    }
    private void hu(DirectoryInfo dir)
    {
        var LuaFiles = dir.GetFiles("*.lua");
        if (LuaFiles.Length > 0)
        {
            foreach (var exec in LuaFiles)
            {
                bool LogThis = true;
                // execute each line, needs improvement by running lua code using luac like windy
                string[] lines = System.IO.File.ReadAllLines(@exec.ToString());
                if (lines.Length > 0)
                {
                    foreach (string ln in lines)
                    {
                        try
                        {
                            if (ln == "--@fwaio.SkipDebugLogs")
                                LogThis = false;
                            luaEnv.DoString(ln);
#if UNITY_EDITOR
                            if (LogThis)
                                Debug.Log("Executed lua string: " + ln + " in file " + exec.Name);
#endif
                            if (Debug.isDebugBuild && Application.platform != RuntimePlatform.WindowsEditor && LogThis)
                                Debug.LogError("Executed lua string: " + ln + " in file " + exec.Name);
                        }
                        catch (System.Exception err)
                        {
#if UNITY_EDITOR
                            if (LogThis)
                                Debug.Log("Failed to execute lua file " + exec.Name + ". Recieved: " + err?.ToString());
#endif
                            if (Debug.isDebugBuild && Application.platform != RuntimePlatform.WindowsEditor && LogThis)
                                Debug.LogError("Failed to execute lua file " + exec.Name + ". Recieved: " + err?.ToString());
                        }
                    }
                }
                else
                {
#if UNITY_EDITOR
                    Debug.Log("Attempted to execute lua file " + exec.Name + " but failed because it has no content");
#endif
                    if (Debug.isDebugBuild && Application.platform != RuntimePlatform.WindowsEditor)
                        Debug.LogError("Attempted to execute lua file " + exec.Name + " but failed because it has no content");
                }
            }
        }
    }
}