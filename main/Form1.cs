using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace IPAddressCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBoxDecimalIPAddress_TextChanged(object sender, EventArgs e)
        {
            textBoxBinaryIPAddress.Enabled = string.IsNullOrEmpty(textBoxDecimalIPAddress.Text);
        }

        private void textBoxBinaryIPAddress_TextChanged(object sender, EventArgs e)
        {
            textBoxDecimalIPAddress.Enabled = string.IsNullOrEmpty(textBoxBinaryIPAddress.Text);
        }

        private void textBoxCIDR_TextChanged(object sender, EventArgs e)
        {
            textBoxSubnetMask.Enabled = string.IsNullOrEmpty(textBoxCIDR.Text);
        }

        private void textBoxSubnetMask_TextChanged(object sender, EventArgs e)
        {
            textBoxCIDR.Enabled = string.IsNullOrEmpty(textBoxSubnetMask.Text);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string inputDecimal = textBoxDecimalIPAddress.Text;
            string inputBinary = textBoxBinaryIPAddress.Text;
            string inputCIDR = textBoxCIDR.Text;
            string inputSubnetMask = textBoxSubnetMask.Text;

            // Reset labels
            ResetLabels();

            // Determine IP address input type
            string ipString = DetermineIPAddress(inputDecimal, inputBinary);
            if (ipString == null)
            {
                MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cidr = DetermineCIDR(inputCIDR, inputSubnetMask);
            if (cidr == -1)
            {
                return;
            }

            if (IPAddress.TryParse(ipString, out IPAddress address))
            {
                if (IsReservedIPAddress(address))
                {
                    MessageBox.Show("Les adresses IP dans les plages de 0.0.0.0 � 0.255.255.255 et de 127.0.0.0 � 127.255.255.255 ne sont pas autoris�es.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DisplayCalculatedValues(address, cidr);
            }
            else
            {
                MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            labelClass.Visible = true;
            labelSubnetMask.Visible = true;
            labelInverseSubnetMask.Visible = true;
            labelNetworkAddress.Visible = true;
            labelBroadcastAddress.Visible = true;
            labelFirstIPAddress.Visible = true;
            labelLastIPAddress.Visible = true;
            labelIPCount.Visible = true;
            labelMachinesCount.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Effacer le texte des champs de texte
            textBoxDecimalIPAddress.Text = string.Empty;
            textBoxBinaryIPAddress.Text = string.Empty;
            textBoxCIDR.Text = string.Empty;
            textBoxSubnetMask.Text = string.Empty;

            // Cacher les labels des r�sultats
            labelClass.Visible = false;
            labelSubnetMask.Visible = false;
            labelInverseSubnetMask.Visible = false;
            labelNetworkAddress.Visible = false;
            labelBroadcastAddress.Visible = false;
            labelFirstIPAddress.Visible = false;
            labelLastIPAddress.Visible = false;
            labelIPCount.Visible = false;
            labelMachinesCount.Visible = false;

        }
        private void ResetLabels()
        {
            labelClass.Text = string.Empty;
            labelSubnetMask.Text = string.Empty;
            labelNetworkAddress.Text = string.Empty;
            labelBroadcastAddress.Text = string.Empty;
            labelFirstIPAddress.Text = string.Empty;
            labelLastIPAddress.Text = string.Empty;
            labelIPCount.Text = string.Empty;
            labelMachinesCount.Text = string.Empty;
        }

        private string DetermineIPAddress(string inputDecimal, string inputBinary)
        {
            if (!string.IsNullOrEmpty(inputBinary) && IsBinaryFormat(inputBinary))
            {
                return ConvertBinaryToDecimal(inputBinary);
            }
            return inputDecimal;
        }

        private int DetermineCIDR(string inputCIDR, string inputSubnetMask)
        {
            if (!string.IsNullOrEmpty(inputCIDR))
            {
                if (int.TryParse(inputCIDR, out int cidr) && cidr > 0 && cidr <= 32)
                {
                    return cidr;
                }
                else if (cidr == 0)
                {
                    MessageBox.Show("CIDR invalide. Le CIDR ne peut pas �tre �gal � 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("CIDR invalide. Il doit �tre entre 1 et 32.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(inputSubnetMask))
            {
                int cidr = SubnetMaskToCIDR(inputSubnetMask);
                if (cidr != -1)
                {
                    if (cidr < 1)
                    {
                        MessageBox.Show("Masque de sous-r�seau trop petit. Le masque de sous-r�seau minimum est 128.0.0.0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                    return cidr;
                }
                MessageBox.Show("Masque de sous-r�seau invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un CIDR ou un masque de sous-r�seau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        private void DisplayCalculatedValues(IPAddress address, int cidr)
        {
            string ipClass = GetIPClass(address);
            IPAddress subnetMask = GetSubnetMaskFromCIDR(cidr);
            IPAddress networkAddress = GetNetworkAddress(address, subnetMask);
            IPAddress broadcastAddress = GetBroadcastAddress(networkAddress, subnetMask);
            IPAddress firstIPAddress = GetFirstIPAddress(networkAddress);
            IPAddress lastIPAddress = GetLastIPAddress(broadcastAddress);
            int availableIPCount = GetAvailableIPCount(subnetMask);
            int availableMachinesCount = GetAvailableMachinesCount(subnetMask);

            labelClass.Text = $"Classe de l'adresse IP : {ipClass}";
            labelSubnetMask.Text = $"Adresse IP / CIDR : {subnetMask}/{cidr}";
            labelNetworkAddress.Text = $"Adresse de r�seau (@Net) : {networkAddress}";
            labelBroadcastAddress.Text = $"Adresse de broadcast (@Broad) : {broadcastAddress}";
            labelFirstIPAddress.Text = $"Premi�re adresse IP machine : {firstIPAddress}";
            labelLastIPAddress.Text = $"Derni�re adresse IP machine : {lastIPAddress}";
            labelIPCount.Text = $"Nombre d'adresse(s) IP disponible(s) : {availableIPCount}";
            labelMachinesCount.Text = $"Nombre de machine(s) disponible(s) : {availableMachinesCount}";
        }

        private bool IsReservedIPAddress(IPAddress ipAddress)
        {
            byte[] addressBytes = ipAddress.GetAddressBytes();
            return (addressBytes[0] == 0) || (addressBytes[0] == 127);
        }

        private bool IsBinaryFormat(string ipString)
        {
            string[] parts = ipString.Split('.');
            if (parts.Length != 4) return false;
            return parts.All(part => part.Length == 8 && part.All(c => c == '0' || c == '1'));
        }

        private string ConvertBinaryToDecimal(string binaryIP)
        {
            string[] binaryOctets = binaryIP.Split('.');
            byte[] decimalOctets = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                decimalOctets[i] = Convert.ToByte(binaryOctets[i], 2);
            }

            return string.Join(".", decimalOctets);
        }

        private int SubnetMaskToCIDR(string subnetMask)
        {
            if (IPAddress.TryParse(subnetMask, out IPAddress mask))
            {
                byte[] bytes = mask.GetAddressBytes();
                int cidr = bytes.Sum(b => Convert.ToString(b, 2).Count(c => c == '1'));
                return cidr;
            }
            return -1;
        }

        private string GetIPClass(IPAddress ipAddress)
        {
            byte firstOctet = ipAddress.GetAddressBytes()[0];
            if (firstOctet >= 1 && firstOctet <= 126) return "A";
            if (firstOctet >= 128 && firstOctet <= 191) return "B";
            if (firstOctet >= 192 && firstOctet <= 223) return "C";
            if (firstOctet >= 224 && firstOctet <= 239) return "D";
            if (firstOctet >= 240 && firstOctet <= 255) return "E";
            return null;
        }

        private IPAddress GetSubnetMaskFromCIDR(int cidr)
        {
            uint mask = 0xffffffff << (32 - cidr);
            return new IPAddress(BitConverter.GetBytes(mask).Reverse().ToArray());
        }

        private IPAddress GetNetworkAddress(IPAddress ipAddress, IPAddress subnetMask)
        {
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);
            IPAddress ip = IPAddress.Parse(DetermineIPAddress(textBoxDecimalIPAddress.Text, textBoxBinaryIPAddress.Text));

            switch (CIDR)
            {
                case 32:
                    return null;
                default:
                    byte[] ipBytes = ipAddress.GetAddressBytes();
                    byte[] maskBytes = subnetMask.GetAddressBytes();
                    byte[] networkBytes = new byte[ipBytes.Length];

                    for (int i = 0; i < ipBytes.Length; i++)
                    {
                        networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
                    }
                    return new IPAddress(networkBytes);
            }
        }

        private IPAddress GetBroadcastAddress(IPAddress networkAddress, IPAddress subnetMask)
        {
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);
            IPAddress ip = IPAddress.Parse(DetermineIPAddress(textBoxDecimalIPAddress.Text, textBoxBinaryIPAddress.Text));

            switch (CIDR)
            {
                case 32:
                    return null;
                default:
                    byte[] networkBytes = networkAddress.GetAddressBytes();
                    byte[] maskBytes = subnetMask.GetAddressBytes();
                    byte[] broadcastBytes = new byte[networkBytes.Length];

                    for (int i = 0; i < networkBytes.Length; i++)
                    {
                        broadcastBytes[i] = (byte)(networkBytes[i] | ~maskBytes[i]);
                    }
                    return new IPAddress(broadcastBytes);
            }
        }

        private IPAddress GetFirstIPAddress(IPAddress networkAddress)
        {
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);
            IPAddress ip = IPAddress.Parse(DetermineIPAddress(textBoxDecimalIPAddress.Text, textBoxBinaryIPAddress.Text));

            switch (CIDR)
            {
                case 32:
                    return ip;
                case 31:
                    return null;
                default:
                    byte[] ipBytes = networkAddress.GetAddressBytes();
                    ipBytes[ipBytes.Length - 1] += 1;
                    return new IPAddress(ipBytes);
            }
        }

        private IPAddress GetLastIPAddress(IPAddress broadcastAddress)
        {
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);
            IPAddress ip = IPAddress.Parse(DetermineIPAddress(textBoxDecimalIPAddress.Text, textBoxBinaryIPAddress.Text));

            switch (CIDR)
            {
                case 32:
                    return ip;
                case 31:
                    return null;
                default:
                    byte[] ipBytes = broadcastAddress.GetAddressBytes();
                    ipBytes[ipBytes.Length - 1] -= 1;
                    return new IPAddress(ipBytes);
            }
        }

        private int GetAvailableIPCount(IPAddress subnetMask)
        {
            byte[] maskBytes = subnetMask.GetAddressBytes();
            uint mask = BitConverter.ToUInt32(maskBytes.Reverse().ToArray(), 0);

            return (int)(~mask + 1);
        }

        private int GetAvailableMachinesCount(IPAddress subnetMask)
        {
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);

            switch (CIDR)
            {
                case 32:
                    return 1;
                case 31:
                    return 0;
                default:
                    return GetAvailableIPCount(subnetMask) - 2;
            }
        }

        private void CreditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Affichez le message des cr�dits de l'auteur lorsque le lien est cliqu�
            string message = "Cr�dits : \n\n" +
                            "LEMAIRE Cl�ment\n" +
                            "GHEERAERT Elias\n" +
                            "FOURNET Loan\n" +
                            "LASORNE Nathan\n\n" +
                            "2024";

            MessageBox.Show(message, "Cr�dits", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void labelClass_Click(object sender, EventArgs e)
        {

        }
    }
}
