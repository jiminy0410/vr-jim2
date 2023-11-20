using UnityEngine;

public class PairScr : MonoBehaviour
{
    [SerializeField] GameObject Cube1;
    [SerializeField] GameObject Cube2;
    public bool Cube1Done;
    public bool Cube2Done;
    [SerializeField] string MyCoulour;
    [SerializeField] GameObject Memory;
    public MemoryScr memoryScr;
    public Material Coulour;
    [SerializeField] Material Blank;
    public int correct;
    public bool coldog;

    // Start is called before the first frame update
    void Start()
    {
        //Memory = GameObject.Find("memory gane");
        memoryScr = Memory.GetComponent<MemoryScr>();
        foreach (GameObject g in memoryScr.Pairs)
        {
            if (g.name == this.gameObject.name)
            {
                switch (g.name)
                {
                    case "pair":
                        MyCoulour = "a";
                        break;
                    case "pair (1)":
                        MyCoulour = "b";
                        break;
                    case "pair (2)":
                        MyCoulour = "c";
                        break;
                    case "pair (3)":
                        MyCoulour = "d";
                        break;
                    case "pair (4)":
                        MyCoulour = "e";
                        break;
                    case "pair (5)":
                        MyCoulour = "f";
                        break;
                    case "pair (6)":
                        MyCoulour = "g";
                        break;
                    case "pair (7)":
                        MyCoulour = "h";
                        break;
                    case "pair (8)":
                        MyCoulour = "i";
                        break;
                    case "pair (9)":
                        MyCoulour = "j";
                        break;
                }
            }
        }
        checkCoulour();
    }

    public void changeCoulour(Material coulour, GameObject cube)
    {
        cube.GetComponent<MeshRenderer>().material = coulour;
    }

    public void revertCoulour()
    {
        if (correct <= 2)
        {
            checkCoulour();
            changeCoulour(Blank, Cube1);
            changeCoulour(Blank, Cube2);
            Cube1Done = false;
            Cube2Done = false;
            correct = 0;
        }
    }

    public void done()
    {
        if (correct == 2)
        {
            GameObject.Find("ScoreBoard").GetComponent<ScoreBoardScr>().Score++;
            correct++;
        }
    }

    public void checkCoulour()
    {
        if (coldog)
        {
            Coulour = Resources.Load<Material>("memmory/Materials/" + MyCoulour);
        }
        else
        {
            Coulour = Resources.Load<Material>("memmory/" + MyCoulour);
        }
    }
}
