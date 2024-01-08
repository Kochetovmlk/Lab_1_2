using NUnit.Framework;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void CalculateArea_ShouldReturnCorrectArea()
    {
        // Arrange
        var rectangle = new Rectangle(2, 3);

        // Act
        var area = rectangle.Area;

        // Assert
        Assert.AreEqual(6, area);
    }

    [Test]
    public void CalculatePerimeter_ShouldReturnCorrectPerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(2, 3);

        // Act
        var perimeter = rectangle.Perimeter;

        // Assert
        Assert.AreEqual(10, perimeter);
    }
}