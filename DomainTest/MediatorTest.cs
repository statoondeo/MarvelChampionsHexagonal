using MarvelChampionsDomain.Tools;
using MarvelChampionsDomain.Tools.Events;

namespace DomainTest;

[TestClass]
public class MediatorTest
{
	[TestMethod]
	public void RegisterAndRaiseTestMethod()
	{
		// Arrange
		IMediatorService mediator = new Mediator();
		int nbCalls = 0;
		void Callback(IEventArg arg) => nbCalls++;
		mediator.RegisterListener<OnGameStartedEvent>(Callback);

		// Act
		mediator.Raise<OnGameStartedEvent>();

		// Assert
		Assert.IsTrue(nbCalls == 1);
	}
	[TestMethod]
	public void RaiseTargetedTestMethod()
	{
		// Arrange
		IMediatorService mediator = new Mediator();
		int nbCalls = 0;
		void Callback(IEventArg arg) => nbCalls++;
		mediator.RegisterListener<OnGameStartedEvent>(Callback);

		// Act
		mediator.Raise<OnGameEndedEvent>();

		// Assert
		Assert.IsTrue(nbCalls == 0);
	}
	[TestMethod]
	public void UnregisterTestMethod()
	{
		// Arrange
		IMediatorService mediator = new Mediator();
		int nbCalls = 0;
		void Callback(IEventArg arg) => nbCalls++;
		mediator.RegisterListener<OnGameStartedEvent>(Callback);
		mediator.UnregisterListener<OnGameStartedEvent>(Callback);

		// Act
		mediator.Raise<OnGameStartedEvent>();

		// Assert
		Assert.IsTrue(nbCalls == 0);
	}
	[TestMethod]
	public void RaiseMultipleTargetedTestMethod()
	{
		// Arrange
		IMediatorService mediator = new Mediator();
		int nbCalls = 0;
		void CallbackStarted(IEventArg arg) { }
		void CallbackEnded(IEventArg arg) => nbCalls++;
		mediator.RegisterListener<OnGameStartedEvent>(CallbackStarted);
		mediator.RegisterListener<OnGameEndedEvent>(CallbackEnded);

		// Act
		mediator.Raise<OnGameEndedEvent>();
		mediator.Raise<OnGameEndedEvent>();

		// Assert
		Assert.IsTrue(nbCalls == 2);
	}
}