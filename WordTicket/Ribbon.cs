using Microsoft.Office.Tools.Ribbon;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WordTicket
{
    public partial class Ribbon
    {
        const string defaultTemplate = "По умолчанию";

        readonly string[] allowedExtensions = new string[] { ".doc", ".docx" };

        bool isMarkered;
        string currTemplate = defaultTemplate;
        TicketSettingsForm ticketSettingsForm;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            Globals.ThisAddIn.Announce += (msg, caption) => MessageBox.Show(msg, caption);
        }

        private void PlaceMarkersBtnClick(object sender, RibbonControlEventArgs e)
        {
            if (this.isMarkered)
            {
                var res = MessageBox.Show("Вы уже вызывали авторазметку. Вы уверены, что хотите сделать это снова?",
                    "Предупреждение", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                this.isMarkered = true;
            }
            Globals.ThisAddIn.PlaceMarkers();
        }

        private void OpenTemplateBtn_Click(object sender, RibbonControlEventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Выберите шаблон билета";
                fileDialog.Filter = "Документы Word|*.doc;*.docx|Все файлы|*.*";
                var res = fileDialog.ShowDialog();
                if (res != DialogResult.OK)
                {
                    return;
                }
                this.TemplateName.Text = fileDialog.FileName;
                this.currTemplate = fileDialog.FileName;
                if (!this.allowedExtensions.Contains(Path.GetExtension(this.currTemplate)))
                {
                    MessageBox.Show("Вы выбрали файл с неподдерживаемым расширением. " +
                        "Работа расширения может быть некорректной. Поддерживаемые расширения: " +
                        GetAllAllowedExtensions(), "Предупреждение");
                }
            }
            Word.Document templateDoc;
            try
            {
                templateDoc = Globals.ThisAddIn.Application.Documents.Open(this.currTemplate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
            int counter = Globals.ThisAddIn.GetTicketCountInTemplate(templateDoc);
            if (counter == -1)
            {
                this.TemplateName.Text = defaultTemplate;
                this.TicketInfo.Visible = false;
            }
            else
            {
                this.TicketInfo.Label = "Найдено билетов: " + counter;
                this.TicketInfo.Visible = true;
            }
            templateDoc.Close();
        }

        private void TemplateName_TextChanged(object sender, RibbonControlEventArgs e)
        {
            this.TemplateName.Text = this.currTemplate;
        }

        string GetAllAllowedExtensions()
        {
            return string.Join(", ", this.allowedExtensions);
        }

        private void ClearTemplateBtn_Click(object sender, RibbonControlEventArgs e)
        {
            this.currTemplate = defaultTemplate;
            this.TemplateName.Text = this.currTemplate;
            this.TicketInfo.Visible = false;
        }

        private void TicketSettingsBtn_Click(object sender, RibbonControlEventArgs e)
        {
            if (this.ticketSettingsForm != null && !this.ticketSettingsForm.IsDisposed)
            {
                this.ticketSettingsForm.Close();
            }
            this.ticketSettingsForm = new TicketSettingsForm();
            this.ticketSettingsForm.Show();
        }

        private void SimpleTicketTemplateBtn_Click(object sender, RibbonControlEventArgs e)
        {
            string tempDocFile = Path.GetTempFileName();
            File.WriteAllBytes(tempDocFile, Properties.Resources.Шаблон_билета_1_простой);
            Globals.ThisAddIn.Application.Documents.Open(tempDocFile);
        }

        private void AdvancedTicketTemplateBtn_Click(object sender, RibbonControlEventArgs e)
        {
            string tempDocFile = Path.GetTempFileName();
            File.WriteAllBytes(tempDocFile, Properties.Resources.Шаблон_билета_1);
            Globals.ThisAddIn.Application.Documents.Open(tempDocFile);
        }

        private void TwoTicketsTemplateBtn_Click(object sender, RibbonControlEventArgs e)
        {
            string tempDocFile = Path.GetTempFileName();
            File.WriteAllBytes(tempDocFile, Properties.Resources.Шаблон_билета_2_простой);
            Globals.ThisAddIn.Application.Documents.Open(tempDocFile);
        }

        private void TaskMarkersInfoBtn_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Обязательные метки:\n" +
                "[Начало задания] - должна стоять в начале задания\n" +
                "[Конец задания] - должна стоять в конце задания\n" +
                "[Сложность=123] - сложность задания. Данная метка должна находиться внутри задания." +
                "После знака = может стоять любое натуральное число." +
                "В зависимости от сложности сортируются задания. Если у всех заданий равная сложность, " +
                "то можно просто оставить [Сложность=1]\n\n" +
                "Пример разметки заданий:\n" +
                "[Начало задания][Сложность=3]Задание1...[Конец задания]\n" +
                "[Начало задания][Сложность=1]Задание2...[Конец задания]\n" +
                "[Начало задания][Сложность=1]Задание3...[Конец задания]", "Информация");
        }

        private void TicketTemplateMarkersInfoBtn_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Обязательные метки:\n" +
                "[Номер билета] - заменяется программой на номер билета\n" +
                "[Задания] - заменяется программой на список заданий, каждое из заданий будет на новой строке\n\n" +
                "Необязательные метки можно посмотреть в примере билета с полной настройкой. " +
                "Необязательные метки заменяются в настройках билета", "Информация");
        }

        private void ScanMarkersBtn_Click(object sender, RibbonControlEventArgs e)
        {
            var tasks = Globals.ThisAddIn.GetTasksAndComplexity();
            if (tasks == null)
            {
                MessageBox.Show("Задания не найдены", "Ошибка");
                return;
            }
            Array.Sort(tasks, (first, second) => first.Complexity.CompareTo(second.Complexity));
            string res = $"Всего заданий: {Globals.ThisAddIn.GetTaskCount(tasks)}";
            foreach (var (complexity, t) in tasks)
            {
                res += $"\nЗаданий сложностью {complexity}: {t.Count}";
            }
            MessageBox.Show(res, "Результат сканирования");
        }

        private void RemoveAllMarkersBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.RemoveAllMarkers();
        }

        private void MakeSimpleTicketsBtn_Click(object sender, RibbonControlEventArgs e)
        {
            if (!this.isMarkered)
            {
                var res = MessageBox.Show("Вы ещё не использовали авторазметку. Вы уверены, что разметка проставлена?",
                    "Предупреждение", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                {
                    return;
                }
                this.isMarkered = true;
            }
            if (int.TryParse(this.TicketCount.Text, out int ticketCount)
                && int.TryParse(this.TasksPerTicketCount.Text, out int tasksPerTicketCount))
            {
                Globals.ThisAddIn.MakeTickets(ticketCount, tasksPerTicketCount, null);
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте правильность ввода числа билетов и числа заданий в билете", "Ошибка");
            }
        }

        private void MakeTicketsBtn_Click(object sender, RibbonControlEventArgs e)
        {
            if (!this.isMarkered)
            {
                var res = MessageBox.Show("Вы ещё не использовали авторазметку. Вы уверены, что разметка проставлена?",
                    "Предупреждение", MessageBoxButtons.YesNo);
                if (res != DialogResult.Yes)
                {
                    return;
                }
                this.isMarkered = true;
            }
            if (int.TryParse(this.TicketCount.Text, out int ticketCount)
                && int.TryParse(this.TasksPerTicketCount.Text, out int tasksPerTicketCount))
            {
                Globals.ThisAddIn.MakeTickets(ticketCount, tasksPerTicketCount, this.currTemplate);
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте правильность ввода числа билетов и числа заданий в билете", "Ошибка");
            }
        }

        private void InstructionBtn_Click(object sender, RibbonControlEventArgs e)
        {
            string tempDocFile = Path.GetTempFileName();
            tempDocFile = Path.ChangeExtension(tempDocFile, ".pdf");
            File.WriteAllBytes(tempDocFile, Properties.Resources.Инструкция);
            try
            {
                Process.Start(tempDocFile);
            }
            catch (Exception)
            {
                try
                {
                    var startInfo = new ProcessStartInfo()
                    {
                        WindowStyle = ProcessWindowStyle.Normal,
                        FileName = tempDocFile,
                        Verb = "openas",
                        UseShellExecute = true,
                        ErrorDialog = true
                    };
                    Process.Start(startInfo);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
