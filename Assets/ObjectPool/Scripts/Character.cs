using UnityEngine;

namespace com.palash.game{
    public class Character : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            Destroy(this.gameObject);
        }
    }
}
