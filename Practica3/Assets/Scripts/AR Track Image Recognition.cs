using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation

public class ARTrackImageRecognition : MonoBehaviour

{
    private ARTrackedImageManager _arTrackedImageManager; 

    public GameObject[] = prefab;  

    public Dictionary<string, GameObject> prefabs new = Dictionary<string, GameObject>;
   
    void Start()
    {
        _arTrackedImageManager = GetComponent<ARTrackedImageManager>();
        foreach (GameObject prefab in prefab)
        {
            GameObject InstantiatePrefab = Instantiate(prefab, vector3.zero, Quaternion.indentity);
            prefabDictionary.Add(prefab.name, prefab);
            prefabDictionary.add(prefab.name,prefab);
        }
    }

    
    private void private void OnEnable() 
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChance;
    }

    private void private void OnDisable() 
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChance;
    }

    public void OnImageChance(ARTrackedImagesChangedEventArgs eventsArgs)
    {
        //swap de los nodeles
        forch(ARTrackedImage trackedImage in eventArgs.added)
        {
            SetPrefab(trackedImage);
        }

         forch(ARTrackedImage trackedImage in eventArgs.update)
        {
            SetPrefab(trackedImage);
            
        }

         forch(ARTrackedImage trackedImage in eventArgs.removed)
        {
            prefabDictionary[tracked.name].SetActive(false);
            
        }
    }

    private void SetPrefab(ARTrackedImage trackedImage)
    {
        string name = trackedImage.referenceImage.name;
        vector3 position = trackedImage.transform.position;

        GameObject prefabToSpaw = prefab[name];
        Instantiate(prefabToSpaw, position, Quaternion.indentity);

        GameObject prefabToSpaw = prefabDictionary[name];
        prefab.transform.position = position;
        prefab.SetActive(true);
        //Instantiate prefabToSpaw, position, Quaternion.indentity;

    }
}
