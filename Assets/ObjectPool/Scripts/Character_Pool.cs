using UnityEngine;

namespace com.palash.game
{
    public class Character_Pool : MonoBehaviour
    {
        //------Private Fields------------
        private MainClass_Pool m_mainClassPool;

        public void Initialize(MainClass_Pool _mainClass)
        {
            m_mainClassPool = _mainClass;
            gameObject.SetActive(true);
        }

        private void OnCollisionEnter(Collision other)
        {
            gameObject.SetActive(false);
            m_mainClassPool.Return(this);
        }
    }
}
