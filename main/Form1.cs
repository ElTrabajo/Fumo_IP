using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace CalculateurIP
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

        // Méthode appelée lors du clic sur le bouton "Calculer"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs de texte
            string inputDecimal = textBoxDecimalIPAddress.Text;
            string inputBinary = textBoxBinaryIPAddress.Text;
            string inputCIDR = textBoxCIDR.Text;
            string inputSubnetMask = textBoxSubnetMask.Text;

            ResetLabels();

            string ipString = DetermineIPAddress(inputDecimal, inputBinary);
            if (ipString == null)
            {
                MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Déterminer le CIDR à partir des valeurs fournies
            int cidr = DetermineCIDR(inputCIDR, inputSubnetMask);
            if (cidr == -1)
            {
                return;
            }

            // Vérifier si l'adresse IP est réservée
            if (IPAddress.TryParse(ipString, out IPAddress address))
            {
                if (IsReservedIPAddress(address))
                {
                    MessageBox.Show("Les adresses IP dans les plages de 0.0.0.0 à 0.255.255.255 et de 127.0.0.0 à 127.255.255.255 ne sont pas autorisées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Afficher les valeurs calculées
                AffichageCalcul(address, cidr);
            }
            else
            {
                MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Afficher les labels des résultats
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

        // Méthode appelée lors du clic sur le bouton "Effacer"
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Effacer le texte des champs de texte
            textBoxDecimalIPAddress.Text = string.Empty;
            textBoxBinaryIPAddress.Text = string.Empty;
            textBoxCIDR.Text = string.Empty;
            textBoxSubnetMask.Text = string.Empty;

            // Cacher les labels des résultats
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
        // Réinitialiser les labels des résultats
        private void ResetLabels()
        {
            labelClass.Text = string.Empty;
            labelSubnetMask.Text = string.Empty;
            labelInverseSubnetMask.Text = string.Empty;
            labelNetworkAddress.Text = string.Empty;
            labelBroadcastAddress.Text = string.Empty;
            labelFirstIPAddress.Text = string.Empty;
            labelLastIPAddress.Text = string.Empty;
            labelIPCount.Text = string.Empty;
            labelMachinesCount.Text = string.Empty;
        }

        // Déterminer l'adresse IP 
        private string DetermineIPAddress(string inputDecimal, string inputBinary)
        {
            if (!string.IsNullOrEmpty(inputBinary) && IsBinaryFormat(inputBinary))
            {
                return ConvertBinaryToDecimal(inputBinary);
            }
            return inputDecimal;
        }

        // Déterminer le CIDR
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
                    MessageBox.Show("CIDR invalide. Le CIDR ne peut pas être égal à 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("CIDR invalide. Il doit être entre 1 et 32.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(inputSubnetMask))
            {
                int cidr = SubnetMaskToCIDR(inputSubnetMask);
                if (cidr != -1)
                {
                    if (cidr < 1)
                    {
                        MessageBox.Show("Masque de sous-réseau trop petit. Le masque de sous-réseau minimum est 128.0.0.0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                    return cidr;
                }
                MessageBox.Show("Masque de sous-réseau invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un CIDR ou un masque de sous-réseau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        // Afficher les valeurs calculées
        private void AffichageCalcul(IPAddress address, int cidr)
        {
            string ipClass = GetIPClass(address);
            IPAddress subnetMask = GetSubnetMaskFromCIDR(cidr);
            IPAddress networkAddress = GetNetworkAddress(address, subnetMask);
            IPAddress reverseMaskAdress = GetInverseSubnetMask(subnetMask);
            IPAddress broadcastAddress = GetBroadcastAddress(networkAddress, subnetMask);
            IPAddress firstIPAddress = GetFirstIPAddress(networkAddress);
            IPAddress lastIPAddress = GetLastIPAddress(broadcastAddress);
            int availableIPCount = GetAvailableIPCount(subnetMask);
            int availableMachinesCount = GetAvailableMachinesCount(subnetMask);

            labelClass.Text = $"Classe de l'adresse IP : {ipClass}";
            labelSubnetMask.Text = $"Masque de réseau  / CIDR : {subnetMask}/{cidr}";
            labelInverseSubnetMask.Text = $"Masque de réseau inverse : {reverseMaskAdress}";
            labelNetworkAddress.Text = $"Adresse de réseau (@Net) : {networkAddress}";
            labelBroadcastAddress.Text = $"Adresse de broadcast (@Broad) : {broadcastAddress}";
            labelFirstIPAddress.Text = $"Première adresse IP machine : {firstIPAddress}";
            labelLastIPAddress.Text = $"Dernière adresse IP machine : {lastIPAddress}";
            labelIPCount.Text = $"Nombre d'adresse(s) IP disponible(s) : {availableIPCount}";
            labelMachinesCount.Text = $"Nombre de machine(s) disponible(s) : {availableMachinesCount}";
        }

        // Vérifier si l'adresse IP est réservée
        private bool IsReservedIPAddress(IPAddress ipAddress)
        {
            byte[] addressBytes = ipAddress.GetAddressBytes();
            return (addressBytes[0] == 0) || (addressBytes[0] == 127);
        }

        // Vérifier si le format de l'adresse IP binaire est valide
        private bool IsBinaryFormat(string ipString)
        {
            string[] parts = ipString.Split('.');
            if (parts.Length != 4) return false;
            return parts.All(part => part.Length == 8 && part.All(c => c == '0' || c == '1'));
        }

        // Convertir une adresse IP binaire en décimal
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

        // Convertir un masque de sous-réseau en CIDR
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


        // Obtenir la classe de l'adresse IP

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

        // Obtenir le masque de sous-réseau à partir du CIDR
        private IPAddress GetSubnetMaskFromCIDR(int cidr)
        {
            uint mask = 0xffffffff << (32 - cidr);
            return new IPAddress(BitConverter.GetBytes(mask).Reverse().ToArray());
        }

        // Obtenir le masque de sous-réseau inverse
        private IPAddress GetInverseSubnetMask(IPAddress subnetMask)
        {
            byte[] maskBytes = subnetMask.GetAddressBytes();
            byte[] inverseMaskBytes = new byte[maskBytes.Length];

            for (int i = 0; i < maskBytes.Length; i++)
            {
                inverseMaskBytes[i] = (byte)~maskBytes[i];
            }

            return new IPAddress(inverseMaskBytes);
        }

        // Obtenir l'adresse de réseau
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

        // Obtenir l'adresse de broadcast
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

        // Obtenir la première adresse IP
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

        // Obtenir la dernière adresse IP
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

        // Obtenir le nombre d'adresses IP disponibles
        private int GetAvailableIPCount(IPAddress subnetMask)
        {
            byte[] maskBytes = subnetMask.GetAddressBytes();
            uint mask = BitConverter.ToUInt32(maskBytes.Reverse().ToArray(), 0);
            int availableIPCount = (int)(~mask & 0xFFFFFFFF);

            // Si le masque de sous-réseau est /32, une seule adresse IP est disponible (elle-même).
            if (availableIPCount < 0)
            {
                availableIPCount = 1;
            }

            return availableIPCount + 1;
        }

        // Obtenir le nombre de machines disponibles
        private int GetAvailableMachinesCount(IPAddress subnetMask)
        {
            int availableIPCount = GetAvailableIPCount(subnetMask);
            byte CIDR = (byte)DetermineCIDR(textBoxCIDR.Text, textBoxSubnetMask.Text);

            if (CIDR == 32)
            {
                return 1;
            }
            else if (CIDR == 31)
            {
                return 0;
            }
            else
            {
                return availableIPCount - 2;
            }
        }


        private void CreditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Crédits : \n\n" +
                            "LEMAIRE Clément\n" +
                            "GHEERAERT Elias\n" +
                            "FOURNET Loan\n" +
                            "LASORNE Nathan\n\n" +
                            "2024";

            MessageBox.Show(message, "Crédits", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}