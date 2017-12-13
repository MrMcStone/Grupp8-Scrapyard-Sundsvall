using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvailableTowerButtons : MonoBehaviour {

    [SerializeField] GameObject bulletTowerButton;
    [SerializeField] GameObject magnetTowerButton;
    [SerializeField] GameObject lazerTowerButton;
    [SerializeField] GameObject missileTowerButton;

    void Start () {
		if(GetComponent<BuildingManagerScript>().bulletTowerAvailable == false)
        {
            Destroy(bulletTowerButton);
        }
        if (GetComponent<BuildingManagerScript>().magnetTowerAvailable == false)
        {
            Destroy(magnetTowerButton);
        }
        if (GetComponent<BuildingManagerScript>().lazerTowerAvailable == false)
        {
            Destroy(lazerTowerButton);
        }
        if (GetComponent<BuildingManagerScript>().missileTowerAvailable == false)
        {
            Destroy(missileTowerButton);
        }
    }
}
