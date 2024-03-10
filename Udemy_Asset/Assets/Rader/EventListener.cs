using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class  UnityGameObjectEvent : UnityEvent<GameObject>{}

public class EventListener : MonoBehaviour
{
    public Event Event; 
    public UnityGameObjectEvent responseWithGameObject = new UnityGameObjectEvent();

    private void OnEnable()
    {
        Event.Register(this);
    }

    private void OnDisable()
    {
        Event.Unregister(this);
    }

    public void OnEventOccured(GameObject gameObject)
    {
        responseWithGameObject?.Invoke(gameObject); 
    }
}
