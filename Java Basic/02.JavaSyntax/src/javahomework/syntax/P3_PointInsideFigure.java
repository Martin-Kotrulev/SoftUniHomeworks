package javahomework.syntax;
import java.util.Scanner;

/**
 * Problem 3. Points inside a Figure
 * Write a program to check whether a point is 
 * inside or outside of the figure below. 
 * The point is given as a pair of floating-point 
 * numbers, separated by a space. Your program 
 * should print "Inside" or "Outside".
 */

public class P3_PointInsideFigure {
    static class Point{
        private float x;
        private float y;
        
        public Point() {};
        
        public Point(float _x, float _y) {
            this.x = _x;
            this.y = _y;
        }
    }
    
    static class Quadriliteral {
        private final float HEIGHT;
        private final float WIDTH;
        Point origin = new Point();
        
        public Quadriliteral(Point origin, float height, float width){ 
            // setting all point of the quadriteral based on the origin point 
            this.origin = origin;
            this.WIDTH = width;
            this.HEIGHT = height;
        }
    }
    
    static String checkPointPosition(Point toCheck, Quadriliteral ... quads) {
        String position = "Outside";
        for (Quadriliteral quad : quads) {
            if ((toCheck.x >= quad.origin.x && toCheck.x <= quad.origin.x + quad.WIDTH) &&
                    (toCheck.y <= quad.origin.y && toCheck.y >= quad.origin.y - quad.HEIGHT))
                    position = "Inside";
        }
        return position;
    }
    
    public static void main (String[] args) {
        // the figure is represented by three quadriliterals
        Quadriliteral firstQuad = new Quadriliteral(new Point(12.5f, 13.5f), 5f, 5f);
        Quadriliteral secondQuad = new Quadriliteral(new Point(12.5f, 8.5f), 2.5f, 10f);
        Quadriliteral thirdQuad = new Quadriliteral(new Point(20f, 13.5f), 5f, 2.5f);
        
        Scanner in = new Scanner(System.in);
        Point toCheck = new Point(
                in.hasNextInt() ? in.nextInt() : in.nextFloat(),
                in.hasNextInt() ? in.nextInt() : in.nextFloat());
        
        System.out.println(checkPointPosition(toCheck, firstQuad, secondQuad, thirdQuad));
    }
}