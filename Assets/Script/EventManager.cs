using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public int counter;
    public int buttonwidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public UnityEngine.Events.UnityEvent DoorAppears;
    GUIStyle style;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        buttonHeight = 50;
        buttonwidth = 60;
        origin_x = 100;
        origin_y = 20;
        style = new GUIStyle();
    }
    private void OnGUI()
    {
        style.fontSize = 24;
        GUI.Label(new Rect(origin_x, origin_y, buttonwidth, buttonHeight), "Keys:" + counter.ToString(),style);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
