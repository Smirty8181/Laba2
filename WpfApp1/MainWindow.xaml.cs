using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows; 
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
            HasEducationCheckBox.Checked += (s, e) =>
            {
                EducationTextBox.IsEnabled = true;
            };

            HasEducationCheckBox.Unchecked += (s, e) =>
            {
                EducationTextBox.IsEnabled = false;
            };
        }

        
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (!BirthDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Укажите дату рождения!");
                return;
            }

            
            string education = HasEducationCheckBox.IsChecked == true ? EducationTextBox.Text : "Нет образования";

           
            MessageBox.Show($"Регистрация успешна!\nЛогин: {LoginTextBox.Text}\nИмя: {FirstNameTextBox.Text}\nФамилия: {LastNameTextBox.Text}\nДата рождения: {BirthDatePicker.SelectedDate.Value.ToShortDateString()}\nОбразование: {education}");
        }
    }
}