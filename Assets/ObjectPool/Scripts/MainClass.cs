using UnityEngine;
using Random = UnityEngine.Random;

namespace com.palash.game
{
    public class MainClass : MonoBehaviour
    {
        //------Serialize Fields----------
        [SerializeField] private Character m_char;
        
        //------Private Fields------------
        private Vector3 _posVector;

        private void Start()
        {
            _posVector = Vector3.zero;
        }

        void Update()
        {
            Generate();
        }

        void Generate()
        {
            for (int i = 0; i < 10; i++)
            {
                _posVector.x = Random.Range(-6, 6);
                _posVector.y = Random.Range(0, 6);
                _posVector.z = Random.Range(-6, 6);
                
                Instantiate(m_char, _posVector, Quaternion.identity);
            }
        }
    }
}
