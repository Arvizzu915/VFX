using UnityEngine;

public class ProceduralMesh : MonoBehaviour
{
    [SerializeField] private Material material;


    private MeshFilter _meshFilter;
    private Mesh _mesh;

    private MeshRenderer _meshRenderer;
    void Start()
    {
        //Crear los componenetes
        _meshFilter = gameObject.AddComponent<MeshFilter>();
        _meshRenderer = gameObject.AddComponent<MeshRenderer>();

        //Crear el mesh
        _mesh = new Mesh();
        _mesh.name = "Procedural Mesh";

        //Configurar el Mesh Data
        _mesh.vertices = new Vector3[]
        {
            //cara trasera
            new Vector3(0, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0),
            new Vector3(1, 0, 0),

            //cara frontal
            new Vector3(1, 0, 1),
            new Vector3(1, 1, 1),
            new Vector3(0, 1, 1),
            new Vector3(0, 0, 1),

            //cara derecha
            new Vector3(1, 0, 0),
            new Vector3(1, 1, 0),
            new Vector3(1, 1, 1),
            new Vector3(1, 0, 1),

            //cara izquierda
            new Vector3(0, 0, 1),
            new Vector3(0, 1, 1),
            new Vector3(0, 1, 0),
            new Vector3(0, 0, 0),

            //cara arriba
            new Vector3(0, 1, 0),
            new Vector3(0, 1, 1),
            new Vector3(1, 1, 1),
            new Vector3(1, 1, 0),

            //cara abajo
            new Vector3(0, 0, 1),
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 0, 1),

        };

        _mesh.triangles = new int[]
        {
            //cara trasera
            0, 1, 2,
            0, 2, 3,

            //cara trasera
            4, 5, 6,
            4, 6, 7,

            //cara derecha
            8, 9, 10,
            8, 10, 11,

            //cara izquierda
            12, 13, 14,
            12, 14, 15,

            //cara arriba
            16, 17, 18,
            16, 18, 19,

            //cara abajo
            20, 21, 22,
            20, 22, 23
        };

        _mesh.uv = new[]
        {
            //cara trasera
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),

            //cara frontal
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),

            //cara derecha
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),

            //cara izquierda
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),

            //cara arriba
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),

            //cara abajo
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
            new Vector2(1, 0),
        };

        _mesh.normals = new[]
        {
            //cara trasera
            Vector3.back,
            Vector3.back,
            Vector3.back,
            Vector3.back,

            //cara frontal
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,

            //cara derecha
            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right,

            //cara izquierda
            Vector3.left,
            Vector3.left,
            Vector3.left,
            Vector3.left,

            //cara arriba
            Vector3.up,
            Vector3.up,
            Vector3.up,
            Vector3.up,

            //cara abajo
            Vector3.down,
            Vector3.down,
            Vector3.down,
            Vector3.down,
        };

        _mesh.colors = new[]
        {
            //cara trasera
            Color.black, 
            Color.green,
            Color.yellow,
            Color.red,

            //cara frontal
            Color.magenta,
            Color.white,
            Color.cyan,
            Color.blue,

            //cara derecha
            Color.red,
            Color.yellow,
            Color.white,
            Color.magenta,

            //cara izquierda
            Color.blue,
            Color.cyan,
            Color.green,
            Color.black,

            //cara arriba
            Color.green,
            Color.cyan,
            Color.white,
            Color.yellow,

            //cara abajo
            Color.blue,
            Color.black,
            Color.red,
            Color.magenta,
        };


        //Asignar referencias
        _meshFilter.mesh = _mesh;
        _meshRenderer.material = material;
    }

    void Update()
    {

    }
}