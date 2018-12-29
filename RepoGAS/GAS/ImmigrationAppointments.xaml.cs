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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GASLibrary;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for UserAppointments.xaml
    /// </summary>
    public partial class UserAppointments : Page
    {

        GASDBEntities db = new GASDBEntities("metadata=res://*/GASModel.csdl|res://*/GASModel.ssdl|res://*/GASModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.178.48;initial catalog=GASDB;user id=GASuser;password= winter2018;MultipleActiveResultSets=True;App=EntityFramework'");

        List<Appointment> App = new List<Appointment>();
        public UserAppointments()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lstUserList.ItemsSource = App;

            foreach (var item in db.Appointments)
            {
                App.Add(item);

            }

        }
    }
}
