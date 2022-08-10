using UnityEngine;
using com.palash.utils;

namespace com.palash.game
{
    public class MainClass_Pool : MonoBehaviour
    {
        //------Serialize Fields----------
        [SerializeField] private Character_Pool m_char;
        
        //------Private Fields------------
        private Vector3 _posVector;
        private ObjectPool<Character_Pool> m_charPool = new ObjectPool<Character_Pool>();
        private Character_Pool m_generatedChar;
        
        private void Start()
        {
            _posVector = Vector3.zero;
            m_charPool.Initialize(m_char, 10);
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

                 m_generatedChar = m_charPool.Get();
                 m_generatedChar.transform.position = _posVector;
                 m_generatedChar.transform.rotation = Quaternion.identity;

                 m_generatedChar.Initialize(this);
            }
        }

        public void Return(Character_Pool _charPool)
        {
            m_charPool.Return(_charPool);
        }
    }
}
