#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.Store;
using FTOptix.DataLogger;
using FTOptix.SQLiteStore;
using FTOptix.Report;
using FTOptix.OPCUAServer;
using FTOptix.CommunicationDriver;
using FTOptix.Modbus;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
