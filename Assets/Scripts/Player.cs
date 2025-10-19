using UnityEngine.AI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool AlterMov =true;
    private NavMeshAgent agent;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cancela la velocidad actual
            agent.ResetPath();
            agent.velocity = Vector3.zero;
        }

        if (Input.GetMouseButton(0))
        {
            MoveToMousePosition();
        }

    }
    private void MoveToMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100f, groundLayer))
        {
            if (NavMesh.SamplePosition(hit.point, out NavMeshHit navHit, 1.0f, NavMesh.AllAreas))
            {
                agent.SetDestination(navHit.position);
            }
        }
    }

}
