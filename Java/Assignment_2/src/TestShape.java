/*
Generate random 2D and 3D shapes 
Generate out Area and volume out
Display out in Array List

 */

/**
 *
 * @author Tay
 */

import java.util.ArrayList;
import java.util.Random;

interface Shape
{
    public double area();
    public double getArea();
}

abstract class TwoD implements Shape
{
    protected int a;
    protected int b;
    protected int c;
    
    public TwoD()
    {
        
    }
    
    public TwoD(int a){
        this.a=a;
    }
    
    public TwoD(int a,int b){
        this.a=a;
        this.b=b;
    }
    
    public TwoD(int a, int b,int c){
        this.a=a;
        this.b=b;
        this.c=c;
    }
    
    public TwoD(TwoD td){
        this(td.a,td.b,td.c);
    }
    
     public int getA(int a){
        return a;
    }
    
    public int getB(int b){
        return b;
    }
    
    public int getC(int c){
        return c;
    }
    
    @Override
    public String toString(){
        if(b==0&&c==0){
        return String.format ("(2D(%d))==>",a);}
        if(c==0){
        return String.format("(2D(%d,%d))==>",a,b);}
        else
        return String.format("(2D(%d,%d %d))==>",a,b,c);
    }
}

abstract class ThreeD implements Shape
{
    protected int a;
    
    public ThreeD(){
        
    }
    
    public ThreeD(int a){
        this.a=a;
    }
    
    public int GetA(){
        return a;
    }
    
    public ThreeD(ThreeD td){
        this(td.a);
    }
    protected double volume(){
        double volume;
        volume=area()*a;
        return volume;
    }
    protected double getVolume(){
        return volume();
    }
    @Override
     public String toString(){
        return String.format ("(3D(%d))==>",a);
    }
}

class Sphere extends ThreeD
{
    public Sphere(int a){
        super(a);
    }
    @Override
    public double area(){
        double area;
        area=4*Math.PI*a;
        return area;
    }
    @Override
    public double getArea(){
        return area();
    }
    @Override
    protected double volume(){
        double volume;
        volume=Math.PI*4/3*(Math.pow(a, 3));
        return volume;
    }
    @Override
    public double getVolume(){
        return volume();
    }
    @Override
    public String toString(){
        return String.format ("Sphere %s",super.toString());
    }
}

class Cube extends ThreeD
{
    public Cube(int a)
    {
       super(a);
    }
    
     
    @Override
    public double area(){
        double area;
        area=Math.pow(a,2);
        return area;
    }
    @Override
    public double getArea(){
        return area();
    }
    @Override
    protected double volume(){
        double volume;
        volume=Math.pow(a,3);
        return volume;
    }
    @Override
    public double getVolume(){
        return volume();
    }
    @Override
    public String toString(){
        return String.format ("Cube %s ",super.toString());
    }
    
}

class Tetrahedron extends ThreeD{
   public Tetrahedron(int a){
       super(a);
   }
   @Override
   public double area(){
       double area;
       area=Math.sqrt(Math.pow(3*a,2));
       return area;
   }
   @Override
   public double getArea(){
       return area();
   }
   @Override
   protected double volume(){
       double volume;
       volume=Math.pow(a,3)/6*Math.sqrt(2);
       return volume;
   }
   @Override
    public double getVolume(){
        return volume();
    }
   @Override
     public String toString(){
        return String.format("Tetrahedron %s",super.toString());
    }
   
}

class Circle extends TwoD
{
    public Circle (int radius)
    {
        this.a=radius;
    }
    @Override
    public double area()
    {
        double area;
        area=Math.PI*Math.pow(a,2);
        return area;
    }
    @Override
    public double getArea()
    {
        return area();
    }
    
    @Override
    public String toString()
    {
        return String.format ("Circle %s",super.toString(),getArea());
    }
}
class Rectangle extends TwoD
{
    public Rectangle(int length,int width)
    {
        this.a=length;
        this.b=width;
    }
    @Override
    public double area()
    {
        double area;
        area=this.a*this.b;
        return area;
    }
    @Override
    public double getArea()
    {
        return area();
    }
    @Override
    public String toString()
    {
        return String.format ("Rectangle %s",super.toString(),getArea());
    }
    
}

class Triangle extends TwoD
{
    public Triangle(int a,int b,int c)
    {
        this.a=a;
        this.b=b;
        this.c=c;
    }
    @Override
    public double area()
    {
        double area;
        area=(a*c)/2;
        return area;
    }
    @Override
    public double getArea()
    {
        return area();
    }
    @Override
    public String toString()
    {
        return String.format ("Triangle %s ",super.toString(),getArea());
    }
    
}



public class  TestShape{
    private static Random rand =new Random();
    
    private static int getInt(){
        int n1=rand.nextInt(10);
        if(n1==0){
            return getInt();
        }
                return n1;
    }
    
    private static TwoD getTwo(){
         int ts=getInt();
        if(ts==1)
        {
            Circle ce=new Circle(getInt());
            return ce;
        }
        if(ts==2)
        {
            Rectangle ce= new Rectangle(getInt(),getInt());
            return ce;
        }
        if(ts==3)
        {
            Triangle ce = new Triangle(getInt(),getInt(),getInt());
            return ce;
        }
        return getTwo();
    }
    
    private static ThreeD getThree(){
        int td=getInt();
        if(td==4)
        {
            Sphere co=new Sphere(getInt());
            return co;
        }
        if(td==5)
        {
            Cube co= new Cube(getInt());
            return co;
        }
        if(td==6)
        {
            Tetrahedron co = new Tetrahedron(getInt());
            return co;
        }
        return getThree();
    }
    
    private static void displayList(ArrayList <Shape>alist){
                   for (Shape shape : alist){
                       System.out.printf("Shape[%s]=",alist.indexOf(shape));
			if (shape instanceof Circle)
			{
				Circle cy = (Circle) (shape);
                                System.out.print (shape);
				System.out.printf ("Area=%.3f\nI am a Circle Shape\n",cy.getArea());
			}
                       else if (shape instanceof Rectangle)
			{
				Rectangle cy = (Rectangle) (shape);
                                System.out.print (shape);
				System.out.printf ("Area=%.3f\nI am a Rectangle Shape\n",cy.getArea());
			}
                       else if (shape instanceof Triangle)
			{
				Triangle cy = (Triangle) (shape);
                                System.out.print (shape);
				System.out.printf ("Area=%.3f\nI am a Triangle Shape\n",cy.getArea());
			}
			
                        else if (shape instanceof Cube)
			{
				Cube cy = (Cube) (shape);
                                System.out.print(shape);
				System.out.printf ("Surface area=%.3f,Volume: %.3f%n I am a Cube shape\n",cy.getArea(),cy.getVolume ());
			}
                        
                       else if (shape instanceof Sphere)
			{
				Sphere cy = (Sphere) (shape);
                                System.out.print (shape);
				System.out.printf ("Surface area=%.3f,Volume: %.3f%n I am a Sphere shape\n",cy.getArea(),cy.getVolume ());
			}
                       else if (shape instanceof Tetrahedron)
			{
				Tetrahedron cy = (Tetrahedron) (shape);
                                System.out.print (shape);
				System.out.printf ("Surface area=%.3f,Volume: %.3f%n I am a Tetrahedron shape\n",cy.getArea(),cy.getVolume ());
			}
			
			System.out.println ("---------------------");
                   }
    }   
    
     public static void main(String[] args) {
         TestShape lol=new TestShape();
         ArrayList <Shape> alist = new ArrayList <Shape> ();
         for(int i=1;i<=9;i++)
       {
           if(getInt()<=3){
           alist.add(getTwo());
           }
           else{
           alist.add(getThree());
           }
       }
         
         lol.displayList(alist);
     }
}
     
