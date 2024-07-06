using System;
using System.Collections.Generic;

public class UIData : EventArgs
{
    public Dictionary<string, object> data;
    public string dataType;

    public UIData(string dataType, Dictionary<string, object> data)
    {
        this.dataType = dataType;
        this.data = data;
    }
}
