using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

/// <summary>
/// 
/// </summary>
public class MainBuilding : Building {
    private Vector3 mainBuildingSize;
    private float spawnDistance = 0.3f;


    private Button LightUnitButton;
    private Button MediumUnitButton;
    private Button HeavyUnitButton;
    private Button RangedUnitButton;

    private float lightUnitBuildTime = 3.0f;
    private float mediumUnitBuildTime = 5.0f;
    private float heavyUnitBuildTime = 10.0f;
    private float rangedUnitBuildTime = 5.0f;

    // Start is called before the first frame update
    void Start() {
        mainBuildingSize = gameObject.GetComponent<Collider>().bounds.size;

        LightUnitButton = GameObject.Find("Light Unit Button").GetComponent<Button>();
        LightUnitButton.onClick.AddListener(() => {
            StartCoroutine(buildLightUnit());
        });

        MediumUnitButton = GameObject.Find("Medium Unit Button").GetComponent<Button>();
        MediumUnitButton.onClick.AddListener(() => {
            StartCoroutine(buildMediumUnit());
        });

        HeavyUnitButton = GameObject.Find("Heavy Unit Button").GetComponent<Button>();
        HeavyUnitButton.onClick.AddListener(() => {
            StartCoroutine(buildHeavyUnit());
        });

        RangedUnitButton = GameObject.Find("Ranged Unit Button").GetComponent<Button>();
        RangedUnitButton.onClick.AddListener(() => {
            StartCoroutine(buildRangedUnit());
        });
    }

    // Update is called once per frame
    void Update() {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    private void buildUnit(int type) {
        switch (type) {
            case 0: buildLightUnit(); break;
            case 1: buildMediumUnit(); break;
            case 2: buildHeavyUnit(); break;
            case 3: buildRangedUnit(); break;
            default: Debug.LogError("Illegal value handed to 'buildUnit'"); break;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private IEnumerator buildLightUnit() {
        yield return new WaitForSeconds(lightUnitBuildTime);
        GameObject unit = Resources.Load<GameObject>("Prefabs/Units/Light Unit");
        // From what I understand, this should also allow me to load a prefab:
        // Instantiate(Addressables.LoadAssetAsync<GameObject>("Prefabs/Units/Light Unit").Result, new Vector3(0, 0, 0), Quaternion.identity);
        if (unit != null) {
            Instantiate(unit, new Vector3(spawnDistance + mainBuildingSize.x / 2, unit.GetComponent<Collider>().bounds.size.y / 2, 0), Quaternion.identity);
        } else {
            Debug.LogError("Light unit not found in Resources folder");
        }
        
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private IEnumerator buildMediumUnit() {
        yield return new WaitForSeconds(mediumUnitBuildTime);
        GameObject unit = Resources.Load<GameObject>("Prefabs/Units/Medium Unit");
        Instantiate(unit, new Vector3(0, 0, 0), Quaternion.identity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private IEnumerator buildHeavyUnit() {
        yield return new WaitForSeconds(heavyUnitBuildTime);
        GameObject unit = Resources.Load<GameObject>("Prefabs/Units/Heavy Unit");
        Instantiate(unit, new Vector3(0, 0, 0), Quaternion.identity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private IEnumerator buildRangedUnit() {
        yield return new WaitForSeconds(rangedUnitBuildTime);
        GameObject unit = Resources.Load<GameObject>("Prefabs/Units/Ranged Unit");
        Instantiate(unit, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
