namespace ConsoleApp;

public sealed class ConsoleSelectOnlyOneItem
{
	private readonly string PromptText;
	private readonly List<string> ChoiceValues;
	public ConsoleSelectOnlyOneItem(string promptText, List<string> choiceValues)
	{
		PromptText = promptText;
		ChoiceValues = choiceValues;
	}
	public int DisplaySelectionScreen()
	{
		int selectOption;
		ConsoleKeyInfo key;
		do
		{
			Console.Clear();
			Console.WriteLine(PromptText);
			Console.WriteLine();
			int i = 1;
			ChoiceValues.ForEach(choice => {
				Console.WriteLine($"\t {i} : {choice}");
				i++;
			});
			Console.WriteLine();
			Console.Write("\t Your choice : ");
			key = Console.ReadKey();
		}
		while (!int.TryParse(key.KeyChar.ToString(), out selectOption)
			|| ((selectOption <= 0)
			|| (ChoiceValues.Count < selectOption)));
		return selectOption - 1;
	}
}