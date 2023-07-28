using System.Collections.Generic;
using Assets.Scripts.UI.Utils;
using UnityEngine;

namespace Assets.Scripts.UI.Board.Theme {

public class Theme : MonoBehaviour, IPublisher{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    // Define white and black colors
    public static Color WHITE = new Color(1, 1, 1);
    public static Color BLACK = new Color(0, 0, 0);


    public Color lightSquareColor = new Color(1, 1, 1);
    public Color darkSquareColor  = new Color(0, 0, 0);


    private void OnValidate() {
        publish(new ChessEvent(ChessEventType.ColorChanged));
    }

    public void publish(ChessEvent e) {
        foreach (ISubscriber subscriber in subscribers)
        {
            subscriber.onEvent(e);
        }
    }

    public void subscribe(ISubscriber subscriber) {
        subscribers.Add(subscriber);
    }

    public void unsubscribe(ISubscriber subscriber) {
        subscribers.Remove(subscriber);
    }

}



}
