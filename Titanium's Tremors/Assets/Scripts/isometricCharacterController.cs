using UnityEngine;

public class isometricCharacterController : MonoBehaviour
{
    private Vector3 targetPosition;
    private float speed = 2f; // Ajustez la vitesse selon vos besoins

    void Update()
    {
        // Détecter les clics de souris
        if (Input.GetMouseButtonDown(0))
        {
            // Obtenir la position 3D du clic
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Convertir la position 3D en position isométrique
                targetPosition = ConvertToIsometric(hit.point);
            }
        }

        // Déplacer le joueur progressivement vers la position cliquée
        MoveToPosition();
    }

    Vector3 ConvertToIsometric(Vector3 position3D)
    {
        // Supposons que votre caméra isométrique est inclinée à 45 degrés
        float theta = 45f * Mathf.Deg2Rad;

        // Matrice de rotation isométrique
        Matrix4x4 rotationMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, theta, 0));

        // Appliquer la rotation à la position 3D
        Vector3 rotatedPosition = rotationMatrix.MultiplyPoint(position3D);

        // Ignorer la composante y si elle n'est pas nécessaire
        rotatedPosition.y = 0;

        return rotatedPosition;
    }

    void MoveToPosition()
    {
        // Vérifier si le joueur a atteint la position cliquée
        if (Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            // Déplacer le joueur vers la position cliquée
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}



