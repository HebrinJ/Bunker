using UnityEngine;

public class Singleton <T> : MonoBehaviour where T: MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if(instance == null)
                {
                    var singleton = new GameObject("GameController " + typeof(T));
                    instance = singleton.AddComponent<T>();
                    DontDestroyOnLoad(singleton);
                }
            }
            
            return instance;
        }
    }
}
