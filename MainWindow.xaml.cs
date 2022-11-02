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
using WPF_29._10_Cherednichenko_ISRPO12.ApplicationData;
using WPF_29._10_Cherednichenko_ISRPO12.PageMain;

namespace WPF_29._10_Cherednichenko_ISRPO12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new FirstEntities(); //подключение к БД
            AppFrame.frameMain = FrmMain; //загрузка фрейма с началом работы программы

            FrmMain.Navigate(new PageLogin()); //подключение во фрейм стартовой страницы авторизации
        }
    }
}
