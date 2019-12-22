using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Word = Microsoft.Office.Interop.Word;

namespace WordTicket
{
    public partial class ThisAddIn
    {
        const string StartMarker = "[Начало задания]";
        const string EndMarker = "[Конец задания]";
        const string TaskComplexity = "[Сложность=1]";

        const string UniversityMarker = "[Университет]";
        const string FacultyNameMarker = "[Факультет/институт]";
        const string DepartmentAbbreviationMarker = "[Кафедра]";
        const string DisciplineNameMarker = "[Дисциплина]";
        const string PreparationDirectionMarker = "[Направление подготовки]";
        const string CourseMarker = "[Курс]";
        const string GroupsMarker = "[Группы]";
        const string TrainingFormMarker = "[Форма обучения]";
        const string DateMarker = "[Дата]";
        const string ProtocolNumberMarker = "[Номер протокола]";
        const string HardenerPositionMarker = "[Должность подписанта]";
        const string FacultyAbbreviationMarker = "[Аббревиатура факультета/института]";
        const string FullNameMarker = "[ФИО]";
        const string SignatureMarker = "[Подпись]";

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        int GetIndexByComplexity((int Complexity, List<Word.Range> Tasks)[] tasks, int complexity)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Complexity == complexity)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetTaskCount((int Complexity, List<Word.Range> Tasks)[] tasks)
        {
            int count = 0;
            foreach (var t in tasks)
            {
                count += t.Tasks.Count;
            }
            return count;
        }

        public void RemoveAllMarkers()
        {
            var f1 = this.Application.ActiveDocument.Range().Find;
            var f2 = this.Application.ActiveDocument.Range().Find;
            while (f1.Execute(FindText: StartMarker, ReplaceWith: string.Empty))
            { }
            while (f2.Execute(FindText: EndMarker, ReplaceWith: string.Empty))
            { }

            var complexityRegex = new Regex("\\[Сложность=(.*?)\\]", RegexOptions.Singleline);
            var complexityMatches = complexityRegex.Matches(this.Application.ActiveDocument.Range().Text);
            foreach (Match match in complexityMatches)
            {
                this.Application.ActiveDocument.Range().Find.Execute(FindText: match.Value, ReplaceWith: string.Empty);
            }
        }

        public (int Complexity, List<Word.Range> Tasks)[] GetTasksAndComplexity()
        {
            try
            {
                var r1 = this.Application.ActiveDocument.Range();
                var r2 = this.Application.ActiveDocument.Range();
                var f1 = r1.Find;
                var f2 = r2.Find;
                var complexityRegex = new Regex("\\[Сложность=(.*?)\\]", RegexOptions.Singleline);
                var tasks = new List<(int Complexity, List<Word.Range> Tasks)>();
                while (true)
                {
                    bool f1Res = f1.Execute(FindText: StartMarker);
                    bool f2Res = f2.Execute(FindText: EndMarker);
                    if (!f1Res && !f2Res)
                    {
                        break;
                    }
                    else if (!(f1Res && f2Res))
                    {
                        Announce?.Invoke("Меток начала и конца задания неравное кол-во. Задание должно быть заключено " +
                        "в две ключевых последовательности. \n[Начало задания]Пример задания[Конец задания]", "Ошибка");
                        return null;
                    }
                    var taskRange = this.Application.ActiveDocument.Range(r1.End, r2.Start);
                    var complexityMatches = complexityRegex.Matches(taskRange.Text);
                    if (complexityMatches.Count == 0)
                    {
                        Announce?.Invoke("Не найдена сложность у задания." +
                            StartMarker + TaskComplexity + "Пример задания" + EndMarker, "Ошибка");
                        return null;
                    }
                    bool complexityParseRes = int.TryParse(complexityMatches[0].Groups[1].Value, out int complexity);
                    if (!complexityParseRes)
                    {
                        Announce?.Invoke("Ошибка при конвертации сложностей: " + complexity, "Ошибка");
                        return null;
                    }
                    taskRange.Duplicate.Find.Execute(FindText: complexityMatches[0].Groups[0].Value);
                    int index = GetIndexByComplexity(tasks.ToArray(), complexity);
                    if (index == -1)
                    {
                        index = tasks.Count;
                        tasks.Add((complexity, new List<Word.Range>()));
                    }
                    tasks[index].Tasks.Add(taskRange);
                }
                if (tasks.Count == 0)
                {
                    Announce?.Invoke("Не найдено ни одного задания. Задание должно быть заключено " +
                        "в две ключевых последовательности. \n[Начало задания]Пример задания[Конец задания]", "Ошибка");
                    return null;
                }
                return tasks.ToArray();
            }
            catch (Exception ex)
            {
                Announce?.Invoke("Ошибка. Проверьте разметку. Дополнительная информация:\n" + ex.Message, "Ошибка");
                return null;
            }
        }

        (int Complexity, Word.Range Task)[,] FillTickets((int Complexity, List<Word.Range> Tasks)[] tasks, int ticketCount, int tasksPerTicketCount)
        {
            int[] enumerator = new int[tasks.Length];
            (int Complexity, Word.Range Task)[,] tickets = new (int, Word.Range)[ticketCount, tasksPerTicketCount];
            int taskCount = GetTaskCount(tasks);
            int[] complexityArr = new int[taskCount];
            for (int i = 0, k = 0; i < tasks.Length; i++)
            {
                for (int j = 0; j < tasks[i].Tasks.Count; j++, k++)
                {
                    complexityArr[k] = tasks[i].Complexity;
                }
            }
            for (int ticketNumber = 0; ticketNumber < ticketCount; ticketNumber++)
            {
                for (int taskNumber = 0; taskNumber < tasksPerTicketCount; taskNumber++)
                {
                    int globalTaskNumber = taskNumber * ticketCount +
                        (taskNumber % 2 == 0 ? ticketNumber : ticketCount - 1 - ticketNumber);
                    tickets[ticketNumber, taskNumber].Complexity = complexityArr[globalTaskNumber];
                    int index = GetIndexByComplexity(tasks, complexityArr[globalTaskNumber]);
                    tickets[ticketNumber, taskNumber].Task = tasks[index].Tasks[enumerator[index]++];
                }
            }
            return tickets;
        }

        public event Action<string, string> Announce;

        public void PlaceMarkers()
        {
            var pars = this.Application.ActiveDocument.Paragraphs;
            int count = pars.Count;
            for (int i = 1; i <= count; i++)
            {
                var par = pars[i];
                try
                {
                    par.Range.InsertBefore(StartMarker + TaskComplexity);
                    var range = par.Range;
                    range.SetRange(par.Range.Start, par.Range.End - 1); // After paragrapgh but before \r
                    range.InsertAfter(EndMarker);
                }
                catch (Exception)
                {

                }
            }
        }

        void AddTask(ref (int Complexity, List<Word.Range> Tasks)[] tasks, int tasksToAddCount)
        {
            var enumerator = new (bool Flag, int Start, int Middle, int Count)[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                enumerator[i].Middle = tasks[i].Tasks.Count / 2;
                enumerator[i].Count = tasks[i].Tasks.Count;
            }
            while (tasksToAddCount != 0)
            {
                int min = 0;
                for (int i = 1; i < tasks.Length; i++)
                {
                    if (tasks[i].Tasks.Count < tasks[min].Tasks.Count)
                    {
                        min = i;
                    }
                }
                int copyIndex;
                if (enumerator[min].Flag)
                {
                    copyIndex = enumerator[min].Start++ % enumerator[min].Count;
                    enumerator[min].Flag = false;
                }
                else
                {
                    copyIndex = enumerator[min].Middle++ % enumerator[min].Count;
                    enumerator[min].Flag = true;
                }
                tasks[min].Tasks.Add(tasks[min].Tasks[copyIndex]);
                tasksToAddCount--;
            }
        }

        void ShuffleTasks((int Complexity, List<Word.Range> Tasks)[] tasks)
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            foreach (var t in tasks)
            {
                for (int i = 0; i < t.Tasks.Count; i++)
                {
                    var buf = t.Tasks[i];
                    int newIndex = rnd.Next(t.Tasks.Count);
                    t.Tasks[i] = t.Tasks[newIndex];
                    t.Tasks[newIndex] = buf;
                }
            }
        }

        public void MakeTickets(int ticketCount, int tasksPerTicketCount, string templatePath)
        {
            var tasks = GetTasksAndComplexity();
            if (tasks == null)
            {
                return;
            }
            Array.Sort(tasks, (first, second) => first.Complexity.CompareTo(second.Complexity));
            ShuffleTasks(tasks);
            int taskCount = GetTaskCount(tasks);
            if (ticketCount * tasksPerTicketCount > taskCount)
            {
                Announce?.Invoke($"Кол-во заданий ({taskCount}), которые вы пометили, меньше кол-ва " +
                    $"билетов ({ticketCount}), умноженного на кол-во заданий в билете ({tasksPerTicketCount}). " +
                    "Нехватающие задания будут продублированы исходя из баланса заданий с разными сложностями",
                    "Предупреждение");
                AddTask(ref tasks, ticketCount * tasksPerTicketCount - taskCount);
            }
            var tickets = FillTickets(tasks, ticketCount, tasksPerTicketCount);
            if (templatePath == null)
            {
                var newDoc = this.Application.Documents.Add();
                for (int i = 0; i < ticketCount; i++)
                {
                    var range = newDoc.Range();
                    range.InsertAfter($"Билет №{i + 1}");
                    range.InsertParagraphAfter();
                    var complexityRegex = new Regex("\\[Сложность=.*?\\]", RegexOptions.Singleline);
                    MatchCollection complexityMatches;
                    for (int j = 0; j < tickets.GetLength(1); j++)
                    {
                        tickets[i, j].Task.Copy();
                        range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                        range.InsertAfter($"[Сложность={tickets[i, j].Complexity}] ");
                        range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                        range.Paste();
                        complexityMatches = complexityRegex.Matches(range.Text);
                        range.Duplicate.Find.Execute(FindText: complexityMatches[0].Value, ReplaceWith: string.Empty);
                        range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                        range.InsertParagraph();
                    }
                }
            }
            else
            {
                var templateDoc = GetTemplateTicket(templatePath);
                BuildByTemplate(templateDoc, tickets, templatePath);
            }
        }

        public int GetTicketCountInTemplate(Word.Document templateDoc)
        {
            int counter = 0;
            var firstRangeFind = templateDoc.Range().Find;
            var secondRangeFind = templateDoc.Range().Find;
            bool numberRes, taskRes;
            while (true)
            {
                numberRes = firstRangeFind.Execute("[Номер билета]");
                taskRes = secondRangeFind.Execute("[Задания]");
                if (!(numberRes || taskRes))
                {
                    break;
                }
                if (numberRes && taskRes)
                {
                    counter++;
                }
                else if (numberRes)
                {
                    Announce?.Invoke("Не найдена метка [Задания] или существует лишння метка [Номер билета]", "Ошибка чтения шаблона");
                    templateDoc.Close();
                    return -1;
                }
                else
                {
                    Announce?.Invoke("Не найдена метка [Номер билета] или существует лишння метка [Задания]", "Ошибка чтения шаблона");
                    templateDoc.Close();
                    return -1;
                }
            }
            return counter;
        }

        void BuildByTemplate(Word.Document templateDoc, (int Complexity, Word.Range Task)[,] tickets, string templatePath)
        {
            var newDoc = this.Application.Documents.Add();
            int templateTicketCount = GetTicketCountInTemplate(templateDoc);
            int copyNumber = tickets.GetLength(0) / templateTicketCount;
            if (tickets.GetLength(0) % templateTicketCount != 0)
            {
                copyNumber++;
            }
            templateDoc.Range().Copy();
            var range = newDoc.Range();
            for (int i = 0; i < copyNumber; i++)
            {
                range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                range.Paste();
                if (templateTicketCount == 1 || templatePath != "По умолчанию")
                {
                    range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    range.InsertBreak(Word.WdBreakType.wdPageBreak);
                }
            }
            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                var f1 = newDoc.Range().Find;
                f1.Execute(FindText: "[Номер билета]", ReplaceWith: i + 1);
                var rng = newDoc.Range();
                rng.Find.Execute(FindText: "[Задания]", ReplaceWith: string.Empty);
                if (rng.ListFormat.ListTemplate != null)
                {
                    rng.ListFormat.ApplyNumberDefault();
                }
                rng.ListFormat.ApplyNumberDefault();
                var complexityRegex = new Regex("\\[Сложность=.*?\\]", RegexOptions.Singleline);
                MatchCollection complexityMatches;
                for (int j = 0; j < tickets.GetLength(1) - 1; j++)
                {
                    tickets[i, j].Task.Copy();
                    rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    rng.Paste();

                    complexityMatches = complexityRegex.Matches(rng.Text);
                    rng.Duplicate.Find.Execute(FindText: complexityMatches[0].Value, ReplaceWith: string.Empty);
                    rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                    rng.InsertParagraph();
                }
                tickets[i, tickets.GetLength(1) - 1].Task.Copy();
                rng.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                rng.Paste();
                complexityMatches = complexityRegex.Matches(rng.Text);
                rng.Find.Execute(FindText: complexityMatches[0].Value, ReplaceWith: string.Empty);
            }
            templateDoc.Close(false);
            newDoc.Activate();
        }

        public Word.Document GetTemplateTicket(string templatePath)
        {
            Word.Document templateDoc;
            if (templatePath == "По умолчанию")
            {
                string tempDocFile = Path.GetTempFileName();
                File.WriteAllBytes(tempDocFile, Properties.Settings.Default.TicketNumber == 1 ?
                    Properties.Resources.Шаблон_билета_1 : Properties.Resources.Шаблон_билета_2);
                templateDoc = this.Application.Documents.Open(tempDocFile);
            }
            else
            {
                try
                {
                    templateDoc = this.Application.Documents.Open(templatePath);
                }
                catch (Exception ex)
                {
                    Announce?.Invoke(ex.Message, "Ошибка");
                    return null;
                }
            }
            #region FindAndReplace
            while (templateDoc.Range().Find.Execute(FindText: UniversityMarker, ReplaceWith: Properties.Settings.Default.University))
            { }
            while (templateDoc.Range().Find.Execute(FindText: FacultyNameMarker, ReplaceWith: Properties.Settings.Default.FacultyName))
            { }
            while (templateDoc.Range().Find.Execute(FindText: DepartmentAbbreviationMarker, ReplaceWith: Properties.Settings.Default.DepartmentAbbreviation))
            { }
            while (templateDoc.Range().Find.Execute(FindText: DisciplineNameMarker, ReplaceWith: Properties.Settings.Default.DisciplineName))
            { }
            while (templateDoc.Range().Find.Execute(FindText: PreparationDirectionMarker, ReplaceWith: Properties.Settings.Default.PreparationDirection))
            { }
            while (templateDoc.Range().Find.Execute(FindText: CourseMarker, ReplaceWith: Properties.Settings.Default.Course))
            { }
            while (templateDoc.Range().Find.Execute(FindText: GroupsMarker, ReplaceWith: Properties.Settings.Default.Groups))
            { }
            while (templateDoc.Range().Find.Execute(FindText: TrainingFormMarker, ReplaceWith: Properties.Settings.Default.TrainingForm))
            { }
            while (templateDoc.Range().Find.Execute(FindText: DateMarker, ReplaceWith: Properties.Settings.Default.Date.ToString("«d» MMMM yyyy г.")))
            { }
            while (templateDoc.Range().Find.Execute(FindText: ProtocolNumberMarker, ReplaceWith: Properties.Settings.Default.ProtocolNumber))
            { }
            while (templateDoc.Range().Find.Execute(FindText: HardenerPositionMarker, ReplaceWith: Properties.Settings.Default.SignatoryPosition))
            { }
            while (templateDoc.Range().Find.Execute(FindText: FacultyAbbreviationMarker, ReplaceWith: Properties.Settings.Default.FacultyAbbreviation))
            { }
            while (templateDoc.Range().Find.Execute(FindText: FullNameMarker, ReplaceWith: Properties.Settings.Default.FullName))
            { }
            var range = templateDoc.Range();
            var f13 = range.Find;
            while (f13.Execute(FindText: SignatureMarker, ReplaceWith: string.Empty))
            {
                string str = Properties.Settings.Default.Signature;
                if (string.IsNullOrEmpty(str))
                {
                    break;
                }
                byte[] imageBytes = Convert.FromBase64String(str);
                string tempImageFile = Path.GetTempFileName();
                File.WriteAllBytes(tempImageFile, imageBytes);
                range.InlineShapes.AddPicture(tempImageFile);
            }
            #endregion FindAndReplace
            return templateDoc;
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            Startup += new System.EventHandler(ThisAddIn_Startup);
            Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
