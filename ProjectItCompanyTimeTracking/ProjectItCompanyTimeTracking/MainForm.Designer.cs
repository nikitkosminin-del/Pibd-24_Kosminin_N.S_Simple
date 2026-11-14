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
			menuDirectories = new ToolStripMenuItem();
			menuPositions = new ToolStripMenuItem();
			menuSpecialists = new ToolStripMenuItem();
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
			menuStripMain.Items.AddRange(new ToolStripItem[] { menuDirectories, menuOperations, menuReports });
			menuStripMain.Location = new Point(0, 0);
			menuStripMain.Name = "menuStripMain";
			menuStripMain.Size = new Size(800, 33);
			menuStripMain.TabIndex = 0;
			menuStripMain.Text = "menuStrip1";
			// 
			// menuDirectories
			// 
			menuDirectories.DropDownItems.AddRange(new ToolStripItem[] { menuPositions, menuSpecialists, menuProjects });
			menuDirectories.Name = "menuDirectories";
			menuDirectories.Size = new Size(139, 29);
			menuDirectories.Text = "Справочники";
			// 
			// menuPositions
			// 
			menuPositions.Name = "menuPositions";
			menuPositions.Size = new Size(221, 34);
			menuPositions.Text = "Должности";
			menuPositions.Click += menuPositions_Click;
			// 
			// menuSpecialists
			// 
			menuSpecialists.Name = "menuSpecialists";
			menuSpecialists.Size = new Size(221, 34);
			menuSpecialists.Text = "Специалисты";
			menuSpecialists.Click += menuSpecialists_Click;
			// 
			// menuProjects
			// 
			menuProjects.Name = "menuProjects";
			menuProjects.Size = new Size(221, 34);
			menuProjects.Text = "Проекты";
			menuProjects.Click += menuProjects_Click;
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
			menuAssignments.Click += menuAssignments_Click;
			// 
			// menuTimeRecords
			// 
			menuTimeRecords.Name = "menuTimeRecords";
			menuTimeRecords.Size = new Size(301, 34);
			menuTimeRecords.Text = "Учёт времени";
			menuTimeRecords.Click += menuTimeRecords_Click;
			// 
			// menuReports
			// 
			menuReports.Name = "menuReports";
			menuReports.Size = new Size(88, 29);
			menuReports.Text = "Отчёты";
			menuReports.Click += menuReports_Click;
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
