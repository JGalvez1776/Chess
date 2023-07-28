
using UnityEngine;
using UnityEngine.Assertions;

public class SpriteHandler : MonoBehaviour {

    public Sprite[] sprites;



    public Sprite getSprite(string name) {
        foreach (Sprite sprite in sprites) {
            if (sprite.name == name) {
                return sprite;
            }
        }
        Assert.IsTrue(false, "Sprite not found: " + name);
        return null;
    }



}