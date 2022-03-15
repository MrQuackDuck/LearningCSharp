using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Interfaces
    {
        public void Start()
        {
            WiFi myWifi = new WiFi("MiNET", "qwerty12345");
            Phone myPhone = new Phone();

            myPhone.connectToInternet(myWifi, "qwerty12345");
            Console.WriteLine(myPhone.ConnectedWIFI.WiFiName);


            Phone[] myPhones = { new Phone("Xiaomi"), new Phone("IPhone"), new Phone("Huawei") };
            Shop myShop = new Shop(myPhones);
            foreach(Phone p in myShop) 
                p.connectToInternet(myWifi, "qwerty12345");

            myPhones[1].disconnectFromInternet();

            Array.Sort(myPhones);
            foreach(Phone p in myShop)
                Console.WriteLine(p.GadgetModel);
        }
    }

    interface IGadget
    {
        string GadgetModel { get; set; }
        void connectToInternet(IWiFi wifi, string password);
        void disconnectFromInternet();
    }
    interface IWiFi
    {
        string WiFiName { get; set; }
        string Password { get; set; }
        void handleInternetRequest(IGadget phone);
    }

    class Phone : IGadget, ICloneable, IComparable
    {
        public string GadgetModel { get; set; }
        private bool isConnected;
        public IWiFi ConnectedWIFI { get; set; }

        public Phone(string model = "Phone")
        {
            GadgetModel = model;
        }

        public void connectToInternet(IWiFi wifi, string password)
        {
            if (isConnected)
            {
                Console.WriteLine("You already connected to WIFI!");
            }
            else
            {
                if (wifi.Password == password)
                {
                    wifi.handleInternetRequest(this);
                    Console.WriteLine("Internet connected!");
                    ConnectedWIFI = wifi;
                    isConnected = true;
                }
                else
                {
                    Console.WriteLine("Interned connection request failed!");
                    ConnectedWIFI = null;
                }
            }
        }
        public void disconnectFromInternet()
        {
            isConnected = false;
        }

        // IClonable method. Returns Phone object.
        public object Clone() => new Phone();

        // IComparable method. Sort by isConnected variable
        public int CompareTo(object obj)
        {
            if (obj is Phone p)
            {
                if (this.isConnected && !p.isConnected)
                {
                    return 1;
                } 
                else if (this.isConnected && p.isConnected)
                {
                    return -1;
                } 
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ApplicationException("obj is not Phone!");
            }
        }
    }
    class WiFi : IWiFi
    {
        public string Password { get; set; }
        public string WiFiName { get; set; }

        public void handleInternetRequest(IGadget gadget)
        {
            Console.WriteLine($"Gadget {gadget.GadgetModel} connected!");
        }

        public WiFi(string name, string password)
        {
            WiFiName = name;
            Password = password;
        }
    }

    // Realizing IEnumerable interface
    class Shop : IEnumerable
    {
        public Phone[] phones;

        public Shop(Phone[] list)
        {
            phones = list;
        }
        public IEnumerator GetEnumerator()
        {
           // return phones.GetEnumerator(); Alternative form

            foreach (Phone p in phones)
            {
                yield return p;
            }
        }
    }

    // Interfaces with similar methods
    interface IServer
    {
        void DownloadData();
    }
    interface IDataCenter
    {
        void DonwloadData();
    }
    
    class PC : IServer, IDataCenter
    {
        // Explicit interface implementation (realizing method for each interface)
        void IServer.DownloadData()
        {
            // Some functional
        }
        void IDataCenter.DonwloadData()
        {
            // Some another functional
        }
    }


}
