using System.Collections.Generic;
using UnityEngine;

public class ListCreator : MonoBehaviour
{
    [SerializeField] float ItemHeight;

    [SerializeField] Transform SpawnPoint = null;
    [SerializeField] GameObject item = null;
    [SerializeField] RectTransform content = null;

    public List<HintContent> hints;

    // Use this for initialization
    void Start()
    {
        if(DialogState.hints == null)
        {
            DialogState.hints = new List<HintContent>();
            foreach (HintContent hint in hints)
            {
                DialogState.hints.Add(hint);
            }
        }
        


        //setContent Holder Height;
        content.sizeDelta = new Vector2(0, hints.Count * ItemHeight);

        for (int i = 0; i < hints.Count; i++)
        {
            SpawnOne(i);
        }
    }

    private void Update()
    {
        //setContent Holder Height;
        content.sizeDelta = new Vector2(0, hints.Count * ItemHeight);

        while (DialogState.hints.Count > hints.Count)
        {
            hints.Add(DialogState.hints[hints.Count]);
            SpawnOne(hints.Count - 1);
        }
    }

    public void SpawnOne(int i)
    {
        // 60 width of item
        float spawnY = i * ItemHeight;
        //newSpawn Position
        Vector3 pos = new Vector3(0, -spawnY, 0);
        //instantiate item
        GameObject SpawnedItem = Instantiate(item, pos, SpawnPoint.rotation);
        //setParent
        SpawnedItem.transform.SetParent(SpawnPoint, false);
        //get ItemDetails Component
        HintDisplay hintDisplay = SpawnedItem.GetComponent<HintDisplay>();

        hintDisplay.hint = hints[i];
    }
}