using UnityEngine;

public class mynewscript : MonoBehaviour
{

    public string playername;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("뱅드림 마이고 명작입니다." + playername);
        if (3>0)
        {
            Debug.LogWarning("뱅드림 최고");
            Debug.Log("뱅드림 최고");
            Debug.LogError("뱅드림 최고");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
