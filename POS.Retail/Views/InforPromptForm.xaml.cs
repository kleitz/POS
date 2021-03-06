﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POS.Retail
{
    /// <summary>
    /// Interaction logic for InforPromptForm.xaml
    /// </summary>
    public partial class InforPromptForm : Window
    {
        private static string store_id = null;
        private static string email = null;
        private string p;
        private Domain.Common.Inventory_CustPricesClass objInveCust;
        public InforPromptForm()
        {
            InitializeComponent();
        }

        public InforPromptForm(string p)
        {
            InitializeComponent();
            this.p = p;
            label1.Content = p;
        }

        public InforPromptForm(Domain.Common.Inventory_CustPricesClass objInveCust)
        {
            InitializeComponent();
            this.objInveCust = objInveCust;
            if (objInveCust.message == "item")
            {
                label1.Content = "Please Select Item Number";
            }
            else if(objInveCust.message == "customer")
            {
                label1.Content = "Please Select Customer Number";
            }
        }
        public string set_store_id
        {
            get { return store_id; }
            set { store_id = value; }
        }
        public string set_email
        {
            get { return email; }
            set { email = value; }
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (txt_enter_store_id.Text != "")
            {
                if (label1.Content.Equals("Enter The ID of the New Store You Like to Add"))
                {
                    store_id = txt_enter_store_id.Text;
                    this.Close();
                }
                else if (label1.Content.Equals("Please Enter This Store New Email's Address"))
                {
                    email = txt_enter_store_id.Text;
                    this.Close();
                }
                else if (label1.Content.Equals("Please Select Item Number"))
                {
                    objInveCust.ItemNum = txt_enter_store_id.Text;
                }
                else if (label1.Content.Equals("Please Select Customer Number"))
                {
                    objInveCust.CustNum = txt_enter_store_id.Text;
                }
            }
            else
            {
                this.Close();
            }
            this.Close(); 
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            store_id = null;
            email = null;
            txt_enter_store_id.Focus();
        }
    }
}
