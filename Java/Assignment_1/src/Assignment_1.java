/*
 File will print out the 52 playing cards in 3 different ways
 Printing from ArrayList
 Printing from Array
 Printing from Array after being shuffled
*/

/**
 *
 * @author Tay Hao Lun
 */
import java.util.ArrayList;
import java.util.List;
import java.util.EnumSet;
import java.util.Random;

enum SuitEnum {Spade("S"),Heart("H"),Diamond("D"),Club("C");

private final String suit;

SuitEnum(String suit){
    this.suit=suit;
}

public String getSuit(){
    return suit;
}

}
enum RankEnum{Two("2"),Three("3"),Four("4"),Five("5"),Six("6"),Seven("7")
,Eight("8"),Nine("9"),Ten("T"),Jack("J"),Queen("Q"),King("K"),Ace("A");

private final String rank;

RankEnum(String rank){
    this.rank=rank;
}

public String getRank(){
    return rank;
}
}

class PlayingCard{   

private SuitEnum suit;
private RankEnum rank;

public PlayingCard(SuitEnum suit, RankEnum rank){
   this.suit=suit;
   this.rank=rank;
}

public PlayingCard(PlayingCard pc){
   this(pc.suit,pc.rank);
}

public SuitEnum getSuit(){
    return suit;
}

public RankEnum getRank(){
    return rank;
}

public void setCard(SuitEnum suit, RankEnum rank){
   this.suit=suit;
   this.rank=rank;
}

public String toString(){
        return String.format ("%s%s ",suit.getSuit(),rank.getRank());
                   
}
}

public class Assignment_1 {

    private final int MAXC=13;
    private final int MAXD=52;
    /**
     * @param args the command line arguments
     */
    private void printDeck(ArrayList<PlayingCard>values){
        System.out.printf("Printing from ArrayList");
        for(int i = 0; i < MAXD; i++){
            if(i%MAXC==0)
            {
                System.out.println();
                System.out.print(values.get(i));
            }
            else{
             System.out.print(values.get(i));
            }
    }
        System.out.println();
        System.out.printf("--------------------------------------\n");
        
    }
    
    private void printDeck(PlayingCard[]valuesArray){
        System.out.printf("Printing from array");
        for(int i = 0; i < MAXD; i++){
            if(i%MAXC==0)
            {
                System.out.println();
                System.out.print(valuesArray[i]);
            }
            else{
             System.out.print(valuesArray[i]);
            }
    }
        System.out.println();
        System.out.printf("--------------------------------------");
    }
   
    
    private void listToArray(ArrayList<PlayingCard>values,PlayingCard[]valuesArray){
        valuesArray = values.toArray(valuesArray);
    }
    
    private void deckofCards(ArrayList<PlayingCard>values){
            for(SuitEnum s:SuitEnum.values()){
                for(RankEnum r:RankEnum.values()){
                   values.add(new PlayingCard(s,r));
                }
       }
    }
    
    private void shuffle(PlayingCard[]valuesArray){
       for (int i = 0; i < valuesArray.length; i++) {
        int j = (int)(Math.random() * valuesArray.length); 
        PlayingCard temp = valuesArray[i]; 
        valuesArray[i] = valuesArray[j];
        valuesArray[j] = temp;
       }
    }
    
    public static void main(String[] args) {
        Assignment_1 lol=new Assignment_1();
        ArrayList<PlayingCard>values= new ArrayList<PlayingCard>();
        PlayingCard[]valuesArray =new PlayingCard[52];
        lol.deckofCards(values);
        lol.printDeck(values);
        lol.listToArray(values,valuesArray);
        lol.printDeck(valuesArray);
        System.out.println();
        System.out.printf("Shuffle the cards-Array Version\n");
        lol.shuffle(valuesArray);
        lol.printDeck(valuesArray);
        
    }
    
}

