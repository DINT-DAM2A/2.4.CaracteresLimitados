﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LimiteTextBlock.Text = Convert.ToString(TextoTextBox.Text.Length) + "/140";

            if (TextoTextBox.Text.Length == 140)
            {
                TextoTextBox.IsReadOnly = true;
            }
        }
    }
}
