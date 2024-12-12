using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShowNow.lib
{
    internal class Ctrl
    {
        public Ctrl() { 
        
        
        }

        public async Task<string> GetPublicIpArddress()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://api.ipify.org");
                    response.EnsureSuccessStatusCode();
                    string ipaddr = await response.Content.ReadAsStringAsync();
                    return ipaddr;

                }
                catch (Exception ex)
                {
                    return "Unable to fetch the IP";
                }


            }

        }
        public string[] NetwokDetails()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            List<string> details = new List<string>();
            foreach (NetworkInterface ni in interfaces)
            {
                //Debug.WriteLine($"Interface Name: {ni.Name}");
                //Debug.WriteLine($"Description: {ni.Description}");
                //Debug.WriteLine($"Status: {ni.OperationalStatus}");
                //Debug.WriteLine($"Speed: {ni.Speed / 1_000_000} Mbps");
                details.Add($"Interface Name: {ni.Name}");
                details.Add($"Description: {ni.Description}");
                details.Add($"Status: {ni.OperationalStatus}");
                details.Add($"Speed: {ni.Speed / 1_000_000} Mbps");
                // Get IP properties
                var ipProperties = ni.GetIPProperties();

                // Display IP Addresses
                foreach (var ip in ipProperties.UnicastAddresses)
                {
                    //Debug.WriteLine($"IP Address: {ip.Address}");
                    //Debug.WriteLine($"Subnet Mask: {ip.IPv4Mask}");
                    details.Add($"IP Address: {ip.Address}");
                    details.Add($"Subnet Mask: {ip.IPv4Mask}");

                }

                // Display Gateway Addresses
                foreach (var gateway in ipProperties.GatewayAddresses)
                {
                    //Debug.WriteLine($"Gateway: {gateway.Address}");
                    details.Add($"Gateway: {gateway.Address}");
                }

                // Display DNS Servers
                foreach (var dns in ipProperties.DnsAddresses)
                {
                    //Debug.WriteLine($"DNS Server: {dns}");
                    details.Add($"DNS Server: {dns}");
                }

                //Debug.WriteLine(new string('-', 50));
                details.Add(new string('-', 50));


            }
            //
            string[] str_details= details.ToArray();
            foreach (var t in str_details) { Debug.WriteLine(t); }
            //Debug.WriteLine(details);
            return str_details;
        }
    }
}
