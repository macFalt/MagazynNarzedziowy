using MagazynNarzedziowy.Domain.Entity;
using MagazynNarzedziowy.App.Abstract;
using Moq;
using Xunit;
using MagazynNarzedziowy.App.Managers;
using MagazynNarzedziowy.App.Concrete;
using MagazynNarzedziowy.App.Common;
using FluentAssertions;

namespace MagazynNarzedziowy.Test;

public class UnitTest1
{
    //[Fact]
    //public void Test1()
    //{
    //    ////Arrange
    //    //int a = 5;
    //    //int b = 3;
    //    ////Act
    //    //int result = a + b;
    //    ////assert dowod na to ze kod dziala w sposob prawidlowy
    //    //Assert.Equal(8, result);

    //    //Arrange
    //    Tools tool = new Tools(1, "W10", 1);
    //    var mock = new Mock<IService<Tools>>();
    //    mock.Setup(s => s.GetObjectById(1)).Returns(tool);

    //    var manager = new ToolManager(new MenuActionServise(), mock.Object);


    //    //Act
    //    var returnedId = manager.ShowDetail(tool.Id);

    //    //Assert
    //    //Assert.Equal(tool, returnedId);  MOQ

    //    //FluentAssertions
    //    returnedId.Should().BeOfType(typeof(Tools));
    //    returnedId.Should().NotBeNull();
    //    returnedId.Should().BeSameAs(tool);
    //}

    //[Fact]
    ////TDD najpierw test potem metoda

    //public void CanDeleteToolWithProperId()
    //{
    ////Arrange
    //Tools tool = new Tools(1,"Frez",2);
    //var mock = new Mock<IService<Tools>>();
    //mock.Setup(m => m.GetObjectById(1)).Returns(tool);
    //mock.Setup(m => m.RemoveObject(It.IsAny<Tools>()));
    //var manager = new ToolManager(new MenuActionServise(), mock.Object);
    ////Act
    //manager.RemoveToolById(tool.Id);
    ////Assert
    //mock.Verify(m => m.RemoveObject(tool));
    //}

    //Testy integracyjne
    [Fact]
    public void CanDeleteToolWithProperId()
    {

        //Arrange
        Tools tool = new Tools(1, "Frez", 2);
        IService<Tools> toolService = new ToolService();
        toolService.AddObject(tool);

        var manager = new ToolManager(new MenuActionServise(), toolService);
        //Act
        manager.RemoveToolById(tool.Id);
        //Assert
        //toolService.GetObjectById(tool.Id).Should().BeNull();
        toolService.Objects.FirstOrDefault(p => p.Id == tool.Id).Should().BeNull();

        //    //Clean


        //}





    }
}