using UnityEngine;

namespace ThePrototype.Scripts.Interactor
{
    public abstract class BaseInteractor : MonoBehaviour
    {
        public virtual void DestroyFood(GameObject obj)
        {
            Destroy(obj);
        }
    }
}
