namespace MindBox.Test;

public class ShapeTest
{
    [Test]
    public void RectangleTriangleReturns6AndRectangular()
    {
        //Arrange
        IShape triangle = new Triangle(3, 4, 5);

        //Act
        double area = triangle.GetArea();
        bool isRect = (triangle as Triangle).isRectangular();

        //Assert
        Assert.AreEqual(6, area);
        Assert.AreEqual(true, isRect);

    }

    [Test]
    public void NotRectTriangleReturns72AndNotRectangular()
    {
        //Arrange
        IShape triangle = new Triangle(10, 15, 20);
        
        //Act
        double area = triangle.GetArea();
        bool isRect = (triangle as Triangle).isRectangular();

        //Assert
        Assert.AreEqual(73,  double.Ceiling(area));
        Assert.AreEqual(false, isRect);
    }

    [Test]
    public void CircleReturns50()
    {
        //Arrange
        IShape circle = new Circle(4);

        //Act
        double area = circle.GetArea();

        //Assert
        Assert.AreEqual(50.26548245743669d, area);
    }
}