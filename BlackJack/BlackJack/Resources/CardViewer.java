//Program to demonstrate JLIST

import java.awt.Image;
import java.awt.Graphics;
import java.applet.Applet;
import java.awt.*;




public class CardViewer extends Applet
{

	private Image[] cards = new Image[52];
	private int[] used = new int[52];
	private static int count;


	public void init()
	{
		String graphic;
		setSize(800,400);
		for (int x =0; x<52; x++)
		{
		graphic = ""+ (x+1)+".gif";
		cards[x] = getImage (getCodeBase(),graphic);
		used[x]=0;
		}
		count = 0;

}
	public  int Shuffle()
	{
		int y;
		if (count > 51)
			{
				count = 0;
				for (int x =0;x<52;x++)
					used[x]=0;
			}

			do{

			y = (int)(Math.random()*52);
			System.out.println(y);

			}while (used[y]==1);
			used[y]=1;
			count++;
			return y;



		}



    public void paint(Graphics g)
    {
		int value = 0;
	String output = "";
		for(int t = 0; t< 52; t++)
		{
			int index = Shuffle();

       		g.drawImage(cards[index],10+15*t,10,this);
       		System.out.println(t);
       		value+=(index%13+1);
       		output +=index%13+1+" ";

		}
		g.drawString(""+output, 20, 120);

    }



}
