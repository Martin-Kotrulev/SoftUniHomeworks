
import java.util.Scanner;


public class P2_TriangleArea {
    
    private static class Point {
        int x;
        int y;
        
        public Point (int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    static double threePointsTriangleArea(Point a, Point b, Point c) {
        return Math.abs(((a.x * (b.y - c.y)) + 
                (b.x * (c.y - a.y)) + 
                (c.x * (a.y - b.y))) / (double)2);
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        Point a = new Point(in.nextInt(), in.nextInt());
        Point b = new Point(in.nextInt(), in.nextInt());
        Point c = new Point(in.nextInt(), in.nextInt());
        
        System.out.println(threePointsTriangleArea(a, b, c));
    }
}
