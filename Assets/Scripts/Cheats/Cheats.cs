using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    
    [SerializeField] private bool _pressFToTakeDamageBool;


    private TankHealth health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<TankHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        PressFToTakeDamage();
    }

    void PressFToTakeDamage()
    {
        if (Input.GetKeyDown(KeyCode.F)&&_pressFToTakeDamageBool)
            health.TakeDamage(10f);
    }
}
