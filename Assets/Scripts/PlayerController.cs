using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera m_camera;
    // TODO PlayerController should handle clicks on units and buildings?
    private Building m_selectedBuilding = null;

    // Start is called before the first frame update
    void Start() {
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update() {
        Ray ray = m_camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.yellow);

        if (Input.GetMouseButtonDown(0)) {
            HandleSelection();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void HandleSelection() {
        var ray = m_camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            var building = hit.collider.GetComponentInParent<Building>();

            m_selectedBuilding = building;
            Debug.Log("Building hit");
            // When we have selected a building, we can check if there is a IUIInfoContent in the parent element
            // var uiInfo = hit.collider.GetComponentInParent<UIMainScene.IUIInfoContent>();
            // UIMainScene.Instance.SetNewInfoContent(uiInfo);
        }
    }
}
