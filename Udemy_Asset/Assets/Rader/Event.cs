using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event",order =52)]
public class Event : ScriptableObject
{
    private List<EventListener> listeners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        listeners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        listeners.Remove(listener);
    }

    public void Occured(GameObject gameObject)
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventOccured(gameObject);
        }
    }
}
