using System.Collections.Generic;
using System.Windows.Forms;

class ConnectorLog : Form
{
    private static Queue<string> Log = new Queue<string>();
    private static ConnectorLog Instance;

    public static ConnectorLog GetInstance()
    {
        if (Instance == null)
        {
            Instance = new ConnectorLog();
        }

        return Instance;
    }

    public void AddItem(string str)
    {
        Log.Enqueue(str);
    }

    public string PopItem()
    {
        if (Log.Count > 0)
            return Log.Dequeue();
        else
            return null;
    }
}
