using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SimpleDebtApp.Models;
using SimpleDebtApp.ViewModels;
namespace SimpleDebtApp.Views;

public partial class Dashboard : ContentPage
{
    public Dashboard()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel();
       
    }
}