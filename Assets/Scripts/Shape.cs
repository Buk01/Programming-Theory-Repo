using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//INHERITANCE - Literally almost anything
public abstract class Shape : MonoBehaviour
{
    [SerializeField] protected float ySpawnPos = 5.0f;
    [SerializeField] protected float xSpawnRange = 22.0f;
    [SerializeField] protected float zSpawnRange = 22.0f;
    protected TextMeshProUGUI nameText;
    protected Vector3 GetRandomPosition()
    {
        float x = Random.Range(-xSpawnRange, xSpawnRange);
        float z = Random.Range(-zSpawnRange, zSpawnRange);
        return new Vector3(x, ySpawnPos, z);
    }
    // Start is called before the first frame update
    protected void Start()
    {
        nameText = GameObject.Find("Name Text").GetComponent<TextMeshProUGUI>();
        transform.position = GetRandomPosition();
    }

    //POLYMORPHISM - Every child has this method overridden
    protected abstract string GetName();

    protected virtual void OnMouseDown()
    {
        nameText.text = GetName();
    }
}
