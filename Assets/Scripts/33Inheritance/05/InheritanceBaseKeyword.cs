using UnityEngine;

namespace InheritanceBaseTest
{
    public class InheritanceBaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            (new My()).Run();
            (new My("붐붐")).Run();
            (new Your()).Run();
        }
    }
}