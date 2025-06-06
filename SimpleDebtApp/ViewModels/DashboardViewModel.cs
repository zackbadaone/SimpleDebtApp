using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SimpleDebtApp.Models;
using System.Collections.ObjectModel;
namespace SimpleDebtApp.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private decimal totalDebt;

    [ObservableProperty]
    private int debtCount;

    [ObservableProperty]
    private ObservableCollection<Debt> debts;
   public DashboardViewModel()
    {
LoadDebtsAsync().Wait();

        Refresh();
    }
    private async Task LoadDebtsAsync() 
    {
        
        Refresh();
    }

    [RelayCommand]
    private void Refresh()
    {
        TotalDebt = Debts.Sum(debt => debt.Amount);
        DebtCount = Debts.Count;
    }
}
