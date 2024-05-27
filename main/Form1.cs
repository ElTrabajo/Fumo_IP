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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string inputDecimal = textBoxDecimalIPAddress.Text;
            string inputBinary = textBoxBinaryIPAddress.Text;

            string input = !string.IsNullOrEmpty(inputDecimal) ? inputDecimal : inputBinary;
            string[] parts = input.Split('/');
            if (parts.Length == 2 && int.TryParse(parts[1], out int cidr))
            {
                if (cidr >= 0 && cidr <= 32)
                {
                    string ipString = parts[0];
                    if (!string.IsNullOrEmpty(inputBinary) && IsBinaryFormat(ipString))
                    {
                        ipString = ConvertBinaryToDecimal(ipString);
                    }

                    if (IPAddress.TryParse(ipString, out IPAddress address))
                    {
                        string ipClass = GetIPClass(address);
                        IPAddress subnetMask = GetSubnetMaskFromCIDR(cidr);
                        IPAddress networkAddress = GetNetworkAddress(address, subnetMask);
                        IPAddress broadcastAddress = GetBroadcastAddress(networkAddress, subnetMask);
                        IPAddress firstIPAddress = GetFirstIPAddress(networkAddress);
                        IPAddress lastIPAddress = GetLastIPAddress(broadcastAddress);
                        int availableIPCount = GetAvailableIPCount(subnetMask);

                        labelClass.Text = $"Classe de l'adresse IP: {ipClass}";
                        labelSubnetMask.Text = $"Masque de sous-réseau CIDR: {subnetMask}";
                        labelNetworkAddress.Text = $"Adresse de réseau: {networkAddress}";
                        labelBroadcastAddress.Text = $"Adresse de broadcast: {broadcastAddress}";
                        labelFirstIPAddress.Text = $"Première adresse IP: {firstIPAddress}";
                        labelLastIPAddress.Text = $"Dernière adresse IP: {lastIPAddress}";
                        labelIPCount.Text = $"Nombre d'adresses IP disponibles: {availableIPCount}";
                    }
                    else
                    {
                        MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("CIDR invalide. Il doit être entre 0 et 32.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Adresse IP ou CIDR invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsBinaryFormat(string ipString)
        {
            string[] parts = ipString.Split('.');
            if (parts.Length != 4) return false;
            return parts.All(part => part.All(c => c == '0' || c == '1'));
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

        static string GetIPClass(IPAddress ipAddress)
        {
            byte firstOctet = ipAddress.GetAddressBytes()[0];
            if (firstOctet >= 1 && firstOctet <= 126)
            {
                return "A";
            }
            else if (firstOctet >= 128 && firstOctet <= 191)
            {
                return "B";
            }
            else if (firstOctet >= 192 && firstOctet <= 223)
            {
                return "C";
            }
            else if (firstOctet >= 224 && firstOctet <= 239)
            {
                return "D";
            }
            else if (firstOctet >= 240 && firstOctet <= 255)
            {
                return "E";
            }
            return null;
        }

        static IPAddress GetSubnetMaskFromCIDR(int cidr)
        {
            uint mask = 0xffffffff;
            mask <<= (32 - cidr);
            return new IPAddress(BitConverter.GetBytes(mask).Reverse().ToArray());
        }

        static IPAddress GetNetworkAddress(IPAddress ipAddress, IPAddress subnetMask)
        {
            byte[] ipBytes = ipAddress.GetAddressBytes();
            byte[] maskBytes = subnetMask.GetAddressBytes();
            byte[] networkBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
            {
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
            }
            return new IPAddress(networkBytes);
        }

        static IPAddress GetBroadcastAddress(IPAddress networkAddress, IPAddress subnetMask)
        {
            byte[] networkBytes = networkAddress.GetAddressBytes();
            byte[] maskBytes = subnetMask.GetAddressBytes();
            byte[] broadcastBytes = new byte[networkBytes.Length];

            for (int i = 0; i < networkBytes.Length; i++)
            {
                broadcastBytes[i] = (byte)(networkBytes[i] | (maskBytes[i] ^ 255));
            }
            return new IPAddress(broadcastBytes);
        }

        static IPAddress GetFirstIPAddress(IPAddress networkAddress)
        {
            byte[] ipBytes = networkAddress.GetAddressBytes();
            ipBytes[ipBytes.Length - 1] += 1; // Ajouter 1 à l'adresse de réseau
            return new IPAddress(ipBytes);
        }

        static IPAddress GetLastIPAddress(IPAddress broadcastAddress)
        {
            byte[] ipBytes = broadcastAddress.GetAddressBytes();
            ipBytes[ipBytes.Length - 1] -= 1; // Soustraire 1 à l'adresse de broadcast
            return new IPAddress(ipBytes);
        }

        static int GetAvailableIPCount(IPAddress subnetMask)
        {
            byte[] maskBytes = subnetMask.GetAddressBytes();
            uint mask = BitConverter.ToUInt32(maskBytes.Reverse().ToArray(), 0);
            return (int)(~mask - 1);
        }
    }
}
    