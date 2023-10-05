using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IPATil
{
    class KlasseA : MainWindow
    {
        private string SUBA = "";
        private string IPA = "";
        private string DGA = "";
        static int x = 0;
        static int y = 1;
        static int z = 1;


        public void klasseA20(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                SUBA = "255.0.0.0";
                x = i;
                y = i - 1;
                z = i - 1;
                IPA = $"10.{y}.0.{x}";
                DGA = $"10.{z}.0.254";
                text += $"IP-Adresse: {IPA}\r\nSubnet: {SUBA}\r\nDefault gateway: {DGA}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA21(TextBox TBA)
        {
            string text = "";
            int y = 0;
            int z = 0;

            for (int i = 1; i <= 10; i++)
            {
                SUBA = "255.255.248.0";
                x = i;
                IPA = $"10.0.{y}.{x}";
                DGA = $"10.0.{z}.254";
                text += $"IP-Adresse: {IPA}\r\nSubnet: {SUBA}\r\nDefault gateway: {DGA}\r\n\r\n";

                y += 8;
                z += 8;
            }

            TBA.Text = text;
        }

        public void klasseA22(TextBox TBA)
        {
            string text = "";
            int y = 0;
            int z = 0;

            for (int i = 1; i <= 10; i++)
            {
                SUBA = "255.255.252.0";
                x = i;
                IPA = $"10.0.{y}.{x}";
                DGA = $"10.0.{z}.254";
                text += $"IP-Adresse: {IPA}\r\nSubnet: {SUBA}\r\nDefault gateway: {DGA}\r\n\r\n";

                y += 4;
                z += 4;
            }

            TBA.Text = text;
        }

        public void klasseA23(TextBox TBA)
        {
            string text = "";
            int y = 0;
            int z = 0;

            for (int i = 1; i <= 10; i++)
            {
                SUBA = "255.255.254.0";
                x = i;
                IPA = $"10.0.{y}.{x}";
                DGA = $"10.0.{z}.254";
                text += $"IP-Adresse: {IPA}\r\nSubnet: {SUBA}\r\nDefault gateway: {DGA}\r\n\r\n";

                y += 2;
                z += 2;
            }

            TBA.Text = text;
        }

        public void klasseA24(TextBox TBA)
        {
            string text = "";
            int y = 0;
            int z = 0;

            for (int i = 1; i <= 10; i++)
            {
                SUBA = "255.255.255.0"; // Korrekt subnetmaske for /24
                x = i;
                IPA = $"10.0.{y}.{x}";
                DGA = $"10.0.{z}.254";
                text += $"IP-Adresse: {IPA}\r\nSubnet: {SUBA}\r\nDefault gateway: {DGA}\r\n\r\n";

                y += 1; // Opdateres med 1 for hver iteration
                z += 1; // Opdateres med 1 for hver iteration
            }

            TBA.Text = text;
        }

        public void klasseA25(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i}";
                string subnetMask = "255.255.255.128";
                string defaultGateway = "10.0.0.129";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA26(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i}";
                string subnetMask = "255.255.255.192";
                string defaultGateway = "10.0.0.65";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA27(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i}";
                string subnetMask = "255.255.255.224";
                string defaultGateway = "10.0.0.33";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA28(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i}";
                string subnetMask = "255.255.255.240";
                string defaultGateway = "10.0.0.17";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA29(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i}";
                string subnetMask = "255.255.255.248";
                string defaultGateway = "10.0.0.9";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA30(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i * 2 - 1}";
                string subnetMask = "255.255.255.252";
                string defaultGateway = $"10.0.0.{i * 2}";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

        public void klasseA31(TextBox TBA)
        {
            string text = "";

            for (int i = 1; i <= 10; i++)
            {
                string ipAddress = $"10.0.0.{i * 2 - 1}";
                string subnetMask = "255.255.255.254";
                string defaultGateway = $"10.0.0.{i * 2}";

                text += $"IP-adresse: {ipAddress}\r\nSubnetmaske: {subnetMask}\r\nStandard gateway: {defaultGateway}\r\n\r\n";
            }

            TBA.Text = text;
        }

    }

}
