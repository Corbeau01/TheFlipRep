using UnityEngine;

#pragma warning disable 649

public class Item : MonoBehaviour
{
    #region Private serialized fields

    [SerializeField]
    private Transform _parentTransform;

    #endregion

    #region Private methods

    private void Reparent()
    {
        if (_parentTransform == null) return;

        transform.parent = _parentTransform;
    }

    #endregion

    #region Public methods

    public void Show(bool show)
    {
        gameObject.SetActive(show);

        if (Application.isPlaying)
            Reparent();
    }

    #endregion
}
