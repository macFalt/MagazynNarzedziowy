using MagazynNarzedziowy.Domain.Entity;
using MagazynNarzedziowy.App.Abstract;
using Moq;
using Xunit;
using MagazynNarzedziowy.App.Managers;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.App.Common;

namespace MagazynNarzedziowy.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        ////Arrange
        //int a = 5;
        //int b = 3;
        ////Act
        //int result = a + b;
        ////assert dowod na to ze kod dziala w sposob prawidlowy
        //Assert.Equal(8, result);

        //Arrange
        Tools tool = new Tools(1, "W10", 1);
        var mock = new Mock<IService<Tools>>();
        mock.Setup(s => s.GetObjectById(1)).Returns(tool);

        var manager = new ToolManager();
        manager.AddNewTools(tool);
        
        //Act
        var returnedId = manager.GetObjectById(tool.Id);
        //Assert
        Assert.Equal(tool, returnedId);
    }
}
