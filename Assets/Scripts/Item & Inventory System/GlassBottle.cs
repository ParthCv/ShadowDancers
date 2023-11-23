using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBottle : MonoBehaviour, IThrowableItem
{
    public Vector2 _InventoryShape;

    [SerializeField]
    public AudioSource _CollisionSound;

    [SerializeField]
    public float _DamageValue;

    [SerializeField]
    public AudioSource _BreakSound;

    [SerializeField]
    public Color _InventoryColor = new Color(0.0f, 0.0f, 1.0f, 1.0f);

    public float damageValue
    {
        get
        {
            return _DamageValue;
        }
        set
        {
            _DamageValue = value;
        }
    }

    public AudioSource breakSound
    {
        get
        {
            return _BreakSound;
        }
        set
        {
            _BreakSound = value;
        }
    }

    public Vector2 inventoryShape
    {
        get
        {
            return _InventoryShape;
        }
        set
        {
            _InventoryShape = value;
        }
    }

    public AudioSource collisionSound
    {
        get
        {
            return _CollisionSound;
        }
        set
        {
            _CollisionSound = value;
        }
    }

    public Color inventoryColor
    {
        get
        {
            return _InventoryColor;
        }
        set
        {
            _InventoryColor = value;
        }
    }


    public void interact()
    {
        Debug.Log("Looks like an empty bottle.");
    }

    public bool throwItem()
    {
        // TODO: Throwing Implementation.
        Debug.Log("Throw Glass Bottle");
        return true;
    }

    // Start is called before the first frame update
    public void Start()
    {
        // OnStart, add "this" GameObject to the GameManager for BookKeeping
    }

    // Update is called once per frame
    public void Update()
    {

    }
}
