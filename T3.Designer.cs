
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
      this.tableLayoutPanelConnectionSettings = new System.Windows.Forms.TableLayoutPanel();
      this.labelOutStatus = new System.Windows.Forms.Label();
      this.labelInStatus = new System.Windows.Forms.Label();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.flowLayoutOptions = new System.Windows.Forms.FlowLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonSetCurrentRail = new System.Windows.Forms.Button();
      this.labelBridgeStatus = new System.Windows.Forms.Label();
      this.splitContainerCurrentRail = new System.Windows.Forms.SplitContainer();
      this.label7 = new System.Windows.Forms.Label();
      this.labelCurrentRail = new System.Windows.Forms.Label();
      this.buttonTest = new System.Windows.Forms.Button();
      this.flowLayoutPanelNumberOfRails = new System.Windows.Forms.FlowLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.numericUpDownNumberOfRails = new System.Windows.Forms.NumericUpDown();
      this.buttonCreateRails = new System.Windows.Forms.Button();
      this.splitContainerForceTurn = new System.Windows.Forms.SplitContainer();
      this.buttonForceTurnCW = new System.Windows.Forms.Button();
      this.buttonForceTurnCCW = new System.Windows.Forms.Button();
      this.buttonStop = new System.Windows.Forms.Button();
      this.tableLayoutPanelConnectionSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.flowLayoutOptions.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRail)).BeginInit();
      this.splitContainerCurrentRail.Panel1.SuspendLayout();
      this.splitContainerCurrentRail.Panel2.SuspendLayout();
      this.splitContainerCurrentRail.SuspendLayout();
      this.flowLayoutPanelNumberOfRails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRails)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerForceTurn)).BeginInit();
      this.splitContainerForceTurn.Panel1.SuspendLayout();
      this.splitContainerForceTurn.Panel2.SuspendLayout();
      this.splitContainerForceTurn.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonConnectIn
      // 
      this.buttonConnectIn.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.buttonConnectIn.Location = new System.Drawing.Point(174, 5);
      this.buttonConnectIn.Name = "buttonConnectIn";
      this.buttonConnectIn.Size = new System.Drawing.Size(75, 23);
      this.buttonConnectIn.TabIndex = 0;
      this.buttonConnectIn.Text = "Připojit";
      this.buttonConnectIn.UseVisualStyleBackColor = true;
      this.buttonConnectIn.Click += new System.EventHandler(this.ButtonConnectIn_Click);
      // 
      // buttonConnectOut
      // 
      this.buttonConnectOut.Location = new System.Drawing.Point(174, 5);
      this.buttonConnectOut.Name = "buttonConnectOut";
      this.buttonConnectOut.Size = new System.Drawing.Size(75, 23);
      this.buttonConnectOut.TabIndex = 1;
      this.buttonConnectOut.Text = "Připojit";
      this.buttonConnectOut.UseVisualStyleBackColor = true;
      this.buttonConnectOut.Click += new System.EventHandler(this.ButtonConnectOut_Click);
      // 
      // textBoxInIp
      // 
      this.textBoxInIp.Location = new System.Drawing.Point(89, 5);
      this.textBoxInIp.Name = "textBoxInIp";
      this.textBoxInIp.Size = new System.Drawing.Size(77, 20);
      this.textBoxInIp.TabIndex = 2;
      this.textBoxInIp.Text = "127.0.0.1";
      // 
      // textBoxOutIp
      // 
      this.textBoxOutIp.Location = new System.Drawing.Point(89, 5);
      this.textBoxOutIp.Name = "textBoxOutIp";
      this.textBoxOutIp.Size = new System.Drawing.Size(77, 20);
      this.textBoxOutIp.TabIndex = 3;
      this.textBoxOutIp.Text = "127.0.0.1";
      // 
      // textBoxOutPort
      // 
      this.textBoxOutPort.Location = new System.Drawing.Point(89, 36);
      this.textBoxOutPort.Name = "textBoxOutPort";
      this.textBoxOutPort.Size = new System.Drawing.Size(77, 20);
      this.textBoxOutPort.TabIndex = 4;
      this.textBoxOutPort.Text = "13002";
      // 
      // textBoxInPort
      // 
      this.textBoxInPort.Location = new System.Drawing.Point(89, 36);
      this.textBoxInPort.Name = "textBoxInPort";
      this.textBoxInPort.Size = new System.Drawing.Size(77, 20);
      this.textBoxInPort.TabIndex = 5;
      this.textBoxInPort.Text = "13000";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "IP:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(52, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Port:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(52, 2);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(20, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "IP:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(52, 33);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Port:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label5.Location = new System.Drawing.Point(5, 2);
      this.label5.Name = "label5";
      this.tableLayoutPanel1.SetRowSpan(this.label5, 2);
      this.label5.Size = new System.Drawing.Size(39, 26);
      this.label5.TabIndex = 10;
      this.label5.Text = "Síťový\r\nvstup";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label6.Location = new System.Drawing.Point(5, 2);
      this.label6.Name = "label6";
      this.tableLayoutPanelConnectionSettings.SetRowSpan(this.label6, 2);
      this.label6.Size = new System.Drawing.Size(39, 26);
      this.label6.TabIndex = 11;
      this.label6.Text = "Síťový\r\nvýstup";
      // 
      // tableLayoutPanelConnectionSettings
      // 
      this.tableLayoutPanelConnectionSettings.BackColor = System.Drawing.SystemColors.Control;
      this.tableLayoutPanelConnectionSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.tableLayoutPanelConnectionSettings.ColumnCount = 4;
      this.tableLayoutPanelConnectionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelConnectionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelConnectionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelConnectionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.label3, 1, 0);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.label4, 1, 1);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.textBoxOutIp, 2, 0);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.textBoxOutPort, 2, 1);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.labelOutStatus, 3, 1);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.buttonConnectOut, 3, 0);
      this.tableLayoutPanelConnectionSettings.Controls.Add(this.label6, 0, 0);
      this.tableLayoutPanelConnectionSettings.Location = new System.Drawing.Point(3, 70);
      this.tableLayoutPanelConnectionSettings.Name = "tableLayoutPanelConnectionSettings";
      this.tableLayoutPanelConnectionSettings.RowCount = 2;
      this.tableLayoutPanelConnectionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelConnectionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelConnectionSettings.Size = new System.Drawing.Size(280, 55);
      this.tableLayoutPanelConnectionSettings.TabIndex = 13;
      // 
      // labelOutStatus
      // 
      this.labelOutStatus.AutoSize = true;
      this.labelOutStatus.Location = new System.Drawing.Point(174, 33);
      this.labelOutStatus.Name = "labelOutStatus";
      this.labelOutStatus.Size = new System.Drawing.Size(52, 13);
      this.labelOutStatus.TabIndex = 13;
      this.labelOutStatus.Text = "statusOut";
      // 
      // labelInStatus
      // 
      this.labelInStatus.AutoSize = true;
      this.labelInStatus.Location = new System.Drawing.Point(174, 33);
      this.labelInStatus.Name = "labelInStatus";
      this.labelInStatus.Size = new System.Drawing.Size(44, 13);
      this.labelInStatus.TabIndex = 12;
      this.labelInStatus.Text = "statusIn";
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
      this.splitContainerMain.Name = "splitContainerMain";
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.flowLayoutOptions);
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerMain.Panel2.BackgroundImage")));
      this.splitContainerMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.splitContainerMain.Size = new System.Drawing.Size(983, 700);
      this.splitContainerMain.SplitterDistance = 324;
      this.splitContainerMain.TabIndex = 19;
      // 
      // flowLayoutOptions
      // 
      this.flowLayoutOptions.Controls.Add(this.tableLayoutPanel1);
      this.flowLayoutOptions.Controls.Add(this.tableLayoutPanelConnectionSettings);
      this.flowLayoutOptions.Controls.Add(this.buttonSetCurrentRail);
      this.flowLayoutOptions.Controls.Add(this.labelBridgeStatus);
      this.flowLayoutOptions.Controls.Add(this.splitContainerCurrentRail);
      this.flowLayoutOptions.Controls.Add(this.buttonTest);
      this.flowLayoutOptions.Controls.Add(this.flowLayoutPanelNumberOfRails);
      this.flowLayoutOptions.Controls.Add(this.splitContainerForceTurn);
      this.flowLayoutOptions.Controls.Add(this.buttonStop);
      this.flowLayoutOptions.Location = new System.Drawing.Point(3, 3);
      this.flowLayoutOptions.Name = "flowLayoutOptions";
      this.flowLayoutOptions.Size = new System.Drawing.Size(318, 664);
      this.flowLayoutOptions.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxInIp, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonConnectIn, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.textBoxInPort, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.labelInStatus, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 61);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // buttonSetCurrentRail
      // 
      this.buttonSetCurrentRail.Location = new System.Drawing.Point(3, 131);
      this.buttonSetCurrentRail.Name = "buttonSetCurrentRail";
      this.buttonSetCurrentRail.Size = new System.Drawing.Size(280, 26);
      this.buttonSetCurrentRail.TabIndex = 17;
      this.buttonSetCurrentRail.Text = "Nastav počáteční kolej kolej";
      this.buttonSetCurrentRail.UseVisualStyleBackColor = true;
      this.buttonSetCurrentRail.Click += new System.EventHandler(this.ButtonSetCurrentRail_Click);
      // 
      // labelBridgeStatus
      // 
      this.labelBridgeStatus.AutoSize = true;
      this.labelBridgeStatus.Location = new System.Drawing.Point(3, 160);
      this.labelBridgeStatus.Name = "labelBridgeStatus";
      this.labelBridgeStatus.Size = new System.Drawing.Size(37, 13);
      this.labelBridgeStatus.TabIndex = 15;
      this.labelBridgeStatus.Text = "Status";
      // 
      // splitContainerCurrentRail
      // 
      this.splitContainerCurrentRail.Location = new System.Drawing.Point(3, 176);
      this.splitContainerCurrentRail.Name = "splitContainerCurrentRail";
      // 
      // splitContainerCurrentRail.Panel1
      // 
      this.splitContainerCurrentRail.Panel1.Controls.Add(this.label7);
      // 
      // splitContainerCurrentRail.Panel2
      // 
      this.splitContainerCurrentRail.Panel2.Controls.Add(this.labelCurrentRail);
      this.splitContainerCurrentRail.Size = new System.Drawing.Size(280, 36);
      this.splitContainerCurrentRail.SplitterDistance = 93;
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
      this.buttonTest.Location = new System.Drawing.Point(3, 218);
      this.buttonTest.Name = "buttonTest";
      this.buttonTest.Size = new System.Drawing.Size(75, 23);
      this.buttonTest.TabIndex = 22;
      this.buttonTest.Text = "test button";
      this.buttonTest.UseVisualStyleBackColor = true;
      this.buttonTest.Click += new System.EventHandler(this.Rotate_Click);
      // 
      // flowLayoutPanelNumberOfRails
      // 
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.label8);
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.numericUpDownNumberOfRails);
      this.flowLayoutPanelNumberOfRails.Controls.Add(this.buttonCreateRails);
      this.flowLayoutPanelNumberOfRails.Location = new System.Drawing.Point(3, 247);
      this.flowLayoutPanelNumberOfRails.Name = "flowLayoutPanelNumberOfRails";
      this.flowLayoutPanelNumberOfRails.Size = new System.Drawing.Size(280, 29);
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
            5,
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
      // splitContainerForceTurn
      // 
      this.splitContainerForceTurn.Location = new System.Drawing.Point(3, 282);
      this.splitContainerForceTurn.Name = "splitContainerForceTurn";
      // 
      // splitContainerForceTurn.Panel1
      // 
      this.splitContainerForceTurn.Panel1.Controls.Add(this.buttonForceTurnCW);
      // 
      // splitContainerForceTurn.Panel2
      // 
      this.splitContainerForceTurn.Panel2.Controls.Add(this.buttonForceTurnCCW);
      this.splitContainerForceTurn.Size = new System.Drawing.Size(280, 24);
      this.splitContainerForceTurn.SplitterDistance = 137;
      this.splitContainerForceTurn.TabIndex = 24;
      // 
      // buttonForceTurnCW
      // 
      this.buttonForceTurnCW.Location = new System.Drawing.Point(0, 0);
      this.buttonForceTurnCW.Name = "buttonForceTurnCW";
      this.buttonForceTurnCW.Size = new System.Drawing.Size(134, 23);
      this.buttonForceTurnCW.TabIndex = 0;
      this.buttonForceTurnCW.Text = "Vynuť otočení CW";
      this.buttonForceTurnCW.UseVisualStyleBackColor = true;
      this.buttonForceTurnCW.Click += new System.EventHandler(this.ButtonForceTurnCW_Click);
      // 
      // buttonForceTurnCCW
      // 
      this.buttonForceTurnCCW.Location = new System.Drawing.Point(1, 1);
      this.buttonForceTurnCCW.Name = "buttonForceTurnCCW";
      this.buttonForceTurnCCW.Size = new System.Drawing.Size(134, 23);
      this.buttonForceTurnCCW.TabIndex = 0;
      this.buttonForceTurnCCW.Text = "Vynuť otočení CCW";
      this.buttonForceTurnCCW.UseVisualStyleBackColor = true;
      this.buttonForceTurnCCW.Click += new System.EventHandler(this.ButtonForceTurnCCW_Click);
      // 
      // buttonStop
      // 
      this.buttonStop.Location = new System.Drawing.Point(3, 312);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(75, 23);
      this.buttonStop.TabIndex = 25;
      this.buttonStop.Text = "Stop";
      this.buttonStop.UseVisualStyleBackColor = true;
      this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
      // 
      // T3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(984, 730);
      this.Controls.Add(this.splitContainerMain);
      this.Name = "T3";
      this.Text = "T3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.T3_FormClosing);
      this.Load += new System.EventHandler(this.T3_Load);
      this.tableLayoutPanelConnectionSettings.ResumeLayout(false);
      this.tableLayoutPanelConnectionSettings.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.flowLayoutOptions.ResumeLayout(false);
      this.flowLayoutOptions.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.splitContainerCurrentRail.Panel1.ResumeLayout(false);
      this.splitContainerCurrentRail.Panel1.PerformLayout();
      this.splitContainerCurrentRail.Panel2.ResumeLayout(false);
      this.splitContainerCurrentRail.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerCurrentRail)).EndInit();
      this.splitContainerCurrentRail.ResumeLayout(false);
      this.flowLayoutPanelNumberOfRails.ResumeLayout(false);
      this.flowLayoutPanelNumberOfRails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfRails)).EndInit();
      this.splitContainerForceTurn.Panel1.ResumeLayout(false);
      this.splitContainerForceTurn.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerForceTurn)).EndInit();
      this.splitContainerForceTurn.ResumeLayout(false);
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
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnectionSettings;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.Label labelBridgeStatus;
    private System.Windows.Forms.Label labelCurrentRail;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button buttonSetCurrentRail;
    private System.Windows.Forms.SplitContainer splitContainerCurrentRail;
    private System.Windows.Forms.Label labelOutStatus;
    private System.Windows.Forms.Label labelInStatus;
    private System.Windows.Forms.Button buttonTest;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumberOfRails;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberOfRails;
    private System.Windows.Forms.Button buttonCreateRails;
    private System.Windows.Forms.SplitContainer splitContainerForceTurn;
    private System.Windows.Forms.Button buttonForceTurnCW;
    private System.Windows.Forms.Button buttonForceTurnCCW;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutOptions;
    private System.Windows.Forms.Button buttonStop;
  }
}

