using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
    public int startHealth = 50; //Cuantas vidas hay
    public int healthperHeart = 10; //Cuanto vale cada vida
    public GUITexture heartGUI; //Donde voy a sacar el puto dibujo?
    private ArrayList hearts = new ArrayList(); //aqui guardamos los corazones (ardillas) que llevamos
    private float spacingX;
    private float spacingY;//este y el de arriba son para saber que tan separados van a estar
    private int maxHeartsPerRow = 7; //esto no nos sirve pero viene en el tutorial, mantener hasta que lo cambie yo
    private int currentHealth;
    private int maxHealth = 70;
    public Texture[] images;
	// Use this for initialization
	void Start ()
    {
        spacingX = heartGUI.pixelInset.width;
        spacingY = -heartGUI.pixelInset.height; //estos ultimos dos sirven para referenciar al GUI y la separacion entre vidas
        AddHearts(startHealth / healthperHeart);
	}

    public void AddHearts(int n)
    {
        for (int i = 0; i < n; ++i)
        {
            Transform newHeart = ((GameObject)Instantiate(heartGUI.gameObject, transform.position, Quaternion.identity)).transform;//multiplicamos el objeto base
            newHeart.parent = this.transform; //lo volvemos hijo de health
            int y = Mathf.FloorToInt(hearts.Count / maxHeartsPerRow);//para saber en que fila lo agragamos
            int x = hearts.Count - (y * maxHeartsPerRow);//reseteamos la siguiente fila a 0
            newHeart.GetComponent<GUITexture>().pixelInset = new Rect (x * spacingX, y * spacingY, 0, 0);

            hearts.Add(newHeart); //lo agregamos al array para saber cuantas vidas tenemos 
        }
        maxHealth += n * healthperHeart;
        currentHealth += maxHealth;
        UpdateHearts();
    }

    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth,0,maxHealth);
        UpdateHearts();
    }

    private void UpdateHearts()
    {
        bool restAreEmpty = false;
        int i = 0;
        foreach(Transform heart in hearts)
        {
            if(restAreEmpty)
            {
                heart.GetComponent<GUITexture>().texture = images[0];
            }
            else
            {
                if(currentHealth >= i * healthperHeart)
                {
                    heart.GetComponent<GUITexture>().texture = images[1];
                    //i = 0;
                }
                else
                {
                    int currentHeartHealth = (int)healthperHeart - ((healthperHeart * i) - currentHealth);
                    int healthPerImage = healthperHeart / images.Length;
                    int imageIndex = currentHealth / healthPerImage;

                    if (imageIndex == 0 && currentHeartHealth > 0)
                        imageIndex = 1;

                    heart.GetComponent<GUITexture>().texture = images[imageIndex];
                    restAreEmpty = true;
                }
            }
        }
    }
}
