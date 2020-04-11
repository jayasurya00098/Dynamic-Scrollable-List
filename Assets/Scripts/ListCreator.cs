using UnityEngine;
using UnityEngine.UI;

public class ListCreator : MonoBehaviour
{
    public Transform SpawnPoint = null;
    [Space]
    public GameObject listItem = null;
    [Space]
    public RectTransform content = null;
    [Space]
    public ItemDetails[] itemDetails;
    [Space]
    public float itemHeight;

    // Use this for initialization
    void Start()
    {

        //setContent Holder Height;
        content.sizeDelta = new Vector2(0, itemDetails.Length * itemHeight);

        foreach(ItemDetails item in itemDetails)
        {
            //newSpawn Position
            Vector3 pos = new Vector3(SpawnPoint.position.x, -itemHeight, SpawnPoint.position.z);
            //instantiate item
            GameObject SpawnedItem = Instantiate(listItem, pos, SpawnPoint.rotation);
            //setParent
            SpawnedItem.transform.SetParent(SpawnPoint, false);
            //set name
            SpawnedItem.transform.GetChild(0).GetComponent<Text>().text = item.name;
            //set image
            SpawnedItem.transform.GetChild(1).GetComponent<Image>().sprite = item.sprite;
        }
    }
}