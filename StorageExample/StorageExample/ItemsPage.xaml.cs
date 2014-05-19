using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections;
using System.IO.IsolatedStorage;
using System.IO;

namespace StorageExample
{
    public partial class ItemsPage : PhoneApplicationPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            populateListBox();
        }

        void populateListBox()
        {
            //  List to hold items in as we read them from storage.
            List<string> myList = new List<string>();

            //  Loop through storage and save.
            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream file = store.OpenFile("settings.txt", FileMode.OpenOrCreate))
                {
                    if (file != null)
                    {
                        StreamReader reader = new StreamReader(file);
                        string line = reader.ReadToEnd();

                        //  Add each item to the list
                        myList.Add(line);

                        reader.Close();
                    }
                   
                }
            }

            //  Convert from List to Array
            string[] myArray = myList.ToArray();

            //  Populate List Box on Page
            listBox1.ItemsSource = myArray;
        }
    }
}