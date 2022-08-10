using System.Collections.Generic;
using UnityEngine;

namespace com.palash.utils{
    public class ObjectPool<T> where T : UnityEngine.Object
    {
        //------Private Fields------------
        private T m_prefab;
        private Queue<T> m_myStorage = new Queue<T>();

        public void Initialize(T _prefab, int _initializeCount)
        {
            m_prefab = _prefab;

            for (int i = 0; i < _initializeCount; i++)
            {
                T _obj = MonoBehaviour.Instantiate(m_prefab);
                m_myStorage.Enqueue(_obj);
            }
        }

        public T Get()
        {
            if (m_myStorage.Count > 0)
                return m_myStorage.Dequeue();
            
            return MonoBehaviour.Instantiate(m_prefab);
        }

        public void Return(T _obj)
        {
            m_myStorage.Enqueue(_obj);
        }

    }
}
