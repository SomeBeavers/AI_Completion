using System.Runtime.CompilerServices;

namespace net8;

[InlineArray(10)]
public struct StoreEvent
{
    public int @event;
}

public record Shop
{
    public Dictionary<string, int> storedEvents = [];
    private List<int> deletedEvents = [];

    private (string name, int number) specialEvents;

    public Shop(List<int> deletedEvents)
    {
        this.deletedEvents = deletedEvents;
    }

    public bool StoreEvents(StoreEvent events)
    {
        foreach (var @event in events)
        {
            storedEvents.Add(events.@event.ToString(), events.@event);
            return true;
        }
        
        return false;
    }

    public void RestoreDeletedEvents()
    {
        while (deletedEvents.Count > 0)
        {
            var eventToRestore = deletedEvents[0];
            deletedEvents.RemoveAt(0);
            storedEvents.Add(eventToRestore.ToString(), eventToRestore);
        }
    }
    
    public bool PopulateSpecialEvents()
    {
        specialEvents = ("Special Event", 5);
        return true;
    }
}