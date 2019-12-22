namespace WordTicket
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.PlaceMarkersBtn = this.Factory.CreateRibbonButton();
            this.RemoveAllMarkersBtn = this.Factory.CreateRibbonButton();
            this.ScanMarkersBtn = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.TemplateName = this.Factory.CreateRibbonEditBox();
            this.OpenClearTemplateBtnGroup = this.Factory.CreateRibbonButtonGroup();
            this.ClearTemplateBtn = this.Factory.CreateRibbonButton();
            this.OpenTemplateBtn = this.Factory.CreateRibbonButton();
            this.TicketInfo = this.Factory.CreateRibbonLabel();
            this.TicketSettingsBtn = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.TicketCount = this.Factory.CreateRibbonEditBox();
            this.TasksPerTicketCount = this.Factory.CreateRibbonEditBox();
            this.MakeTicketsBtn = this.Factory.CreateRibbonButton();
            this.MakeSimpleTicketsBtn = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.SimpleTicketTemplateBtn = this.Factory.CreateRibbonButton();
            this.AdvancedTicketTemplateBtn = this.Factory.CreateRibbonButton();
            this.TwoTicketsTemplateBtn = this.Factory.CreateRibbonButton();
            this.TaskMarkersInfoBtn = this.Factory.CreateRibbonButton();
            this.TicketTemplateMarkersInfoBtn = this.Factory.CreateRibbonButton();
            this.InstructionBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.OpenClearTemplateBtnGroup.SuspendLayout();
            this.group2.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Label = "Создание билета";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.PlaceMarkersBtn);
            this.group1.Items.Add(this.RemoveAllMarkersBtn);
            this.group1.Items.Add(this.ScanMarkersBtn);
            this.group1.Label = "Разметка";
            this.group1.Name = "group1";
            // 
            // PlaceMarkersBtn
            // 
            this.PlaceMarkersBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.PlaceMarkersBtn.Image = global::WordTicket.Properties.Resources.automarking;
            this.PlaceMarkersBtn.Label = "Авторазметка";
            this.PlaceMarkersBtn.Name = "PlaceMarkersBtn";
            this.PlaceMarkersBtn.ShowImage = true;
            this.PlaceMarkersBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PlaceMarkersBtnClick);
            // 
            // RemoveAllMarkersBtn
            // 
            this.RemoveAllMarkersBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.RemoveAllMarkersBtn.Image = global::WordTicket.Properties.Resources.remove_tags;
            this.RemoveAllMarkersBtn.Label = "Удалить все метки";
            this.RemoveAllMarkersBtn.Name = "RemoveAllMarkersBtn";
            this.RemoveAllMarkersBtn.ShowImage = true;
            this.RemoveAllMarkersBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RemoveAllMarkersBtn_Click);
            // 
            // ScanMarkersBtn
            // 
            this.ScanMarkersBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ScanMarkersBtn.Image = global::WordTicket.Properties.Resources.scan_document;
            this.ScanMarkersBtn.Label = "Сканировать метки";
            this.ScanMarkersBtn.Name = "ScanMarkersBtn";
            this.ScanMarkersBtn.ShowImage = true;
            this.ScanMarkersBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ScanMarkersBtn_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.TemplateName);
            this.group3.Items.Add(this.OpenClearTemplateBtnGroup);
            this.group3.Items.Add(this.TicketInfo);
            this.group3.Items.Add(this.TicketSettingsBtn);
            this.group3.Label = "Шаблон билета";
            this.group3.Name = "group3";
            // 
            // TemplateName
            // 
            this.TemplateName.Label = "Шаблон билета";
            this.TemplateName.Name = "TemplateName";
            this.TemplateName.Text = "По умолчанию";
            this.TemplateName.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TemplateName_TextChanged);
            // 
            // OpenClearTemplateBtnGroup
            // 
            this.OpenClearTemplateBtnGroup.Items.Add(this.ClearTemplateBtn);
            this.OpenClearTemplateBtnGroup.Items.Add(this.OpenTemplateBtn);
            this.OpenClearTemplateBtnGroup.Name = "OpenClearTemplateBtnGroup";
            // 
            // ClearTemplateBtn
            // 
            this.ClearTemplateBtn.Image = global::WordTicket.Properties.Resources.reset;
            this.ClearTemplateBtn.Label = "Сброс";
            this.ClearTemplateBtn.Name = "ClearTemplateBtn";
            this.ClearTemplateBtn.ShowImage = true;
            this.ClearTemplateBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ClearTemplateBtn_Click);
            // 
            // OpenTemplateBtn
            // 
            this.OpenTemplateBtn.Image = global::WordTicket.Properties.Resources.open_template;
            this.OpenTemplateBtn.Label = "Свой шаблон...";
            this.OpenTemplateBtn.Name = "OpenTemplateBtn";
            this.OpenTemplateBtn.ShowImage = true;
            this.OpenTemplateBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenTemplateBtn_Click);
            // 
            // TicketInfo
            // 
            this.TicketInfo.Label = " ";
            this.TicketInfo.Name = "TicketInfo";
            this.TicketInfo.Visible = false;
            // 
            // TicketSettingsBtn
            // 
            this.TicketSettingsBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.TicketSettingsBtn.Image = global::WordTicket.Properties.Resources.ticket_settings;
            this.TicketSettingsBtn.Label = "Настройка билета";
            this.TicketSettingsBtn.Name = "TicketSettingsBtn";
            this.TicketSettingsBtn.ShowImage = true;
            this.TicketSettingsBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TicketSettingsBtn_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.TicketCount);
            this.group2.Items.Add(this.TasksPerTicketCount);
            this.group2.Items.Add(this.MakeTicketsBtn);
            this.group2.Items.Add(this.MakeSimpleTicketsBtn);
            this.group2.Label = "Создание билета";
            this.group2.Name = "group2";
            // 
            // TicketCount
            // 
            this.TicketCount.Label = "Кол-во билетов";
            this.TicketCount.MaxLength = 6;
            this.TicketCount.Name = "TicketCount";
            this.TicketCount.Text = "0";
            // 
            // TasksPerTicketCount
            // 
            this.TasksPerTicketCount.Label = "Кол-во заданий в билете";
            this.TasksPerTicketCount.MaxLength = 6;
            this.TasksPerTicketCount.Name = "TasksPerTicketCount";
            this.TasksPerTicketCount.Text = "0";
            // 
            // MakeTicketsBtn
            // 
            this.MakeTicketsBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.MakeTicketsBtn.Image = global::WordTicket.Properties.Resources.make_tickets;
            this.MakeTicketsBtn.Label = "Создать билеты по шаблону";
            this.MakeTicketsBtn.Name = "MakeTicketsBtn";
            this.MakeTicketsBtn.ShowImage = true;
            this.MakeTicketsBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MakeTicketsBtn_Click);
            // 
            // MakeSimpleTicketsBtn
            // 
            this.MakeSimpleTicketsBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.MakeSimpleTicketsBtn.Image = global::WordTicket.Properties.Resources.make_simple_tickets;
            this.MakeSimpleTicketsBtn.Label = "Создать билеты без шаблона";
            this.MakeSimpleTicketsBtn.Name = "MakeSimpleTicketsBtn";
            this.MakeSimpleTicketsBtn.ShowImage = true;
            this.MakeSimpleTicketsBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MakeSimpleTicketsBtn_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.menu1);
            this.group4.Items.Add(this.TaskMarkersInfoBtn);
            this.group4.Items.Add(this.TicketTemplateMarkersInfoBtn);
            this.group4.Items.Add(this.InstructionBtn);
            this.group4.Label = "Справка";
            this.group4.Name = "group4";
            // 
            // menu1
            // 
            this.menu1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Image = global::WordTicket.Properties.Resources.info;
            this.menu1.Items.Add(this.SimpleTicketTemplateBtn);
            this.menu1.Items.Add(this.AdvancedTicketTemplateBtn);
            this.menu1.Items.Add(this.TwoTicketsTemplateBtn);
            this.menu1.Label = "Примеры шаблонов билета";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // SimpleTicketTemplateBtn
            // 
            this.SimpleTicketTemplateBtn.Image = ((System.Drawing.Image)(resources.GetObject("SimpleTicketTemplateBtn.Image")));
            this.SimpleTicketTemplateBtn.Label = "Пример простого билета";
            this.SimpleTicketTemplateBtn.Name = "SimpleTicketTemplateBtn";
            this.SimpleTicketTemplateBtn.ShowImage = true;
            this.SimpleTicketTemplateBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SimpleTicketTemplateBtn_Click);
            // 
            // AdvancedTicketTemplateBtn
            // 
            this.AdvancedTicketTemplateBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdvancedTicketTemplateBtn.Image")));
            this.AdvancedTicketTemplateBtn.Label = "Пример билета с полной настройкой";
            this.AdvancedTicketTemplateBtn.Name = "AdvancedTicketTemplateBtn";
            this.AdvancedTicketTemplateBtn.ShowImage = true;
            this.AdvancedTicketTemplateBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AdvancedTicketTemplateBtn_Click);
            // 
            // TwoTicketsTemplateBtn
            // 
            this.TwoTicketsTemplateBtn.Image = global::WordTicket.Properties.Resources.some_tickets_template;
            this.TwoTicketsTemplateBtn.Label = "Пример шаблона с двумя билетами на одном листе";
            this.TwoTicketsTemplateBtn.Name = "TwoTicketsTemplateBtn";
            this.TwoTicketsTemplateBtn.ShowImage = true;
            this.TwoTicketsTemplateBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TwoTicketsTemplateBtn_Click);
            // 
            // TaskMarkersInfoBtn
            // 
            this.TaskMarkersInfoBtn.Label = "Метки для заданий";
            this.TaskMarkersInfoBtn.Name = "TaskMarkersInfoBtn";
            this.TaskMarkersInfoBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TaskMarkersInfoBtn_Click);
            // 
            // TicketTemplateMarkersInfoBtn
            // 
            this.TicketTemplateMarkersInfoBtn.Label = "Метки для шаблона билета";
            this.TicketTemplateMarkersInfoBtn.Name = "TicketTemplateMarkersInfoBtn";
            this.TicketTemplateMarkersInfoBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TicketTemplateMarkersInfoBtn_Click);
            // 
            // InstructionBtn
            // 
            this.InstructionBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InstructionBtn.Image = global::WordTicket.Properties.Resources.instruction;
            this.InstructionBtn.Label = "Инструкция";
            this.InstructionBtn.Name = "InstructionBtn";
            this.InstructionBtn.ShowImage = true;
            this.InstructionBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InstructionBtn_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.OpenClearTemplateBtnGroup.ResumeLayout(false);
            this.OpenClearTemplateBtnGroup.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton PlaceMarkers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton MakeTicketsBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton PlaceMarkersBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TicketCount;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OpenTemplateBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TemplateName;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TasksPerTicketCount;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ClearTemplateBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel TicketInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup OpenClearTemplateBtnGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TicketSettingsBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ScanMarkersBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AdvancedTicketTemplateBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SimpleTicketTemplateBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TaskMarkersInfoBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TicketTemplateMarkersInfoBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RemoveAllMarkersBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton MakeSimpleTicketsBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TwoTicketsTemplateBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InstructionBtn;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon1
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
