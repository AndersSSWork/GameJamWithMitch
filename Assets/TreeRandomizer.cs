using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRandomizer : MonoBehaviour
{
    [SerializeField] GameObject Tree;

    [SerializeField] float spreadRadius;
    [SerializeField] float treeCoverageRadius;

    [SerializeField] int minTrees;
    [SerializeField] int maxTrees;

    private List<GameObject> trees;

    // Start is called before the first frame update
    void Start()
    {
        trees = new List<GameObject>();

        int treeCount = Random.Range(minTrees, maxTrees + 1);

        for (int i = 0; i < treeCount; i++)
        {
            Vector3 newPosition = Vector3.zero;
            // stop after 100 tries
            for (int j = 0; j < 100; j++)
            {
                bool isLegal = true;
                newPosition = new Vector3(transform.position.x + Random.Range(-spreadRadius, spreadRadius), transform.position.y, transform.position.z + Random.Range(-spreadRadius, spreadRadius));
                foreach (GameObject gameObject in trees)
                {
                    if (Vector3.Distance(newPosition, gameObject.transform.position) <= treeCoverageRadius)
                    {
                        isLegal = false;
                    }
                }
                if (isLegal)
                    break;
            }

            if (newPosition.Equals(Vector3.zero))
                break;

            GameObject newTree = Instantiate(Tree, newPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), transform);

            trees.Add(newTree);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
