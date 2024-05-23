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
            textBoxIPAddress = new TextBox();
            buttonCalculate = new Button();
            labelClass = new Label();
            labelSubnetMask = new Label();
            labelNetworkAddress = new Label();
            labelBroadcastAddress = new Label();
            labelFirstIPAddress = new Label();
            labelLastIPAddress = new Label();
            labelIPCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 0;
            label1.Text = "Entrez une adresse IPv4 avec CIDR:";
            // 
            // textBoxIPAddress
            // 
            textBoxIPAddress.Location = new Point(261, 20);
            textBoxIPAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxIPAddress.Name = "textBoxIPAddress";
            textBoxIPAddress.Size = new Size(179, 27);
            textBoxIPAddress.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(448, 12);
            buttonCalculate.Margin = new Padding(4, 5, 4, 5);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 35);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Calculer";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Location = new Point(16, 77);
            labelClass.Margin = new Padding(4, 0, 4, 0);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(151, 20);
            labelClass.TabIndex = 3;
            labelClass.Text = "Classe de l'adresse IP:";
            // 
            // labelSubnetMask
            // 
            labelSubnetMask.AutoSize = true;
            labelSubnetMask.Location = new Point(16, 123);
            labelSubnetMask.Margin = new Padding(4, 0, 4, 0);
            labelSubnetMask.Name = "labelSubnetMask";
            labelSubnetMask.Size = new Size(204, 20);
            labelSubnetMask.TabIndex = 4;
            labelSubnetMask.Text = "Masque de sous-réseau CIDR:";
            // 
            // labelNetworkAddress
            // 
            labelNetworkAddress.AutoSize = true;
            labelNetworkAddress.Location = new Point(16, 169);
            labelNetworkAddress.Margin = new Padding(4, 0, 4, 0);
            labelNetworkAddress.Name = "labelNetworkAddress";
            labelNetworkAddress.Size = new Size(132, 20);
            labelNetworkAddress.TabIndex = 5;
            labelNetworkAddress.Text = "Adresse de réseau:";
            // 
            // labelBroadcastAddress
            // 
            labelBroadcastAddress.AutoSize = true;
            labelBroadcastAddress.Location = new Point(16, 215);
            labelBroadcastAddress.Margin = new Padding(4, 0, 4, 0);
            labelBroadcastAddress.Name = "labelBroadcastAddress";
            labelBroadcastAddress.Size = new Size(155, 20);
            labelBroadcastAddress.TabIndex = 6;
            labelBroadcastAddress.Text = "Adresse de broadcast:";
            // 
            // labelFirstIPAddress
            // 
            labelFirstIPAddress.AutoSize = true;
            labelFirstIPAddress.Location = new Point(16, 262);
            labelFirstIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelFirstIPAddress.Name = "labelFirstIPAddress";
            labelFirstIPAddress.Size = new Size(141, 20);
            labelFirstIPAddress.TabIndex = 7;
            labelFirstIPAddress.Text = "Première adresse IP:";
            // 
            // labelLastIPAddress
            // 
            labelLastIPAddress.AutoSize = true;
            labelLastIPAddress.Location = new Point(16, 308);
            labelLastIPAddress.Margin = new Padding(4, 0, 4, 0);
            labelLastIPAddress.Name = "labelLastIPAddress";
            labelLastIPAddress.Size = new Size(139, 20);
            labelLastIPAddress.TabIndex = 8;
            labelLastIPAddress.Text = "Dernière adresse IP:";
            // 
            // labelIPCount
            // 
            labelIPCount.AutoSize = true;
            labelIPCount.Location = new Point(16, 354);
            labelIPCount.Margin = new Padding(4, 0, 4, 0);
            labelIPCount.Name = "labelIPCount";
            labelIPCount.Size = new Size(235, 20);
            labelIPCount.TabIndex = 9;
            labelIPCount.Text = "Nombre d'adresses IP disponibles:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(563, 402);
            Controls.Add(labelIPCount);
            Controls.Add(labelLastIPAddress);
            Controls.Add(labelFirstIPAddress);
            Controls.Add(labelBroadcastAddress);
            Controls.Add(labelNetworkAddress);
            Controls.Add(labelSubnetMask);
            Controls.Add(labelClass);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxIPAddress);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calculateur d'adresse IP";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelSubnetMask;
        private System.Windows.Forms.Label labelNetworkAddress;
        private System.Windows.Forms.Label labelBroadcastAddress;
        private System.Windows.Forms.Label labelFirstIPAddress;
        private System.Windows.Forms.Label labelLastIPAddress;
        private System.Windows.Forms.Label labelIPCount;
    }
}
