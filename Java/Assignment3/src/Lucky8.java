/*One Click. Generate 7 random numbers and 25. Bottom Row shows the same number


 */

/**
 *
 * @author Tay
 */
import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.GridLayout;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Color;
import java.util.ArrayList;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;
import java.util.Collections;
import java.util.function.Function;
import java.util.Comparator;


 class Lucky8 extends JFrame implements ActionListener
{
    private final JButton [] buttArray;
    private final JButton [] buttArray1;
    private final JButton [] buttArray2;
     private final JButton [] TwentyFive;
    String[] letters={"G","O","O","D","L","U","C","K"};
    ArrayList <Integer> Shuffle = new ArrayList <Integer> ();
    ArrayList <Integer> Lucky   = new ArrayList <Integer> ();

    public Lucky8 ()
    {
        super ("Lucky 8");
        setLayout(new GridLayout (10,8));
        buttArray = new JButton [64];
        
        
         for (int i = 0; i < 64; i++)
        {
            Icon image = new ImageIcon(getClass().getResource("Slime.png"));
            buttArray [i] = new JButton (image);
            add (buttArray [i]);
            buttArray [i].addActionListener (this);
        }
        
         buttArray1=new JButton [8];
        for (int i = 0; i < 8; i++)
        {
            buttArray1[i]=new JButton(letters[i]);
            add(buttArray1[i]);
        }
        
    
        for (int i = 0; i < 64; i++)
        {
            Shuffle.add (i+1);
        }
        
        Collections.shuffle (Shuffle);
        for (int i = 0; i < 7; i++)
        {
            Lucky.add (Shuffle.get(i));
        }
        
        buttArray2=new JButton[7];
         for(int i = 0; i < 7; i++)
        {
          Icon image = new ImageIcon(getClass().getResource("Slime.png"));
          buttArray2 [i] = new JButton (image);
          add (buttArray2 [i]);
        }
        TwentyFive=new JButton[1];
        for(int i=0;i<1;i++)
        {
         Icon image = new ImageIcon(getClass().getResource("Slime.png"));
          TwentyFive [i] = new JButton (image);
          add (TwentyFive [i]);
        }
        
        Collections.shuffle (Shuffle);
        setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
        setSize (800,700);
        setVisible (true);

    }
    @Override
    public void actionPerformed (ActionEvent e)
    {
      String [] a = new String [7];
      for (int i = 0; i < 7; i++)
      {
          a [i] = String.valueOf(Lucky.get(i));
          
      }
        List <String> alist = Arrays.asList (a);
        List <String> sortedList = Arrays.stream (a).sorted ().collect (Collectors.toList ());
        
      int n = 0;
     
      for (JButton lol:buttArray2)
      {
                
                lol.setText(sortedList.get(n));
                lol.setBackground (Color.CYAN);
                lol.setForeground (Color.BLUE);    
                n++;           
                 
      }
      n = 0;
        for (JButton lol : buttArray)
        {
              lol.setText (String.valueOf (Shuffle.get(n)));
              
                for (int i = 0; i < 7; i++)
                {
                    if (Shuffle.get(n) == Lucky.get(i))
                    {
                        lol.setBackground (Color.CYAN);
                        lol.setForeground (Color.BLUE);
                    }
                    else if (Shuffle.get(n) == 25 )
                    {
                        lol.setBackground (Color.DARK_GRAY);
                        lol.setForeground (Color.RED);
                    }
                 }
            n++;
        }
        for(JButton lol:TwentyFive)
        {
            lol.setText("25");
            lol.setBackground (Color.DARK_GRAY);
            lol.setForeground (Color.RED);
        }
        
       
          
    }
 }

class Lucky8_1
{
    public static void main (String [] args)
    {
        Lucky8 lucky8 = new Lucky8 ();
        
    }
}