namespace ProjectItCompanyTimeTracking
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStripMain = new MenuStrip();
			this.menuDirectories = new ToolStripMenuItem();
			this.menuPositions = new ToolStripMenuItem();
			this.menuSpecialists = new ToolStripMenuItem();
			menuProjects = new ToolStripMenuItem();
			menuOperations = new ToolStripMenuItem();
			menuAssignments = new ToolStripMenuItem();
			menuTimeRecords = new ToolStripMenuItem();
			menuReports = new ToolStripMenuItem();
			menuStripMain.SuspendLayout();
			SuspendLayout();
			// 
			// menuStripMain
			// 
			menuStripMain.ImageScalingSize = new Size(24, 24);
			menuStripMain.Items.AddRange(new ToolStripItem[] { this.menuDirectories, menuOperations, menuReports });
			menuStripMain.Location = new Point(0, 0);
			menuStripMain.Name = "menuStripMain";
			menuStripMain.Size = new Size(800, 33);
			menuStripMain.TabIndex = 0;
			menuStripMain.Text = "menuStrip1";
			// 
			// menuDirectories
			// 
			this.menuDirectories.DropDownItems.AddRange(new ToolStripItem[] { this.menuPositions, this.menuSpecialists, this.menuProjects });
			this.menuDirectories.Name = "menuDirectories";
			this.menuDirectories.Size = new Size(139, 29);
			this.menuDirectories.Text = "Справочники";
			// 
			// menuPositions
			// 
			this.menuPositions.Name = "menuPositions";
			this.menuPositions.Size = new Size(270, 34);
			this.menuPositions.Text = "Должности";
			this.menuPositions.Click += this.menuPositions_Click;
			// 
			// menuSpecialists
			// 
			this.menuSpecialists.Name = "menuSpecialists";
			this.menuSpecialists.Size = new Size(270, 34);
			this.menuSpecialists.Text = "Специалисты";
			this.menuSpecialists.Click += this.menuSpecialists_Click;
			// 
			// menuProjects
			// 
			this.menuProjects.Name = "menuProjects";
			this.menuProjects.Size = new Size(270, 34);
			this.menuProjects.Text = "Проекты";
			this.menuProjects.Click += this.menuProjects_Click;
			// 
			// menuOperations
			// 
			menuOperations.DropDownItems.AddRange(new ToolStripItem[] { menuAssignments, menuTimeRecords });
			menuOperations.Name = "menuOperations";
			menuOperations.Size = new Size(112, 29);
			menuOperations.Text = "Операции";
			// 
			// menuAssignments
			// 
			menuAssignments.Name = "menuAssignments";
			menuAssignments.Size = new Size(301, 34);
			menuAssignments.Text = "Назначения и проекты";
			menuAssignments.Click += this.menuAssignments_Click;
			// 
			// menuTimeRecords
			// 
			menuTimeRecords.Name = "menuTimeRecords";
			menuTimeRecords.Size = new Size(301, 34);
			menuTimeRecords.Text = "Учёт времени";
			menuTimeRecords.Click += this.menuTimeRecords_Click;
			// 
			// menuReports
			// 
			menuReports.Name = "menuReports";
			menuReports.Size = new Size(88, 29);
			menuReports.Text = "Отчёты";
			menuReports.Click += this.menuReports_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStripMain);
			MainMenuStrip = menuStripMain;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Учет рабочего времени и зарплаты в IT-компании";
			menuStripMain.ResumeLayout(false);
			menuStripMain.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStripMain;
		private ToolStripMenuItem menuDirectories;
		private ToolStripMenuItem menuPositions;
		private ToolStripMenuItem menuSpecialists;
		private ToolStripMenuItem menuProjects;
		private ToolStripMenuItem menuOperations;
		private ToolStripMenuItem menuAssignments;
		private ToolStripMenuItem menuTimeRecords;
		private ToolStripMenuItem menuReports;
	}
}
