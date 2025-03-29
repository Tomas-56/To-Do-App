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
using ToDoWPF.ViewModel;

namespace ToDoWPF.View
{
    /// <summary>
    /// Interaction logic for TaskPanelView.xaml
    /// </summary>
    public partial class TaskPanelView : UserControl
    {
        public TaskPanelView()
        {
            TaskPanelViewModel taskPanelViewModel = new TaskPanelViewModel();
            DataContext = taskPanelViewModel;
            InitializeComponent();
        }

        
    }
}
