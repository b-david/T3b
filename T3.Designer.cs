
namespace T3
{
  partial class T3
  {
    /// <summary>
    /// Vyžaduje se proměnná návrháře.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Uvolněte všechny používané prostředky.
    /// </summary>
    /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Kód generovaný Návrhářem Windows Form

    /// <summary>
    /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
    /// obsah této metody v editoru kódu.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T3));
      this.buttonConnectIn = new System.Windows.Forms.Button();
      this.buttonConnectOut = new System.Windows.Forms.Button();
      this.textBoxInIp = new System.Windows.Forms.TextBox();
      this.textBoxOutIp = new System.Windows.Forms.TextBox();
      this.textBoxOutPort = new System.Windows.Forms.TextBox();
      this.textBoxInPort = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.labelOutStatus = new System.Windows.Forms.Label();
      this.labelInStatus = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.buttonSetCurrentRail = new System.Windows.Forms.Button();
      this.labelBridgeStatus = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.splitContainerCurrentRail = new System.Windows.Forms.SplitContainer();
      this.label7 = new System.Windows.Forms.Label();
      this.labelCurrentRail = new System.Windows.Forms.Label();
      this.buttonTest = new System.Windows.Forms.Button();
      this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
      this.pictureBoxTurntable = new System.Windows.Forms.PictureBox();
      this.flowLayoutPanelNumberOfRails = new System.Windows.Forms.FlowLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.numericUpDownNumberOfRails = new System.Windows.Forms.NumericUpDown();
      this.buttonCreateRails = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRail)).BeginInit();
      this.splitContainerCurrentRail.Panel1.SuspendLayout();
      this.splitContainerCurrentRail.Panel2.SuspendLayout();
      this.splitContainerCurrentRail.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurntable)).BeginInit();
      this.flowLayoutPanelNumberOfRails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRails)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonConnectIn
      // 
      this.buttonConnectIn.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.buttonConnectIn.Location = new System.Drawing.Point(207, 3);
      this.buttonConnectIn.Name = "buttonConnectIn";
      this.buttonConnectIn.Size = new System.Drawing.Size(75, 23);
      this.buttonConnectIn.TabIndex = 0;
      this.buttonConnectIn.Text = "Připojit";
      this.buttonConnectIn.UseVisualStyleBackColor = true;
      this.buttonConnectIn.Click += new System.EventHandler(this.ButtonConnectIn_Click);
      // 
      // buttonConnectOut
      // 
      this.buttonConnectOut.Location = new System.Drawing.Point(207, 67);
      this.buttonConnectOut.Name = "buttonConnectOut";
      this.buttonConnectOut.Size = new System.Drawing.Size(75, 23);
      this.buttonConnectOut.TabIndex = 1;
      this.buttonConnectOut.Text = "Připojit";
      this.buttonConnectOut.UseVisualStyleBackColor = true;
      this.buttonConnectOut.Click += new System.EventHandler(this.ButtonConnectOut_Click);
      // 
      // textBoxInIp
      // 
      this.textBoxInIp.Location = new System.Drawing.Point(124, 3);
      this.textBoxInIp.Name = "textBoxInIp";
      this.textBoxInIp.Size = new System.Drawing.Size(77, 20);
      this.textBoxInIp.TabIndex = 2;
      this.textBoxInIp.Text = "127.0.0.1";
      // 
      // textBoxOutIp
      // 
      this.textBoxOutIp.Location = new System.Drawing.Point(124, 67);
      this.textBoxOutIp.Name = "textBoxOutIp";
      this.textBoxOutIp.Size = new System.Drawing.Size(77, 20);
      this.textBoxOutIp.TabIndex = 3;
      this.textBoxOutIp.Text = "127.0.0.1";
      // 
      // textBoxOutPort
      // 
      this.textBoxOutPort.Location = new System.Drawing.Point(124, 99);
      this.textBoxOutPort.Name = "textBoxOutPort";
      this.textBoxOutPort.Size = new System.Drawing.Size(77, 20);
      this.textBoxOutPort.TabIndex = 4;
      this.textBoxOutPort.Text = "13002";
      // 
      // textBoxInPort
      // 
      this.textBoxInPort.Location = new System.Drawing.Point(124, 35);
      this.textBoxInPort.Name = "textBoxInPort";
      this.textBoxInPort.Size = new System.Drawing.Size(77, 20);
      this.textBoxInPort.TabIndex = 5;
      this.textBoxInPort.Text = "13000";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(89, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "IP:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(89, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Port:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(89, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(20, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "IP:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(89, 96);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Port:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label5.Location = new System.Drawing.Point(3, 0);
      this.label5.Name = "label5";
      this.tableLayoutPanel1.SetRowSpan(this.label5, 2);
      this.label5.Size = new System.Drawing.Size(46, 33);
      this.label5.TabIndex = 10;
      this.label5.Text = "IN";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label6.Location = new System.Drawing.Point(3, 64);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 32);
      this.label6.TabIndex = 11;
      this.label6.Text = "OUT";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxOutPort, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.textBoxOutIp, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxInPort, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.textBoxInIp, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonConnectIn, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonConnectOut, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.labelOutStatus, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.labelInStatus, 3, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 29);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 130);
      this.tableLayoutPanel1.TabIndex = 13;
      // 
      // labelOutStatus
      // 
      this.labelOutStatus.AutoSize = true;
      this.labelOutStatus.Location = new System.Drawing.Point(207, 96);
      this.labelOutStatus.Name = "labelOutStatus";
      this.labelOutStatus.Size = new System.Drawing.Size(52, 13);
      this.labelOutStatus.TabIndex = 13;
      this.labelOutStatus.Text = "statusOut";
      // 
      // labelInStatus
      // 
      this.labelInStatus.AutoSize = true;
      this.labelInStatus.Location = new System.Drawing.Point(207, 32);
      this.labelInStatus.Name = "labelInStatus";
      this.labelInStatus.Size = new System.Drawing.Size(44, 13);
      this.labelInStatus.TabIndex = 12;
      this.labelInStatus.Text = "statusIn";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 252);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 15;
      this.button1.Text = "0";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.RailClick);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(57, 96);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 16;
      this.button2.Text = "1";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.RailClick);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(226, 29);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 17;
      this.button3.Text = "2";
      this.button3.UseCompatibleTextRendering = true;
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.RailClick);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(396, 102);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 18;
      this.button4.Text = "3";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.RailClick);
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
      this.splitContainerMain.Name = "splitContainerMain";
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.flowLayoutPanel1);
      this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanel1);
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.BackgroundImage = global::T3.Properties.Resources.turntable;
      this.splitContainerMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.splitContainerMain.Panel2.Controls.Add(this.button1);
      this.splitContainerMain.Panel2.Controls.Add(this.button4);
      this.splitContainerMain.Panel2.Controls.Add(this.button2);
      this.splitContainerMain.Panel2.Controls.Add(this.pictureBoxArrow);
      this.splitContainerMain.Panel2.Controls.Add(this.button3);
      this.splitContainerMain.Panel2.Controls.Add(this.pictureBoxTurntable);
      this.splitContainerMain.Size = new System.Drawing.Size(983, 700);
      this.splitContainerMain.SplitterDistance = 324;
      this.splitContainerMain.TabIndex = 19;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.buttonSetCurrentRail);
      this.flowLayoutPanel1.Controls.Add(this.labelBridgeStatus);
      this.flowLayoutPanel1.Controls.Add(this.textBox1);
      this.flowLayoutPanel1.Controls.Add(this.splitContainerCurrentRail);
      this.flowLayoutPanel1.Controls.Add(this.buttonTest);
      this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanelNumberOfRails);
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 165);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 409);
      this.flowLayoutPanel1.TabIndex = 21;
      // 
      // buttonSetCurrentRail
      // 
      this.buttonSetCurrentRail.Location = new System.Drawing.Point(3, 3);
      this.buttonSetCurrentRail.Name = "buttonSetCurrentRail";
      this.buttonSetCurrentRail.Size = new System.Drawing.Size(270, 26);
      this.buttonSetCurrentRail.TabIndex = 17;
      this.buttonSetCurrentRail.Text = "Nastav počáteční kolej kolej";
      this.buttonSetCurrentRail.UseVisualStyleBackColor = true;
      this.buttonSetCurrentRail.Click += new System.EventHandler(this.ButtonSetCurrentRail_Click);
      // 
      // labelBridgeStatus
      // 
      this.labelBridgeStatus.AutoSize = true;
      this.labelBridgeStatus.Location = new System.Drawing.Point(3, 32);
      this.labelBridgeStatus.Name = "labelBridgeStatus";
      this.labelBridgeStatus.Size = new System.Drawing.Size(37, 13);
      this.labelBridgeStatus.TabIndex = 15;
      this.labelBridgeStatus.Text = "Status";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(3, 48);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 21;
      // 
      // splitContainerCurrentRail
      // 
      this.splitContainerCurrentRail.Location = new System.Drawing.Point(3, 74);
      this.splitContainerCurrentRail.Name = "splitContainerCurrentRail";
      // 
      // splitContainerCurrentRail.Panel1
      // 
      this.splitContainerCurrentRail.Panel1.Controls.Add(this.label7);
      // 
      // splitContainerCurrentRail.Panel2
      // 
      this.splitContainerCurrentRail.Panel2.Controls.Add(this.labelCurrentRail);
      this.splitContainerCurrentRail.Size = new System.Drawing.Size(270, 36);
      this.splitContainerCurrentRail.SplitterDistance = 90;
      this.splitContainerCurrentRail.TabIndex = 20;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 5);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(80, 13);
      this.label7.TabIndex = 18;
      this.label7.Text = "Současná kolej";
      // 
      // labelCurrentRail
      // 
      this.labelCurrentRail.AutoSize = true;
      this.labelCurrentRail.Location = new System.Drawing.Point(3, 5);
      this.labelCurrentRail.Name = "labelCurrentRail";
      this.labelCurrentRail.Size = new System.Drawing.Size(35, 13);
      this.labelCurrentRail.TabIndex = 19;
      this.labelCurrentRail.Text = "label8";
      // 
      // buttonTest
      // 
      this.buttonTest.Location = new System.Drawing.Point(3, 116);
      this.buttonTest.Name = "buttonTest";
      this.buttonTest.Size = new System.Drawing.Size(75, 23);
      this.buttonTest.TabIndex = 22;
      this.buttonTest.Text = "test button";
      this.buttonTest.UseVisualStyleBackColor = true;
      this.buttonTest.Click += new System.EventHandler(this.Rotate_Click);
      // 
      // pictureBoxArrow
      // 
      this.pictureBoxArrow.BackColor = System.Drawing.Color.Transparent;
      this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
      this.pictureBoxArrow.Location = new System.Drawing.Point(190, 197);
      this.pictureBoxArrow.Name = "pictureBoxArrow";
      this.pictureBoxArrow.Size = new System.Drawing.Size(140, 139);
      this.pictureBoxArrow.TabIndex = 16;
      this.pictureBoxArrow.TabStop = false;
      // 
      // pictureBoxTurntable
      // 
      this.pictureBoxTurntable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTurntable.Image")));
      this.pictureBoxTurntable.InitialImage = null;
      this.pictureBoxTurntable.Location = new System.Drawing.Point(3, 3);
      this.pictureBoxTurntable.Name = "pictureBoxTurntable";
      this.pictureBoxTurntable.Size = new System.Drawing.Size(510, 510);
      this.pictureBoxTurntable.TabIndex = 14;
      this.pictureBoxTurntable.TabStop = false;
      // 
      // flowLayoutPanelNumberOfRails
      // 
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.label8);
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.numericUpDownNumberOfRails);
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.buttonCreateRails);
      this.flowLayoutPanelNumberOfRails.Location = new System.Drawing.Point(3, 145);
      this.flowLayoutPanelNumberOfRails.Name = "flowLayoutPanelNumberOfRails";
      this.flowLayoutPanelNumberOfRails.Size = new System.Drawing.Size(284, 43);
      this.flowLayoutPanelNumberOfRails.TabIndex = 23;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label8.Location = new System.Drawing.Point(3, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(67, 29);
      this.label8.TabIndex = 0;
      this.label8.Text = "Počet kolejí:";
      // 
      // numericUpDownNumberOfRails
      // 
      this.numericUpDownNumberOfRails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numericUpDownNumberOfRails.Location = new System.Drawing.Point(76, 3);
      this.numericUpDownNumberOfRails.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.numericUpDownNumberOfRails.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDownNumberOfRails.Name = "numericUpDownNumberOfRails";
      this.numericUpDownNumberOfRails.Size = new System.Drawing.Size(60, 20);
      this.numericUpDownNumberOfRails.TabIndex = 1;
      this.numericUpDownNumberOfRails.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // buttonCreateRails
      // 
      this.buttonCreateRails.Location = new System.Drawing.Point(142, 3);
      this.buttonCreateRails.Name = "buttonCreateRails";
      this.buttonCreateRails.Size = new System.Drawing.Size(75, 23);
      this.buttonCreateRails.TabIndex = 2;
      this.buttonCreateRails.Text = "Vytvoř koleje";
      this.buttonCreateRails.UseVisualStyleBackColor = true;
      this.buttonCreateRails.Click += new System.EventHandler(this.ButtonCreateRails_Click);
      // 
      // T3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 730);
      this.Controls.Add(this.splitContainerMain);
      this.Name = "T3";
      this.Text = "T3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.T3_FormClosing);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.splitContainerCurrentRail.Panel1.ResumeLayout(false);
      this.splitContainerCurrentRail.Panel1.PerformLayout();
      this.splitContainerCurrentRail.Panel2.ResumeLayout(false);
      this.splitContainerCurrentRail.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRail)).EndInit();
      this.splitContainerCurrentRail.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurntable)).EndInit();
      this.flowLayoutPanelNumberOfRails.ResumeLayout(false);
      this.flowLayoutPanelNumberOfRails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRails)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonConnectIn;
    private System.Windows.Forms.Button buttonConnectOut;
    private System.Windows.Forms.TextBox textBoxInIp;
    private System.Windows.Forms.TextBox textBoxOutIp;
    private System.Windows.Forms.TextBox textBoxOutPort;
    private System.Windows.Forms.TextBox textBoxInPort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.PictureBox pictureBoxTurntable;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.PictureBox pictureBoxArrow;
    private System.Windows.Forms.Label labelBridgeStatus;
    private System.Windows.Forms.Label labelCurrentRail;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button buttonSetCurrentRail;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.SplitContainer splitContainerCurrentRail;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label labelOutStatus;
    private System.Windows.Forms.Label labelInStatus;
    private System.Windows.Forms.Button buttonTest;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumberOfRails;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberOfRails;
    private System.Windows.Forms.Button buttonCreateRails;
  }
}

