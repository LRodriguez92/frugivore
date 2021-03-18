using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectibleType
{
    Fruit,
    RottenFruit,
    PowerUp,
    Health
}

public class Collectible : MonoBehaviour
{
    public CollectibleType collectibleType;
}