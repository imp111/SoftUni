package PointInRecrangle;

public class Rectangle {
    private static Integer bottomLeftX;
    private static Integer bottomLeftY;
    private static Integer topRightX;
    private static Integer topRightY;

    public Rectangle(Integer bottomLeftX, Integer bottomLeftY, Integer topRightX, Integer topRightY)
    {
        this.bottomLeftX = bottomLeftX;
        this.bottomLeftY = bottomLeftY;
        this.topRightX = topRightX;
        this.topRightY = topRightY;
    }

    public static boolean Contains(Point point) {
        if (point.getX() >= bottomLeftX && point.getX() <= topRightX && point.getY() >= bottomLeftY && point.getY() <= topRightY) {
            return true;
        }

        return false;
    }
}
