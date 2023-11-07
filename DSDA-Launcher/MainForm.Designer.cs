
namespace DSDA_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.settings_group_box = new System.Windows.Forms.GroupBox();
            this.settings_table = new System.Windows.Forms.TableLayoutPanel();
            this.settings_label_application = new System.Windows.Forms.Label();
            this.settings_input_application = new System.Windows.Forms.TextBox();
            this.settings_button_application = new System.Windows.Forms.Button();
            this.settings_label_iwad = new System.Windows.Forms.Label();
            this.settings_label_pwad = new System.Windows.Forms.Label();
            this.settings_input_iwad = new System.Windows.Forms.TextBox();
            this.settings_input_pwad = new System.Windows.Forms.TextBox();
            this.settings_button_iwad = new System.Windows.Forms.Button();
            this.settings_button_pwad = new System.Windows.Forms.Button();
            this.button_launch = new System.Windows.Forms.Button();
            this.parameters_group_box = new System.Windows.Forms.GroupBox();
            this.parameters_table_additional = new System.Windows.Forms.TableLayoutPanel();
            this.parameters_label_additional = new System.Windows.Forms.Label();
            this.parameters_input_additional = new System.Windows.Forms.TextBox();
            this.parameters_table_main = new System.Windows.Forms.TableLayoutPanel();
            this.parameters_label_skill = new System.Windows.Forms.Label();
            this.parameters_label_comp = new System.Windows.Forms.Label();
            this.parameters_label_warp = new System.Windows.Forms.Label();
            this.parameters_combo_box_skill = new System.Windows.Forms.ComboBox();
            this.parameters_combo_box_comp = new System.Windows.Forms.ComboBox();
            this.parameters_input_warp = new System.Windows.Forms.TextBox();
            this.parameters_checkbox_shorttics = new System.Windows.Forms.CheckBox();
            this.parameters_checkbox_nomo = new System.Windows.Forms.CheckBox();
            this.parameters_checkbox_nomusic = new System.Windows.Forms.CheckBox();
            this.demos_group_box = new System.Windows.Forms.GroupBox();
            this.demos_table = new System.Windows.Forms.TableLayoutPanel();
            this.demos_label_location = new System.Windows.Forms.Label();
            this.demos_button_browse = new System.Windows.Forms.Button();
            this.demos_input_location = new System.Windows.Forms.TextBox();
            this.demos_label_name = new System.Windows.Forms.Label();
            this.demos_input_name = new System.Windows.Forms.TextBox();
            this.demos_checkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.settings_group_box.SuspendLayout();
            this.settings_table.SuspendLayout();
            this.parameters_group_box.SuspendLayout();
            this.parameters_table_additional.SuspendLayout();
            this.parameters_table_main.SuspendLayout();
            this.demos_group_box.SuspendLayout();
            this.demos_table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_group_box
            // 
            this.settings_group_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_group_box.Controls.Add(this.settings_table);
            this.settings_group_box.Location = new System.Drawing.Point(12, 5);
            this.settings_group_box.Name = "settings_group_box";
            this.settings_group_box.Size = new System.Drawing.Size(439, 120);
            this.settings_group_box.TabIndex = 0;
            this.settings_group_box.TabStop = false;
            this.settings_group_box.Text = "Settings";
            // 
            // settings_table
            // 
            this.settings_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_table.ColumnCount = 3;
            this.settings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37089F));
            this.settings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.28638F));
            this.settings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.10798F));
            this.settings_table.Controls.Add(this.settings_label_application, 0, 0);
            this.settings_table.Controls.Add(this.settings_input_application, 1, 0);
            this.settings_table.Controls.Add(this.settings_button_application, 2, 0);
            this.settings_table.Controls.Add(this.settings_label_iwad, 0, 1);
            this.settings_table.Controls.Add(this.settings_label_pwad, 0, 2);
            this.settings_table.Controls.Add(this.settings_input_iwad, 1, 1);
            this.settings_table.Controls.Add(this.settings_input_pwad, 1, 2);
            this.settings_table.Controls.Add(this.settings_button_iwad, 2, 1);
            this.settings_table.Controls.Add(this.settings_button_pwad, 2, 2);
            this.settings_table.Location = new System.Drawing.Point(7, 22);
            this.settings_table.Name = "settings_table";
            this.settings_table.RowCount = 3;
            this.settings_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settings_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settings_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settings_table.Size = new System.Drawing.Size(426, 88);
            this.settings_table.TabIndex = 0;
            // 
            // settings_label_application
            // 
            this.settings_label_application.AutoSize = true;
            this.settings_label_application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_label_application.Location = new System.Drawing.Point(3, 0);
            this.settings_label_application.Name = "settings_label_application";
            this.settings_label_application.Size = new System.Drawing.Size(68, 29);
            this.settings_label_application.TabIndex = 0;
            this.settings_label_application.Text = "Application";
            this.settings_label_application.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settings_input_application
            // 
            this.settings_input_application.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_input_application.Location = new System.Drawing.Point(77, 3);
            this.settings_input_application.Name = "settings_input_application";
            this.settings_input_application.Size = new System.Drawing.Size(221, 23);
            this.settings_input_application.TabIndex = 1;
            // 
            // settings_button_application
            // 
            this.settings_button_application.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button_application.Location = new System.Drawing.Point(304, 3);
            this.settings_button_application.Name = "settings_button_application";
            this.settings_button_application.Size = new System.Drawing.Size(119, 23);
            this.settings_button_application.TabIndex = 2;
            this.settings_button_application.Text = "Browse Application";
            this.settings_button_application.UseVisualStyleBackColor = true;
            this.settings_button_application.Click += new System.EventHandler(this.settings_button_application_Click);
            // 
            // settings_label_iwad
            // 
            this.settings_label_iwad.AutoSize = true;
            this.settings_label_iwad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_label_iwad.Location = new System.Drawing.Point(3, 29);
            this.settings_label_iwad.Name = "settings_label_iwad";
            this.settings_label_iwad.Size = new System.Drawing.Size(68, 29);
            this.settings_label_iwad.TabIndex = 3;
            this.settings_label_iwad.Text = "IWAD";
            this.settings_label_iwad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settings_label_pwad
            // 
            this.settings_label_pwad.AutoSize = true;
            this.settings_label_pwad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_label_pwad.Location = new System.Drawing.Point(3, 58);
            this.settings_label_pwad.Name = "settings_label_pwad";
            this.settings_label_pwad.Size = new System.Drawing.Size(68, 30);
            this.settings_label_pwad.TabIndex = 4;
            this.settings_label_pwad.Text = "PWAD";
            this.settings_label_pwad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settings_input_iwad
            // 
            this.settings_input_iwad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_input_iwad.Location = new System.Drawing.Point(77, 32);
            this.settings_input_iwad.Name = "settings_input_iwad";
            this.settings_input_iwad.Size = new System.Drawing.Size(221, 23);
            this.settings_input_iwad.TabIndex = 5;
            // 
            // settings_input_pwad
            // 
            this.settings_input_pwad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_input_pwad.Location = new System.Drawing.Point(77, 61);
            this.settings_input_pwad.Name = "settings_input_pwad";
            this.settings_input_pwad.Size = new System.Drawing.Size(221, 23);
            this.settings_input_pwad.TabIndex = 6;
            // 
            // settings_button_iwad
            // 
            this.settings_button_iwad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button_iwad.Location = new System.Drawing.Point(304, 32);
            this.settings_button_iwad.Name = "settings_button_iwad";
            this.settings_button_iwad.Size = new System.Drawing.Size(119, 22);
            this.settings_button_iwad.TabIndex = 7;
            this.settings_button_iwad.Text = "Browse IWAD";
            this.settings_button_iwad.UseVisualStyleBackColor = true;
            this.settings_button_iwad.Click += new System.EventHandler(this.settings_button_iwad_Click);
            // 
            // settings_button_pwad
            // 
            this.settings_button_pwad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button_pwad.Location = new System.Drawing.Point(304, 61);
            this.settings_button_pwad.Name = "settings_button_pwad";
            this.settings_button_pwad.Size = new System.Drawing.Size(119, 23);
            this.settings_button_pwad.TabIndex = 8;
            this.settings_button_pwad.Text = "Browse PWAD";
            this.settings_button_pwad.UseVisualStyleBackColor = true;
            this.settings_button_pwad.Click += new System.EventHandler(this.settings_button_pwad_Click);
            // 
            // button_launch
            // 
            this.button_launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_launch.Location = new System.Drawing.Point(288, 400);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(164, 30);
            this.button_launch.TabIndex = 2;
            this.button_launch.Text = "Launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // parameters_group_box
            // 
            this.parameters_group_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_group_box.Controls.Add(this.parameters_table_additional);
            this.parameters_group_box.Controls.Add(this.parameters_table_main);
            this.parameters_group_box.Location = new System.Drawing.Point(12, 128);
            this.parameters_group_box.Name = "parameters_group_box";
            this.parameters_group_box.Size = new System.Drawing.Size(439, 153);
            this.parameters_group_box.TabIndex = 3;
            this.parameters_group_box.TabStop = false;
            this.parameters_group_box.Text = "Parameters";
            // 
            // parameters_table_additional
            // 
            this.parameters_table_additional.ColumnCount = 2;
            this.parameters_table_additional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.44497F));
            this.parameters_table_additional.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.55504F));
            this.parameters_table_additional.Controls.Add(this.parameters_label_additional, 0, 0);
            this.parameters_table_additional.Controls.Add(this.parameters_input_additional, 1, 0);
            this.parameters_table_additional.Location = new System.Drawing.Point(6, 113);
            this.parameters_table_additional.Name = "parameters_table_additional";
            this.parameters_table_additional.RowCount = 1;
            this.parameters_table_additional.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parameters_table_additional.Size = new System.Drawing.Size(427, 29);
            this.parameters_table_additional.TabIndex = 3;
            // 
            // parameters_label_additional
            // 
            this.parameters_label_additional.AutoSize = true;
            this.parameters_label_additional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_label_additional.Location = new System.Drawing.Point(3, 0);
            this.parameters_label_additional.Name = "parameters_label_additional";
            this.parameters_label_additional.Size = new System.Drawing.Size(124, 29);
            this.parameters_label_additional.TabIndex = 1;
            this.parameters_label_additional.Text = "Additional Parameters";
            this.parameters_label_additional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parameters_input_additional
            // 
            this.parameters_input_additional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_input_additional.Location = new System.Drawing.Point(133, 3);
            this.parameters_input_additional.Name = "parameters_input_additional";
            this.parameters_input_additional.PlaceholderText = "-fast -respawn";
            this.parameters_input_additional.Size = new System.Drawing.Size(291, 23);
            this.parameters_input_additional.TabIndex = 2;
            // 
            // parameters_table_main
            // 
            this.parameters_table_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_table_main.ColumnCount = 4;
            this.parameters_table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.parameters_table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.parameters_table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.parameters_table_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.parameters_table_main.Controls.Add(this.parameters_label_skill, 0, 0);
            this.parameters_table_main.Controls.Add(this.parameters_label_comp, 0, 1);
            this.parameters_table_main.Controls.Add(this.parameters_label_warp, 0, 2);
            this.parameters_table_main.Controls.Add(this.parameters_combo_box_skill, 1, 0);
            this.parameters_table_main.Controls.Add(this.parameters_combo_box_comp, 1, 1);
            this.parameters_table_main.Controls.Add(this.parameters_input_warp, 1, 2);
            this.parameters_table_main.Controls.Add(this.parameters_checkbox_shorttics, 2, 1);
            this.parameters_table_main.Controls.Add(this.parameters_checkbox_nomo, 2, 0);
            this.parameters_table_main.Controls.Add(this.parameters_checkbox_nomusic, 3, 0);
            this.parameters_table_main.Location = new System.Drawing.Point(6, 22);
            this.parameters_table_main.Name = "parameters_table_main";
            this.parameters_table_main.RowCount = 3;
            this.parameters_table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.parameters_table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.parameters_table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.parameters_table_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.parameters_table_main.Size = new System.Drawing.Size(427, 88);
            this.parameters_table_main.TabIndex = 0;
            // 
            // parameters_label_skill
            // 
            this.parameters_label_skill.AutoSize = true;
            this.parameters_label_skill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_label_skill.Location = new System.Drawing.Point(3, 0);
            this.parameters_label_skill.Name = "parameters_label_skill";
            this.parameters_label_skill.Size = new System.Drawing.Size(80, 29);
            this.parameters_label_skill.TabIndex = 0;
            this.parameters_label_skill.Text = "Skill";
            this.parameters_label_skill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // parameters_label_comp
            // 
            this.parameters_label_comp.AutoSize = true;
            this.parameters_label_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_label_comp.Location = new System.Drawing.Point(3, 29);
            this.parameters_label_comp.Name = "parameters_label_comp";
            this.parameters_label_comp.Size = new System.Drawing.Size(80, 29);
            this.parameters_label_comp.TabIndex = 1;
            this.parameters_label_comp.Text = "Compatibility";
            this.parameters_label_comp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // parameters_label_warp
            // 
            this.parameters_label_warp.AutoSize = true;
            this.parameters_label_warp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_label_warp.Location = new System.Drawing.Point(3, 58);
            this.parameters_label_warp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.parameters_label_warp.Name = "parameters_label_warp";
            this.parameters_label_warp.Size = new System.Drawing.Size(80, 27);
            this.parameters_label_warp.TabIndex = 2;
            this.parameters_label_warp.Text = "Warp";
            this.parameters_label_warp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // parameters_combo_box_skill
            // 
            this.parameters_combo_box_skill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_combo_box_skill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameters_combo_box_skill.FormattingEnabled = true;
            this.parameters_combo_box_skill.Items.AddRange(new object[] {
            "1 - I\'m too young to die",
            "2 - Hey, not too rough",
            "3 - Hurt me plenty",
            "4 - Ultra violence",
            "5 - Nightmare!"});
            this.parameters_combo_box_skill.Location = new System.Drawing.Point(89, 3);
            this.parameters_combo_box_skill.Name = "parameters_combo_box_skill";
            this.parameters_combo_box_skill.Size = new System.Drawing.Size(151, 23);
            this.parameters_combo_box_skill.TabIndex = 3;
            // 
            // parameters_combo_box_comp
            // 
            this.parameters_combo_box_comp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_combo_box_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameters_combo_box_comp.FormattingEnabled = true;
            this.parameters_combo_box_comp.Items.AddRange(new object[] {
            "2 - Doom II",
            "3 - Ultimate Doom",
            "4 - Final Doom",
            "9 - Boom",
            "11 - MBF",
            "21 - MBF21"});
            this.parameters_combo_box_comp.Location = new System.Drawing.Point(89, 32);
            this.parameters_combo_box_comp.Name = "parameters_combo_box_comp";
            this.parameters_combo_box_comp.Size = new System.Drawing.Size(151, 23);
            this.parameters_combo_box_comp.TabIndex = 4;
            // 
            // parameters_input_warp
            // 
            this.parameters_input_warp.Location = new System.Drawing.Point(89, 61);
            this.parameters_input_warp.MaxLength = 2;
            this.parameters_input_warp.Name = "parameters_input_warp";
            this.parameters_input_warp.PlaceholderText = "01";
            this.parameters_input_warp.Size = new System.Drawing.Size(35, 23);
            this.parameters_input_warp.TabIndex = 5;
            // 
            // parameters_checkbox_shorttics
            // 
            this.parameters_checkbox_shorttics.AutoSize = true;
            this.parameters_checkbox_shorttics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_checkbox_shorttics.Location = new System.Drawing.Point(246, 32);
            this.parameters_checkbox_shorttics.Name = "parameters_checkbox_shorttics";
            this.parameters_checkbox_shorttics.Size = new System.Drawing.Size(94, 23);
            this.parameters_checkbox_shorttics.TabIndex = 6;
            this.parameters_checkbox_shorttics.Text = "Short Tics";
            this.parameters_checkbox_shorttics.UseVisualStyleBackColor = true;
            // 
            // parameters_checkbox_nomo
            // 
            this.parameters_checkbox_nomo.AutoSize = true;
            this.parameters_checkbox_nomo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_checkbox_nomo.Location = new System.Drawing.Point(246, 3);
            this.parameters_checkbox_nomo.Name = "parameters_checkbox_nomo";
            this.parameters_checkbox_nomo.Size = new System.Drawing.Size(94, 23);
            this.parameters_checkbox_nomo.TabIndex = 7;
            this.parameters_checkbox_nomo.Text = "No Monsters";
            this.parameters_checkbox_nomo.UseVisualStyleBackColor = true;
            // 
            // parameters_checkbox_nomusic
            // 
            this.parameters_checkbox_nomusic.AutoSize = true;
            this.parameters_checkbox_nomusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameters_checkbox_nomusic.Location = new System.Drawing.Point(346, 3);
            this.parameters_checkbox_nomusic.Name = "parameters_checkbox_nomusic";
            this.parameters_checkbox_nomusic.Size = new System.Drawing.Size(78, 23);
            this.parameters_checkbox_nomusic.TabIndex = 8;
            this.parameters_checkbox_nomusic.Text = "No Music";
            this.parameters_checkbox_nomusic.UseVisualStyleBackColor = true;
            // 
            // demos_group_box
            // 
            this.demos_group_box.Controls.Add(this.demos_table);
            this.demos_group_box.Controls.Add(this.demos_checkbox);
            this.demos_group_box.Location = new System.Drawing.Point(12, 283);
            this.demos_group_box.Name = "demos_group_box";
            this.demos_group_box.Size = new System.Drawing.Size(439, 111);
            this.demos_group_box.TabIndex = 4;
            this.demos_group_box.TabStop = false;
            this.demos_group_box.Text = "Demos";
            // 
            // demos_table
            // 
            this.demos_table.ColumnCount = 3;
            this.demos_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.demos_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.demos_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.demos_table.Controls.Add(this.demos_label_location, 0, 1);
            this.demos_table.Controls.Add(this.demos_button_browse, 2, 1);
            this.demos_table.Controls.Add(this.demos_input_location, 1, 1);
            this.demos_table.Controls.Add(this.demos_label_name, 0, 0);
            this.demos_table.Controls.Add(this.demos_input_name, 1, 0);
            this.demos_table.Location = new System.Drawing.Point(6, 42);
            this.demos_table.Name = "demos_table";
            this.demos_table.RowCount = 2;
            this.demos_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.demos_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.demos_table.Size = new System.Drawing.Size(427, 57);
            this.demos_table.TabIndex = 1;
            // 
            // demos_label_location
            // 
            this.demos_label_location.AutoSize = true;
            this.demos_label_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demos_label_location.Location = new System.Drawing.Point(3, 28);
            this.demos_label_location.Name = "demos_label_location";
            this.demos_label_location.Size = new System.Drawing.Size(56, 29);
            this.demos_label_location.TabIndex = 0;
            this.demos_label_location.Text = "Location";
            this.demos_label_location.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // demos_button_browse
            // 
            this.demos_button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demos_button_browse.Location = new System.Drawing.Point(328, 31);
            this.demos_button_browse.Name = "demos_button_browse";
            this.demos_button_browse.Size = new System.Drawing.Size(96, 23);
            this.demos_button_browse.TabIndex = 2;
            this.demos_button_browse.Text = "Browse";
            this.demos_button_browse.UseVisualStyleBackColor = true;
            this.demos_button_browse.Click += new System.EventHandler(this.demos_button_browse_Click);
            // 
            // demos_input_location
            // 
            this.demos_input_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demos_input_location.Location = new System.Drawing.Point(65, 31);
            this.demos_input_location.Name = "demos_input_location";
            this.demos_input_location.Size = new System.Drawing.Size(257, 23);
            this.demos_input_location.TabIndex = 1;
            // 
            // demos_label_name
            // 
            this.demos_label_name.AutoSize = true;
            this.demos_label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demos_label_name.Location = new System.Drawing.Point(3, 0);
            this.demos_label_name.Name = "demos_label_name";
            this.demos_label_name.Size = new System.Drawing.Size(56, 28);
            this.demos_label_name.TabIndex = 3;
            this.demos_label_name.Text = "Name";
            this.demos_label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // demos_input_name
            // 
            this.demos_input_name.Location = new System.Drawing.Point(65, 3);
            this.demos_input_name.Name = "demos_input_name";
            this.demos_input_name.Size = new System.Drawing.Size(151, 23);
            this.demos_input_name.TabIndex = 4;
            // 
            // demos_checkbox
            // 
            this.demos_checkbox.AutoSize = true;
            this.demos_checkbox.Location = new System.Drawing.Point(10, 22);
            this.demos_checkbox.Name = "demos_checkbox";
            this.demos_checkbox.Size = new System.Drawing.Size(98, 19);
            this.demos_checkbox.TabIndex = 0;
            this.demos_checkbox.Text = "Record Demo";
            this.demos_checkbox.UseVisualStyleBackColor = true;
            this.demos_checkbox.CheckedChanged += new System.EventHandler(this.demos_checkbox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(65, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 23);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(65, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 23);
            this.textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 100);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(65, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 23);
            this.textBox3.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 437);
            this.Controls.Add(this.demos_group_box);
            this.Controls.Add(this.parameters_group_box);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.settings_group_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DSDA Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.settings_group_box.ResumeLayout(false);
            this.settings_table.ResumeLayout(false);
            this.settings_table.PerformLayout();
            this.parameters_group_box.ResumeLayout(false);
            this.parameters_table_additional.ResumeLayout(false);
            this.parameters_table_additional.PerformLayout();
            this.parameters_table_main.ResumeLayout(false);
            this.parameters_table_main.PerformLayout();
            this.demos_group_box.ResumeLayout(false);
            this.demos_group_box.PerformLayout();
            this.demos_table.ResumeLayout(false);
            this.demos_table.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settings_group_box;
        private System.Windows.Forms.TableLayoutPanel settings_table;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.Label settings_label_application;
        private System.Windows.Forms.TextBox settings_input_application;
        private System.Windows.Forms.Button settings_button_application;
        private System.Windows.Forms.Label settings_label_iwad;
        private System.Windows.Forms.Label settings_label_pwad;
        private System.Windows.Forms.TextBox settings_input_iwad;
        private System.Windows.Forms.TextBox settings_input_pwad;
        private System.Windows.Forms.Button settings_button_iwad;
        private System.Windows.Forms.Button settings_button_pwad;
        private System.Windows.Forms.GroupBox parameters_group_box;
        private System.Windows.Forms.TableLayoutPanel parameters_table_main;
        private System.Windows.Forms.Label parameters_label_skill;
        private System.Windows.Forms.Label parameters_label_comp;
        private System.Windows.Forms.Label parameters_label_warp;
        private System.Windows.Forms.ComboBox parameters_combo_box_skill;
        private System.Windows.Forms.ComboBox parameters_combo_box_comp;
        private System.Windows.Forms.TextBox parameters_input_warp;
        private System.Windows.Forms.CheckBox parameters_checkbox_shorttics;
        private System.Windows.Forms.CheckBox parameters_checkbox_nomo;
        private System.Windows.Forms.CheckBox parameters_checkbox_nomusic;
        private System.Windows.Forms.Label parameters_label_additional;
        private System.Windows.Forms.TableLayoutPanel parameters_table_additional;
        private System.Windows.Forms.TextBox parameters_input_additional;
        private System.Windows.Forms.GroupBox demos_group_box;
        private System.Windows.Forms.CheckBox demos_checkbox;
        private System.Windows.Forms.TableLayoutPanel demos_table;
        private System.Windows.Forms.Label demos_label_location;
        private System.Windows.Forms.TextBox demos_input_location;
        private System.Windows.Forms.Button demos_button_browse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label demos_label_name;
        private System.Windows.Forms.TextBox demos_input_name;
    }
}

