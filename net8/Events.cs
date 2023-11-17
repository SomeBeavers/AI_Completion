namespace net8;

public class SampleEventArgs
{
    public SampleEventArgs(string text) { Text = text; }
    public string Text { get; } // readonly
}

public class Publisher
{
    // Declare the delegate (if using non-generic pattern).
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);

    // Declare the event.
    public event SampleEventHandler SampleEvent;
    public event SampleEventHandler SampleEvent2;
    public int SampleCount;
    
    
    
    public void PublishSampleEvent()
    {
        RaiseSampleEvent();
    }
    public void SubscribeToSampleEvent(SampleEventHandler handler)
    {
        SampleEvent += handler;
    }
    public void UnsubscribeFromSampleEvent(SampleEventHandler handler)
    {
        SampleEvent -= handler;
    }
    
    protected virtual void RaiseSampleEvent()
    {
        SampleEvent?.Invoke(this, new SampleEventArgs("Hello"));
    }
}