namespace Tyuiu.ZhanabaevTA.Sprint7.Project.V14
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip_ZTA = new MenuStrip();
            ToolStripMenuItemTable_ZTA = new ToolStripMenuItem();
            ToolStripMenuItemOpenTable_ZTA = new ToolStripMenuItem();
            ToolStripMenuItemSaveFile_ZTA = new ToolStripMenuItem();
            ToolStripMenuItemGuide_ZTA = new ToolStripMenuItem();
            ToolStripMenuItemInformation_ZTA = new ToolStripMenuItem();
            toolStrip_ZTA = new ToolStrip();
            splitContainerOutput_ZTA = new SplitContainer();
            groupBoxTable_ZTA = new GroupBox();
            dataGridViewTable_ZTA = new DataGridView();
            groupBoxOutput_ZTA = new GroupBox();
            labelCalculateResult_ZTA = new Label();
            textBoxCalculateResult_ZTA = new TextBox();
            labelChart_ZTA = new Label();
            chartTable_ZTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip_ZTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_ZTA).BeginInit();
            splitContainerOutput_ZTA.Panel1.SuspendLayout();
            splitContainerOutput_ZTA.Panel2.SuspendLayout();
            splitContainerOutput_ZTA.SuspendLayout();
            groupBoxTable_ZTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_ZTA).BeginInit();
            groupBoxOutput_ZTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTable_ZTA).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_ZTA
            // 
            menuStrip_ZTA.BackColor = SystemColors.MenuBar;
            menuStrip_ZTA.ImageScalingSize = new Size(20, 20);
            menuStrip_ZTA.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemTable_ZTA, ToolStripMenuItemGuide_ZTA, ToolStripMenuItemInformation_ZTA });
            menuStrip_ZTA.Location = new Point(0, 0);
            menuStrip_ZTA.Name = "menuStrip_ZTA";
            menuStrip_ZTA.Size = new Size(1059, 28);
            menuStrip_ZTA.TabIndex = 0;
            // 
            // ToolStripMenuItemTable_ZTA
            // 
            ToolStripMenuItemTable_ZTA.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemOpenTable_ZTA, ToolStripMenuItemSaveFile_ZTA });
            ToolStripMenuItemTable_ZTA.Name = "ToolStripMenuItemTable_ZTA";
            ToolStripMenuItemTable_ZTA.Size = new Size(82, 24);
            ToolStripMenuItemTable_ZTA.Text = "Таблица";
            // 
            // ToolStripMenuItemOpenTable_ZTA
            // 
            ToolStripMenuItemOpenTable_ZTA.Name = "ToolStripMenuItemOpenTable_ZTA";
            ToolStripMenuItemOpenTable_ZTA.Size = new Size(224, 26);
            ToolStripMenuItemOpenTable_ZTA.Text = "Открыть";
            // 
            // ToolStripMenuItemSaveFile_ZTA
            // 
            ToolStripMenuItemSaveFile_ZTA.Name = "ToolStripMenuItemSaveFile_ZTA";
            ToolStripMenuItemSaveFile_ZTA.Size = new Size(224, 26);
            ToolStripMenuItemSaveFile_ZTA.Text = "Сохранить";
            // 
            // ToolStripMenuItemGuide_ZTA
            // 
            ToolStripMenuItemGuide_ZTA.Name = "ToolStripMenuItemGuide_ZTA";
            ToolStripMenuItemGuide_ZTA.Size = new Size(209, 24);
            ToolStripMenuItemGuide_ZTA.Text = "Руководство пользователя";
            // 
            // ToolStripMenuItemInformation_ZTA
            // 
            ToolStripMenuItemInformation_ZTA.Name = "ToolStripMenuItemInformation_ZTA";
            ToolStripMenuItemInformation_ZTA.Size = new Size(118, 24);
            ToolStripMenuItemInformation_ZTA.Text = "О программе";
            // 
            // toolStrip_ZTA
            // 
            toolStrip_ZTA.BackColor = SystemColors.HotTrack;
            toolStrip_ZTA.ImageScalingSize = new Size(20, 20);
            toolStrip_ZTA.Location = new Point(0, 28);
            toolStrip_ZTA.Name = "toolStrip_ZTA";
            toolStrip_ZTA.Size = new Size(1059, 25);
            toolStrip_ZTA.TabIndex = 1;
            toolStrip_ZTA.Text = "toolStrip1";
            // 
            // splitContainerOutput_ZTA
            // 
            splitContainerOutput_ZTA.Dock = DockStyle.Fill;
            splitContainerOutput_ZTA.Location = new Point(0, 53);
            splitContainerOutput_ZTA.Name = "splitContainerOutput_ZTA";
            // 
            // splitContainerOutput_ZTA.Panel1
            // 
            splitContainerOutput_ZTA.Panel1.BackColor = SystemColors.Control;
            splitContainerOutput_ZTA.Panel1.Controls.Add(groupBoxTable_ZTA);
            splitContainerOutput_ZTA.Panel1.Padding = new Padding(5);
            // 
            // splitContainerOutput_ZTA.Panel2
            // 
            splitContainerOutput_ZTA.Panel2.BackColor = SystemColors.Control;
            splitContainerOutput_ZTA.Panel2.Controls.Add(groupBoxOutput_ZTA);
            splitContainerOutput_ZTA.Panel2.Padding = new Padding(5);
            splitContainerOutput_ZTA.Size = new Size(1059, 539);
            splitContainerOutput_ZTA.SplitterDistance = 737;
            splitContainerOutput_ZTA.TabIndex = 2;
            // 
            // groupBoxTable_ZTA
            // 
            groupBoxTable_ZTA.Controls.Add(dataGridViewTable_ZTA);
            groupBoxTable_ZTA.Dock = DockStyle.Fill;
            groupBoxTable_ZTA.Location = new Point(5, 5);
            groupBoxTable_ZTA.Name = "groupBoxTable_ZTA";
            groupBoxTable_ZTA.Padding = new Padding(5);
            groupBoxTable_ZTA.Size = new Size(727, 529);
            groupBoxTable_ZTA.TabIndex = 0;
            groupBoxTable_ZTA.TabStop = false;
            groupBoxTable_ZTA.Text = "None";
            // 
            // dataGridViewTable_ZTA
            // 
            dataGridViewTable_ZTA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_ZTA.Dock = DockStyle.Fill;
            dataGridViewTable_ZTA.Location = new Point(5, 25);
            dataGridViewTable_ZTA.Name = "dataGridViewTable_ZTA";
            dataGridViewTable_ZTA.RowHeadersWidth = 51;
            dataGridViewTable_ZTA.Size = new Size(717, 499);
            dataGridViewTable_ZTA.TabIndex = 0;
            // 
            // groupBoxOutput_ZTA
            // 
            groupBoxOutput_ZTA.Controls.Add(labelCalculateResult_ZTA);
            groupBoxOutput_ZTA.Controls.Add(textBoxCalculateResult_ZTA);
            groupBoxOutput_ZTA.Controls.Add(labelChart_ZTA);
            groupBoxOutput_ZTA.Controls.Add(chartTable_ZTA);
            groupBoxOutput_ZTA.Dock = DockStyle.Fill;
            groupBoxOutput_ZTA.Location = new Point(5, 5);
            groupBoxOutput_ZTA.Name = "groupBoxOutput_ZTA";
            groupBoxOutput_ZTA.Padding = new Padding(5);
            groupBoxOutput_ZTA.Size = new Size(308, 529);
            groupBoxOutput_ZTA.TabIndex = 0;
            groupBoxOutput_ZTA.TabStop = false;
            groupBoxOutput_ZTA.Text = "Вывод данных";
            // 
            // labelCalculateResult_ZTA
            // 
            labelCalculateResult_ZTA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelCalculateResult_ZTA.AutoSize = true;
            labelCalculateResult_ZTA.Location = new Point(3, 280);
            labelCalculateResult_ZTA.Name = "labelCalculateResult_ZTA";
            labelCalculateResult_ZTA.Size = new Size(78, 20);
            labelCalculateResult_ZTA.TabIndex = 7;
            labelCalculateResult_ZTA.Text = "Результат:";
            // 
            // textBoxCalculateResult_ZTA
            // 
            textBoxCalculateResult_ZTA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCalculateResult_ZTA.Location = new Point(5, 303);
            textBoxCalculateResult_ZTA.Multiline = true;
            textBoxCalculateResult_ZTA.Name = "textBoxCalculateResult_ZTA";
            textBoxCalculateResult_ZTA.ReadOnly = true;
            textBoxCalculateResult_ZTA.ScrollBars = ScrollBars.Vertical;
            textBoxCalculateResult_ZTA.Size = new Size(298, 221);
            textBoxCalculateResult_ZTA.TabIndex = 6;
            // 
            // labelChart_ZTA
            // 
            labelChart_ZTA.AutoSize = true;
            labelChart_ZTA.BackColor = SystemColors.ControlLightLight;
            labelChart_ZTA.Location = new Point(5, 25);
            labelChart_ZTA.Name = "labelChart_ZTA";
            labelChart_ZTA.Size = new Size(92, 20);
            labelChart_ZTA.TabIndex = 5;
            labelChart_ZTA.Text = "Диаграмма:";
            // 
            // chartTable_ZTA
            // 
            chartArea1.Name = "ChartArea1";
            chartTable_ZTA.ChartAreas.Add(chartArea1);
            chartTable_ZTA.Dock = DockStyle.Top;
            legend1.Name = "Legend1";
            chartTable_ZTA.Legends.Add(legend1);
            chartTable_ZTA.Location = new Point(5, 25);
            chartTable_ZTA.Name = "chartTable_ZTA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTable_ZTA.Series.Add(series1);
            chartTable_ZTA.Size = new Size(298, 252);
            chartTable_ZTA.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1059, 592);
            Controls.Add(splitContainerOutput_ZTA);
            Controls.Add(toolStrip_ZTA);
            Controls.Add(menuStrip_ZTA);
            MainMenuStrip = menuStrip_ZTA;
            Name = "FormMain";
            Text = "Городской транспорт";
            menuStrip_ZTA.ResumeLayout(false);
            menuStrip_ZTA.PerformLayout();
            splitContainerOutput_ZTA.Panel1.ResumeLayout(false);
            splitContainerOutput_ZTA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_ZTA).EndInit();
            splitContainerOutput_ZTA.ResumeLayout(false);
            groupBoxTable_ZTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_ZTA).EndInit();
            groupBoxOutput_ZTA.ResumeLayout(false);
            groupBoxOutput_ZTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTable_ZTA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_ZTA;
        private ToolStrip toolStrip_ZTA;
        private SplitContainer splitContainerOutput_ZTA;
        private ToolStripMenuItem ToolStripMenuItemTable_ZTA;
        private ToolStripMenuItem ToolStripMenuItemOpenTable_ZTA;
        private ToolStripMenuItem ToolStripMenuItemSaveFile_ZTA;
        private ToolStripMenuItem ToolStripMenuItemGuide_ZTA;
        private ToolStripMenuItem ToolStripMenuItemInformation_ZTA;
        private GroupBox groupBoxTable_ZTA;
        private GroupBox groupBoxOutput_ZTA;
        private DataGridView dataGridViewTable_ZTA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTable_ZTA;
        private Label labelChart_ZTA;
        private Label labelCalculateResult_ZTA;
        private TextBox textBoxCalculateResult_ZTA;
    }
}
