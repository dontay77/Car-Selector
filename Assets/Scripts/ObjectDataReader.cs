using UnityEngine;

public class ObjectDataReader : MonoBehaviour
{
    public TextAsset listJSON;

    [System.Serializable]
    public class ObjectDataList
    {
        public ObjectData[] objectData;
    }

    public ObjectDataList objectDataList = new();


    // Reads the json file into a ObjectDataList object
    public ObjectDataList GetData()
    {
        objectDataList = JsonUtility.FromJson<ObjectDataList>(listJSON.text);
        return objectDataList;
    }
}
