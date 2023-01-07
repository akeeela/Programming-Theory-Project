using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    //ENCAPSULATION
    private int m_speed;
    public int speed
    {
        get {return m_speed;}
        set {m_speed = value;}
    }

    //ABSTRACTION
    protected abstract void Move();
}
