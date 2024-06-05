namespace IPAddressCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxDecimalIPAddress = new TextBox();
            textBoxBinaryIPAddress = new TextBox();
            buttonCalculate = new Button();
            labelClass = new Label();
            labelSubnetMask = new Label();
            labelNetworkAddress = new Label();
            labelBroadcastAddress = new Label();
            labelFirstIPAddress = new Label();
            labelLastIPAddress = new Label();
            labelIPCount = new Label();
            label2 = new Label();
            textBoxCIDR = new TextBox();
            label3 = new Label();
            textBoxSubnetMask = new TextBox();
            label4 = new Label();
            buttonClear = new Button();
            label5 = new Label();
            labelMachinesCount = new Label();
            linkLabelCredit = new LinkLabel();
            labelInverseSubnetMask = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 0;
            label1.Text = "Entrez une adresse IPv4 décimale:";
            // 
            // textBoxDecimalIPAddress
            // 
            textBoxDecimalIPAddress.Location = new Point(228, 15);
            textBoxDecimalIPAddress.Margin = new Padding(4, 4, 4, 4);
            textBoxDecimalIPAddress.MaxLength = 15;
            textBoxDecimalIPAddress.Name = "textBoxDecimalIPAddress";
            textBoxDecimalIPAddress.Size = new Size(157, 23);
            textBoxDecimalIPAddress.TabIndex = 1;
            textBoxDecimalIPAddress.TextChanged += textBoxDecimalIPAddress_TextChanged;
            // 
            // textBoxBinaryIPAddress
            // 
            textBoxBinaryIPAddress.Location = new Point(228, 45);
            textBoxBinaryIPAddress.Margin = new Padding(4, 4, 4, 4);
            textBoxBinaryIPAddress.MaxLength = 35;
            textBoxBinaryIPAddress.Name = "textBoxBinaryIPAddress";
            textBoxBinaryIPAddress.Size = new Size(157, 23);
            textBoxBinaryIPAddress.TabIndex = 2;
            textBoxBinaryIPAddress.TextChanged += textBoxBinaryIPAddress_TextChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(392, 9);
            buttonCalculate.Margin = new Padding(4, 4, 4, 4);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(88, 56);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculer";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(14, 175);
            labelClass.Margin = new Padding(4, 0, 4, 0);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(120, 15);
            labelClass.TabIndex = 4;
            labelClass.Text = "Classe de l'adresse IP:";
            labelClass.Visible = false;
            // 
            // labelSubnetMask
            // 
            labelSubnetMask.AutoSize = true;
            labelSubnetMask.Location = new Point(14, 200);
            labelSubnetMask.Margin = new Padding(4, 0, 4, 0);
            labelSubnetMask.Name = "labelSubnetMask";
            labelSubnetMask.Size = new Size(137, 15);
            labelSubnetMask.TabIndex = 5;
            labelSubnetMask.Text = "Masque de sous-réseau :";
            labelSubnetMask.Visible = false;
            // 
            // labelNetworkAddress
            // 
            labelNetworkAddress.AutoSize = true;
            labelNetworkAddress.Location = new Point(14, 250);
            labelNetworkAddress.Margin = new Padding(4, 0, 4, 0);
            labelNetworkAddress.Name = "labelNetworkAddress";
            labelNetworkAddress.Size = new Size(104, 15);
            labelNetworkAddress.TabIndex = 6;
            labelNetworkAddress.Text = "Adresse de réseau:";
            labelNetworkAddress.Visible = false;
            // 
            // labelBroadcastAddress
            // 
            labelBroadcastAddress.AutoSize = true;
            labelBroadcastAddress.Location = new Point(14, 325);
            labelBroadcastAddress.Margin = new Padding(4, 0, 4, 0);
            labelBroadcastAddress.Name = "labelBroadcastAddress";
            labelBroadcastAddress.Size = new Size(122, 15);
            labelBroadcastAddress.TabIndex = 7;
            labelBroadcastAddress.Text = "Adresse de broadcast:";
            labelBroadcastAddress.Visible = false;
            // 
            // labelFirstIPAddress
            // 
            labelFirstIPAddress.AutoSize = true;
            labelFirstIPAddress.Location = new Point(14, 275);
            labelFirstIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelFirstIPAddress.Name = "labelFirstIPAddress";
            labelFirstIPAddress.Size = new Size(112, 15);
            labelFirstIPAddress.TabIndex = 8;
            labelFirstIPAddress.Text = "Première adresse IP:";
            labelFirstIPAddress.Visible = false;
            // 
            // labelLastIPAddress
            // 
            labelLastIPAddress.AutoSize = true;
            labelLastIPAddress.Location = new Point(14, 300);
            labelLastIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelLastIPAddress.Name = "labelLastIPAddress";
            labelLastIPAddress.Size = new Size(109, 15);
            labelLastIPAddress.TabIndex = 9;
            labelLastIPAddress.Text = "Dernière adresse IP:";
            labelLastIPAddress.Visible = false;
            // 
            // labelIPCount
            // 
            labelIPCount.AutoSize = true;
            labelIPCount.Location = new Point(14, 350);
            labelIPCount.Margin = new Padding(4, 0, 4, 0);
            labelIPCount.Name = "labelIPCount";
            labelIPCount.Size = new Size(187, 15);
            labelIPCount.TabIndex = 10;
            labelIPCount.Text = "Nombre d'adresses IP disponibles:";
            labelIPCount.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 11;
            label2.Text = "Entrez une adresse IPv4 binaire:";
            // 
            // textBoxCIDR
            // 
            textBoxCIDR.Location = new Point(228, 75);
            textBoxCIDR.Margin = new Padding(4, 4, 4, 4);
            textBoxCIDR.MaxLength = 2;
            textBoxCIDR.Name = "textBoxCIDR";
            textBoxCIDR.Size = new Size(157, 23);
            textBoxCIDR.TabIndex = 12;
            textBoxCIDR.TextChanged += textBoxCIDR_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 13;
            label3.Text = "Entrez le CIDR:";
            // 
            // textBoxSubnetMask
            // 
            textBoxSubnetMask.Location = new Point(228, 105);
            textBoxSubnetMask.Margin = new Padding(4, 4, 4, 4);
            textBoxSubnetMask.MaxLength = 15;
            textBoxSubnetMask.Name = "textBoxSubnetMask";
            textBoxSubnetMask.Size = new Size(157, 23);
            textBoxSubnetMask.TabIndex = 14;
            textBoxSubnetMask.TextChanged += textBoxSubnetMask_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 15;
            label4.Text = "Entrez le masque de réseau:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(392, 75);
            buttonClear.Margin = new Padding(4, 4, 4, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(88, 56);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Effacer";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(10, 164);
            label5.Name = "label5";
            label5.Size = new Size(472, 2);
            label5.TabIndex = 18;
            label5.Text = "label5";
            // 
            // labelMachinesCount
            // 
            labelMachinesCount.AutoSize = true;
            labelMachinesCount.Location = new Point(14, 375);
            labelMachinesCount.Margin = new Padding(4, 0, 4, 0);
            labelMachinesCount.Name = "labelMachinesCount";
            labelMachinesCount.Size = new Size(187, 15);
            labelMachinesCount.TabIndex = 19;
            labelMachinesCount.Text = "Nombre de machines disponibles:";
            labelMachinesCount.Visible = false;
            // 
            // linkLabelCredit
            // 
            linkLabelCredit.Anchor = AnchorStyles.Bottom;
            linkLabelCredit.AutoSize = true;
            linkLabelCredit.Location = new Point(209, 403);
            linkLabelCredit.Margin = new Padding(0);
            linkLabelCredit.Name = "linkLabelCredit";
            linkLabelCredit.Size = new Size(44, 15);
            linkLabelCredit.TabIndex = 20;
            linkLabelCredit.TabStop = true;
            linkLabelCredit.Text = "Crédits";
            linkLabelCredit.LinkClicked += CreditLabel_LinkClicked;
            // 
            // labelInverseSubnetMask
            // 
            labelInverseSubnetMask.AutoSize = true;
            labelInverseSubnetMask.Location = new Point(14, 225);
            labelInverseSubnetMask.Name = "labelInverseSubnetMask";
            labelInverseSubnetMask.Size = new Size(177, 15);
            labelInverseSubnetMask.TabIndex = 21;
            labelInverseSubnetMask.Text = "Masque de sous-réseau inverse :";
            labelInverseSubnetMask.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 425);
            Controls.Add(labelInverseSubnetMask);
            Controls.Add(linkLabelCredit);
            Controls.Add(labelMachinesCount);
            Controls.Add(label5);
            Controls.Add(buttonClear);
            Controls.Add(label4);
            Controls.Add(textBoxSubnetMask);
            Controls.Add(label3);
            Controls.Add(textBoxCIDR);
            Controls.Add(label2);
            Controls.Add(labelIPCount);
            Controls.Add(labelLastIPAddress);
            Controls.Add(labelFirstIPAddress);
            Controls.Add(labelBroadcastAddress);
            Controls.Add(labelNetworkAddress);
            Controls.Add(labelSubnetMask);
            Controls.Add(labelClass);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxBinaryIPAddress);
            Controls.Add(textBoxDecimalIPAddress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculateur IPv4";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDecimalIPAddress;
        private System.Windows.Forms.TextBox textBoxBinaryIPAddress;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelSubnetMask;
        private System.Windows.Forms.Label labelNetworkAddress;
        private System.Windows.Forms.Label labelBroadcastAddress;
        private System.Windows.Forms.Label labelFirstIPAddress;
        private System.Windows.Forms.Label labelLastIPAddress;
        private System.Windows.Forms.Label labelIPCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCIDR;
        private Label label3;
        private System.Windows.Forms.TextBox textBoxSubnetMask;
        private Label label4;
        private System.Windows.Forms.Button buttonClear;
        private Label label5;
        private Label labelMachinesCount;
        private LinkLabel linkLabelCredit;
        private Label labelInverseSubnetMask;
    }
}
