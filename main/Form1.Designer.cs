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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "Entrez une adresse IPv4 décimale:";
            // 
            // textBoxDecimalIPAddress
            // 
            textBoxDecimalIPAddress.Location = new Point(261, 20);
            textBoxDecimalIPAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxDecimalIPAddress.Name = "textBoxDecimalIPAddress";
            textBoxDecimalIPAddress.Size = new Size(179, 27);
            textBoxDecimalIPAddress.TabIndex = 1;
            textBoxDecimalIPAddress.TextChanged += textBoxDecimalIPAddress_TextChanged;
            // 
            // textBoxBinaryIPAddress
            // 
            textBoxBinaryIPAddress.Location = new Point(261, 60);
            textBoxBinaryIPAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxBinaryIPAddress.Name = "textBoxBinaryIPAddress";
            textBoxBinaryIPAddress.Size = new Size(179, 27);
            textBoxBinaryIPAddress.TabIndex = 2;
            textBoxBinaryIPAddress.TextChanged += textBoxBinaryIPAddress_TextChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(448, 12);
            buttonCalculate.Margin = new Padding(4, 5, 4, 5);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 75);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculer";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(16, 140);
            labelClass.Margin = new Padding(4, 0, 4, 0);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(151, 20);
            labelClass.TabIndex = 4;
            labelClass.Text = "Classe de l'adresse IP:";
            // 
            // labelSubnetMask
            // 
            labelSubnetMask.AutoSize = true;
            labelSubnetMask.Location = new Point(16, 180);
            labelSubnetMask.Margin = new Padding(4, 0, 4, 0);
            labelSubnetMask.Name = "labelSubnetMask";
            labelSubnetMask.Size = new Size(204, 20);
            labelSubnetMask.TabIndex = 5;
            labelSubnetMask.Text = "Masque de sous-réseau CIDR:";
            // 
            // labelNetworkAddress
            // 
            labelNetworkAddress.AutoSize = true;
            labelNetworkAddress.Location = new Point(16, 220);
            labelNetworkAddress.Margin = new Padding(4, 0, 4, 0);
            labelNetworkAddress.Name = "labelNetworkAddress";
            labelNetworkAddress.Size = new Size(132, 20);
            labelNetworkAddress.TabIndex = 6;
            labelNetworkAddress.Text = "Adresse de réseau:";
            // 
            // labelBroadcastAddress
            // 
            labelBroadcastAddress.AutoSize = true;
            labelBroadcastAddress.Location = new Point(16, 260);
            labelBroadcastAddress.Margin = new Padding(4, 0, 4, 0);
            labelBroadcastAddress.Name = "labelBroadcastAddress";
            labelBroadcastAddress.Size = new Size(155, 20);
            labelBroadcastAddress.TabIndex = 7;
            labelBroadcastAddress.Text = "Adresse de broadcast:";
            // 
            // labelFirstIPAddress
            // 
            labelFirstIPAddress.AutoSize = true;
            labelFirstIPAddress.Location = new Point(16, 300);
            labelFirstIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelFirstIPAddress.Name = "labelFirstIPAddress";
            labelFirstIPAddress.Size = new Size(141, 20);
            labelFirstIPAddress.TabIndex = 8;
            labelFirstIPAddress.Text = "Première adresse IP:";
            // 
            // labelLastIPAddress
            // 
            labelLastIPAddress.AutoSize = true;
            labelLastIPAddress.Location = new Point(16, 340);
            labelLastIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelLastIPAddress.Name = "labelLastIPAddress";
            labelLastIPAddress.Size = new Size(139, 20);
            labelLastIPAddress.TabIndex = 9;
            labelLastIPAddress.Text = "Dernière adresse IP:";
            // 
            // labelIPCount
            // 
            labelIPCount.AutoSize = true;
            labelIPCount.Location = new Point(16, 380);
            labelIPCount.Margin = new Padding(4, 0, 4, 0);
            labelIPCount.Name = "labelIPCount";
            labelIPCount.Size = new Size(235, 20);
            labelIPCount.TabIndex = 10;
            labelIPCount.Text = "Nombre d'adresses IP disponibles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 11;
            label2.Text = "Entrez une adresse IPv4 binaire:";
            // 
            // textBoxCIDR
            // 
            textBoxCIDR.Location = new Point(261, 100);
            textBoxCIDR.Margin = new Padding(4, 5, 4, 5);
            textBoxCIDR.Name = "textBoxCIDR";
            textBoxCIDR.Size = new Size(179, 27);
            textBoxCIDR.TabIndex = 12;
            textBoxCIDR.TextChanged += textBoxCIDR_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 13;
            label3.Text = "Entrez le CIDR:";
            // 
            // BoxSubnetMask
            // 
            textBoxSubnetMask = new TextBox();
            textBoxSubnetMask.Location = new Point(261, 140);
            textBoxSubnetMask.Margin = new Padding(4, 5, 4, 5);
            textBoxSubnetMask.Name = "textBoxSubnetMask";
            textBoxSubnetMask.Size = new Size(179, 27);
            textBoxSubnetMask.TabIndex = 14; // Ajustez le numéro de tabulation si nécessaire
            Controls.Add(textBoxSubnetMask);
            textBoxSubnetMask.TextChanged += textBoxSubnetMask_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 411);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calculateur d'adresse IP";
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

    }
}