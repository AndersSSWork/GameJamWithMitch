using UnityEngine;

public class ListCreator : MonoBehaviour
{
    [SerializeField] float ItemHeight;

    [SerializeField] Transform SpawnPoint = null;
    [SerializeField] GameObject item = null;
    [SerializeField] RectTransform content = null;

    public HintContent[] hints;

    // Use this for initialization
    void Start()
    {
        //setContent Holder Height;
        content.sizeDelta = new Vector2(0, hints.Length * ItemHeight);

        for (int i = 0; i < hints.Length; i++)
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
}