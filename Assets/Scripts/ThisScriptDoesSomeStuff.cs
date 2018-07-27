using UnityEngine;

public class ThisScriptDoesSomeStuff : MonoBehaviour
{

    public int PublicInt = 4;
    public float PublicFloat = 2.0f;

    private float privateFloat = 1.0f;


    public void SetPrivateFloatAndAdd2(float value)
    {
        this.privateFloat = value + 2.0f;
    }


    public void PrintPrivateFloat()
    {
        Debug.Log(this.privateFloat);
    }


    public void PrintOtherStuff()
    {
        Debug.Log("Stuff: " + this.PublicFloat + this.PublicInt);
    }
}
