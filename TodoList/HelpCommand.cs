﻿

namespace TodoList1;

public class HelpCommand : BaseCommand
{
	public override void Execute()
	{
		Console.Write(
		"Доступные команды:\n" +
		"help - показать все команды\n" +
		"profile - показать профиль\n" +
		"add \"задача\" - добавить задачу\n" +
		"add --multiline / add -m - многострочный режим добавления\n" +
		"view - показать все задачи\n" +
		"view --index / view -i - показать задачи с индексами\n" +
		"view --status / view -s - показать задачи со статусом\n" +
		"view --date / view -d - показать задачи с датой изменения\n" +
		"view --all или view -a - показать все данные задач\n" +
		"read \"номер\" - просмотреть полный текст задачи\n" +
		"done \"номер\" - отметить задачу выполненной\n" +
		"delete \"номер\" - удалить задачу\n" +
		"update \"номер\" \"новый текст\" - обновить задачу\n" +
		"exit - выйти из программ\n"
		);
	}
}