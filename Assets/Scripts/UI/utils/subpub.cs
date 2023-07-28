
namespace Assets.Scripts.UI.Utils {
public interface ISubscriber
{
    void onEvent(ChessEvent e);
}

public interface IPublisher
{
    public void subscribe(ISubscriber subscriber);
    public void unsubscribe(ISubscriber subscriber);
    void publish(ChessEvent e);
}

public class ChessEvent
{
    public ChessEventType id;

    public ChessEvent(ChessEventType id) {
        this.id = id;
    }


}
public enum ChessEventType {
    ColorChanged
}

}