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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDecimalIPAddress = new System.Windows.Forms.TextBox();
            this.textBoxBinaryIPAddress = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSubnetMask = new System.Windows.Forms.Label();
            this.labelNetworkAddress = new System.Windows.Forms.Label();
            this.labelBroadcastAddress = new System.Windows.Forms.Label();
            this.labelFirstIPAddress = new System.Windows.Forms.Label();
            this.labelLastIPAddress = new System.Windows.Forms.Label();
            this.labelIPCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez une adresse IPv4 décimale:";
            // 
            // textBoxDecimalIPAddress
            // 
            this.textBoxDecimalIPAddress.Location = new System.Drawing.Point(261, 20);
            this.textBoxDecimalIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDecimalIPAddress.Name = "textBoxDecimalIPAddress";
            this.textBoxDecimalIPAddress.Size = new System.Drawing.Size(179, 27);
            this.textBoxDecimalIPAddress.TabIndex = 1;
            // 
            // textBoxBinaryIPAddress
            // 
            this.textBoxBinaryIPAddress.Location = new System.Drawing.Point(261, 60);
            this.textBoxBinaryIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBinaryIPAddress.Name = "textBoxBinaryIPAddress";
            this.textBoxBinaryIPAddress.Size = new System.Drawing.Size(179, 27);
            this.textBoxBinaryIPAddress.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(448, 12);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 75);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculer";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(16, 100);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(151, 20);
            this.labelClass.TabIndex = 4;
            this.labelClass.Text = "Classe de l'adresse IP:";
            // 
            // labelSubnetMask
            // 
            this.labelSubnetMask.AutoSize = true;
            this.labelSubnetMask.Location = new System.Drawing.Point(16, 140);
            this.labelSubnetMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubnetMask.Name = "labelSubnetMask";
            this.labelSubnetMask.Size = new System.Drawing.Size(204, 20);
            this.labelSubnetMask.TabIndex = 5;
            this.labelSubnetMask.Text = "Masque de sous-réseau CIDR:";
            // 
            // labelNetworkAddress
            // 
            this.labelNetworkAddress.AutoSize = true;
            this.labelNetworkAddress.Location = new System.Drawing.Point(16, 180);
            this.labelNetworkAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetworkAddress.Name = "labelNetworkAddress";
            this.labelNetworkAddress.Size = new System.Drawing.Size(132, 20);
            this.labelNetworkAddress.TabIndex = 6;
            this.labelNetworkAddress.Text = "Adresse de réseau:";
            // 
            // labelBroadcastAddress
            // 
            this.labelBroadcastAddress.AutoSize = true;
            this.labelBroadcastAddress.Location = new System.Drawing.Point(16, 220);
            this.labelBroadcastAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBroadcastAddress.Name = "labelBroadcastAddress";
            this.labelBroadcastAddress.Size = new System.Drawing.Size(155, 20);
            this.labelBroadcastAddress.TabIndex = 7;
            this.labelBroadcastAddress.Text = "Adresse de broadcast:";
            // 
            // labelFirstIPAddress
            // 
            this.labelFirstIPAddress.AutoSize = true;
            this.labelFirstIPAddress.Location = new System.Drawing.Point(16, 260);
            this.labelFirstIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstIPAddress.Name = "labelFirstIPAddress";
            this.labelFirstIPAddress.Size = new System.Drawing.Size(141, 20);
            this.labelFirstIPAddress.TabIndex = 8;
            this.labelFirstIPAddress.Text = "Première adresse IP:";
            // 
            // labelLastIPAddress
            // 
            this.labelLastIPAddress.AutoSize = true;
            this.labelLastIPAddress.Location = new System.Drawing.Point(16, 300);
            this.labelLastIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastIPAddress.Name = "labelLastIPAddress";
            this.labelLastIPAddress.Size = new System.Drawing.Size(139, 20);
            this.labelLastIPAddress.TabIndex = 9;
            this.labelLastIPAddress.Text = "Dernière adresse IP:";
            // 
            // labelIPCount
            // 
            this.labelIPCount.AutoSize = true;
            this.labelIPCount.Location = new System.Drawing.Point(16, 340);
            this.labelIPCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIPCount.Name = "labelIPCount";
            this.labelIPCount.Size = new System.Drawing.Size(235, 20);
            this.labelIPCount.TabIndex = 10;
            this.labelIPCount.Text = "Nombre d'adresses IP disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Entrez une adresse IPv4 binaire:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIPCount);
            this.Controls.Add(this.labelLastIPAddress);
            this.Controls.Add(this.labelFirstIPAddress);
            this.Controls.Add(this.labelBroadcastAddress);
            this.Controls.Add(this.labelNetworkAddress);
            this.Controls.Add(this.labelSubnetMask);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxBinaryIPAddress);
            this.Controls.Add(this.textBoxDecimalIPAddress);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculateur d'adresse IP";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
